using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace Books_catalog
{
    public partial class Form1 : Form
    {
        private List<Book> _books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = txtTitle.Text,
                Autor = txtAutor.Text,
                Genre = txtGenre.Text,
                Year = int.TryParse(txtYear.Text, out int year) ? year : 0

            };

            _books.Add(book);
            RefreshList();

        }

        private void removeBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {
                _books.Remove(selectedBook);
                RefreshList();
            }
        }

        private void searchBook_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            var result = _books.Where(b => b.Title.ToLower().Contains(search) ||
                                     b.Autor.ToLower().Contains(search)).ToList();

            listBoxBooks.DataSource = result;

            if (string.IsNullOrEmpty(search))
            {
                RefreshList();
                return;
            }

        }

        private void RefreshList()
        {
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = _books;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            RefreshList();
        }

        private void butnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(_books, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("books.json", json);
                MessageBox.Show("Книги сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении", ex.Message);
            }
        }

        private void butnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("books.json"))
                {
                    string json = File.ReadAllText("books.json");
                    _books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
                    RefreshList();
                    MessageBox.Show("Книги загружены!");

                }
                else
                {
                    MessageBox.Show("Файл не найден.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке: " + ex.Message);
            }

        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Autor {  get; set; }
        public string Genre {  get; set; }
        public int Year {  get; set; }

        public override string ToString()
        {
            return $"{Title} - {Autor} {Year} {Genre}";
        }

    }

}
