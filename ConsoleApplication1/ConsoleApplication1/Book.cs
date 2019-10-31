using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Book
    {
        private string Name;
        private double Price;
        private Author Author;
        private int Qty;

        public Book(string name,  Author author, double price)
        {
            this.Name = name;
            this.Price = price;
            this.Author = author;
            this.Qty = 0;
        }
        public Book(string name,  Author author, double price, int qty)
            : this(name, author, price)
        {   
            this.Qty = qty;
        }
        public string GetName() { return this.Name; }
        public Author GetAuthor() { return this.Author; }
        public double GetPrice() { return this.Price; }
        public void SetPrice(double price) { this.Price = price; }
        public int GetQty() { return this.Qty; }
        public void SetQty(int qty) { this.Qty = qty; }
        public override string ToString()
        {
            return String.Format("Book[name={0},{1},price={2},qty={3}", this.Name, this.Author.ToString(), this.Price, this.Qty);
        }
        public string GetAuthorName()
        {
            return Author.GetName();
        }
        public string GetAuthorEmail()
        {
            return Author.GetEmail();
        }
        public char GetAuthorGender()
        {
            return Author.GetGender();
        }
    }
}
