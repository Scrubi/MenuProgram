using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMaster.Models
{
    public class Category
    {
        public string CategoryName { get; set; }

		

		public Category(string categoryname)
		{
			this.CategoryName = categoryname;
		}

	}
}
