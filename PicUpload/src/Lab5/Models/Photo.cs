using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Lab5.Models
{
    public class Photo
    {
        public int PhotoId
        {
            get;
            set;
        }
        
        [StringLength(2048)]
        public string Title
        {
            get;
            set;
        }
        [StringLength(2048)]
        public string Url
        {
            get;
            set;
        }

    }
}
