using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Data.Sqlite;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}