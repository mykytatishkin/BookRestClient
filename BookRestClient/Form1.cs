using BookRestClient.Models;
using Microsoft.VisualBasic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BookRestClient
{
    public partial class Form1 : Form
    {
        List<Book> books = null;
        JsonSerializerOptions options;
        public Form1()
        {
            InitializeComponent();
            books = new List<Book>();

            options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.Converters.Add(new JsonStringEnumConverter());

            btAddBook.Enabled = false;
        }

        private async void btAddBook_Click(object sender, EventArgs e)
        {
            // TODO: add new book

            using (HttpClient client = new HttpClient())
            {
                string url    = "http://localhost:5015/api/books";
                string title  = tbTitle.Text;
                string author = tbAuthor.Text;
                int price     = Convert.ToInt32(tbPrice.Text);
                Book book = new Book()
                {
                    Title  = title,
                    Author = author,
                    Price  = price
                };
                string bookToSend = JsonSerializer.Serialize(book);
                var data = new StringContent(bookToSend, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url,data);
                if(response.IsSuccessStatusCode)
                {
                    Form1_Load(null, new EventArgs());
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // TODO: display list of books - Done
            // http://localhost:5015/api/books

            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:5015/api/books";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string book_list = await response.Content.ReadAsStringAsync();
                    books = JsonSerializer.Deserialize<List<Book>>(book_list, options);
                    dataGridView1.DataSource = books;
                }
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            TextBox tmp = (TextBox)sender;
            if(tmp.Text.Length == 0)
            {
                btAddBook.Enabled = false;
            }
            else
            {
                btAddBook.Enabled = true;
            }
        }
    }
}