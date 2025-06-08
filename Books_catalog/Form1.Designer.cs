namespace Books_catalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            txtAutor = new TextBox();
            txtYear = new TextBox();
            txtGenre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            listBoxBooks = new ListBox();
            addBook = new Button();
            removeBook = new Button();
            searchBook = new Button();
            txtSearch = new TextBox();
            label5 = new Label();
            btnReset = new Button();
            butnSave = new Button();
            butnLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите название книги";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(26, 57);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(309, 54);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 138);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 2;
            label2.Text = "Введите автора книги";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(26, 166);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(305, 64);
            txtAutor.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(26, 281);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(305, 41);
            txtYear.TabIndex = 4;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(26, 363);
            txtGenre.Multiline = true;
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(305, 44);
            txtGenre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 252);
            label3.Name = "label3";
            label3.Size = new Size(180, 15);
            label3.TabIndex = 6;
            label3.Text = "Введите год издательства книги";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 335);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 7;
            label4.Text = "Введите жанр книги";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(871, 17);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(525, 424);
            listBoxBooks.TabIndex = 8;
            // 
            // addBook
            // 
            addBook.Location = new Point(361, 299);
            addBook.Name = "addBook";
            addBook.Size = new Size(119, 23);
            addBook.TabIndex = 9;
            addBook.Text = "Добавить книгу";
            addBook.UseVisualStyleBackColor = true;
            addBook.Click += addBook_Click;
            // 
            // removeBook
            // 
            removeBook.Location = new Point(361, 335);
            removeBook.Name = "removeBook";
            removeBook.Size = new Size(112, 23);
            removeBook.TabIndex = 10;
            removeBook.Text = "Удалить книгу";
            removeBook.UseVisualStyleBackColor = true;
            removeBook.Click += removeBook_Click;
            // 
            // searchBook
            // 
            searchBook.Location = new Point(530, 299);
            searchBook.Name = "searchBook";
            searchBook.Size = new Size(100, 23);
            searchBook.TabIndex = 11;
            searchBook.Text = "Поиск книги";
            searchBook.UseVisualStyleBackColor = true;
            searchBook.Click += searchBook_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(400, 194);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(351, 36);
            txtSearch.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 166);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 13;
            label5.Text = "Введите текст для поиска";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(361, 373);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 23);
            btnReset.TabIndex = 14;
            btnReset.Text = "Очистить поиск";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // butnSave
            // 
            butnSave.Location = new Point(530, 335);
            butnSave.Name = "butnSave";
            butnSave.Size = new Size(115, 23);
            butnSave.TabIndex = 15;
            butnSave.Text = "Сохранить книгу";
            butnSave.UseVisualStyleBackColor = true;
            butnSave.Click += butnSave_Click;
            // 
            // butnLoad
            // 
            butnLoad.Location = new Point(530, 373);
            butnLoad.Name = "butnLoad";
            butnLoad.Size = new Size(112, 23);
            butnLoad.TabIndex = 16;
            butnLoad.Text = "Загрузить книгу";
            butnLoad.UseVisualStyleBackColor = true;
            butnLoad.Click += butnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 450);
            Controls.Add(butnLoad);
            Controls.Add(butnSave);
            Controls.Add(btnReset);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(searchBook);
            Controls.Add(removeBook);
            Controls.Add(addBook);
            Controls.Add(listBoxBooks);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtGenre);
            Controls.Add(txtYear);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Books_catalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtAutor;
        private TextBox txtYear;
        private TextBox txtGenre;
        private Label label3;
        private Label label4;
        private ListBox listBoxBooks;
        private Button addBook;
        private Button removeBook;
        private Button searchBook;
        private TextBox txtSearch;
        private Label label5;
        private Button btnReset;
        private Button butnSave;
        private Button butnLoad;
    }
}
