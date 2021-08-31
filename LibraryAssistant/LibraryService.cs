﻿using LibraryAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LibraryAssistant
{
    public class LibraryService
    {

        static readonly HttpClient client = new HttpClient();
        static readonly string bookAddress = "https://localhost:44390/api/Books/";
        static readonly string memberAddress = "https://localhost:44390/api/Members/";
        static readonly string authAddress = "https://localhost:44390/api/AuthManagement/";

        //GET All books
        public async Task<List<Book>> GetBooks()
        {
            var post = await client.GetFromJsonAsync<List<Book>>(bookAddress);
            Console.WriteLine("Executed GetBooks()");
            return post;
        }

        //GET book by ID
        public async Task<Book> GetBook(int id)
        {
            var post = await client.GetFromJsonAsync<Book>(bookAddress + id);
            Console.WriteLine("Executed GetBook(ID)");
            return post;
        }

        //POST book
        public async Task PostBook(Book book)
        {
            await client.PostAsJsonAsync(bookAddress, book);
            Console.WriteLine("Executed PostBook()");
        }

        //PUT Book by ID - trenger vedlikehold
        public async Task PutBook(int id, Book book)
        {
            await client.PutAsJsonAsync(bookAddress + id, book);
            Console.WriteLine("Executed PutBook()");
            System.Diagnostics.Debug.WriteLine("Checkpoint");
        }

        //DELETE Book by ID
        public async Task DeleteBook(int id)
        {
            await client.DeleteAsync(bookAddress + id);
            Console.WriteLine("Executed DeleteBook");
        }

        /***************************************************/

        //GET All Members
        public async Task<List<Member>> GetMembers()
        {
            var post = await client.GetFromJsonAsync<List<Member>>(memberAddress);
            Console.WriteLine("Executed GetMembers()");
            return post;
        }


        //GET Member by ID
        public async Task<Member> GetMember(int id)
        {
            var post = await client.GetFromJsonAsync<Member>(memberAddress + id);
            Console.WriteLine("Executed GetMember(ID)");
            return post;
        }

        //POST Member
        public async Task PostMember(Member member)
        {
            await client.PostAsJsonAsync(memberAddress, member);
            Console.WriteLine("Executed PostMember()");
            System.Diagnostics.Debug.WriteLine("PostMember()");
        }

        //PUT Member by ID - trenger vedlikehold
        public async Task PutMember(int id, Member member)
        {
            await client.PutAsJsonAsync(memberAddress + id, member);
            Console.WriteLine("Executed PutMember()");
            
        }

        //DELETE Member by ID
        public async Task DeleteMember(int id)
        {
            await client.DeleteAsync(memberAddress + id);
            Console.WriteLine("Executed DeleteMember");
        }

        public async Task RegisterAccount(Member member)
        {
            try
            {
                await client.PostAsJsonAsync(authAddress + "Register", member);
                System.Diagnostics.Debug.WriteLine("Dette skjer");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Feil" + e.ToString());
            }
        }

        public async Task Login(Member member)
        {
            await client.PostAsJsonAsync(authAddress + "Login", member);
        }
    }
}