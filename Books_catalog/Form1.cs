namespace Books_catalog
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
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
            books.Add(book);
            RefreshList();

        }

        private void removeBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {
                books.Remove(selectedBook);
                RefreshList();
            }
        }

        private void searchBook_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            var result = books.Where(b =>b.Title.ToLower().Contains(search)||
                                     b.Autor.ToLower().Contains(search)).ToList();

            listBoxBooks.DataSource = result;

            if(string.IsNullOrEmpty(search))
            {
                RefreshList();
                return;
            }

            
        }

        private void RefreshList()
        {
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = books;
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
