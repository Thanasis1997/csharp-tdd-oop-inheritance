﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("JUnit Rocks");
            Library library = new Library();
            book.addToStock(book);
            Assert.AreEqual("item has been checked out", book.checkOutBook("JUnit Rocks"));
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks");
            Library library = new Library();
            book.addToStock(book);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOutBook("JUnit Rocks"));
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("JUnit Rocks");
            Library library = new Library();
            book.addToStock(book);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkInBook("JUnit Rocks"));
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks");
            Library library = new Library();
            book.addToStock(book);

            Assert.AreEqual("item is not currently on loan", book.checkInBook("JUnit Rocks"));
        }
    }
}