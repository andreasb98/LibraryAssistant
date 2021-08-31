﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryAssistant.Model
{
  
    public partial class Book
    {
      
        public int Id { get; set; }
       
        public string Title { get; set; }
       
        public string Author { get; set; }
       
        public string Publisher { get; set; }
       
        public bool? IsAvail { get; set; }
    }
}
