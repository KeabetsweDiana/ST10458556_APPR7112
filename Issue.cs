using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10458556_APPR7112
{
   
    
        public class Issue
        {
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public string FilePath { get; set; }

            public Issue(string location, string category, string description, string filePath)
            {
                Location = location;
                Category = category;
                Description = description;
                FilePath = filePath;
            }

            public override string ToString()
            {
                return $"Location: {Location}, Category: {Category}, Description: {Description}, File: {FilePath}";
            }
        }
    }


