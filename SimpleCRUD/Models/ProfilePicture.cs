using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleCRUD.Models
{
    public class ProfilePicture
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Content { get; set; }

        public byte[] Data { get; set; }

    }
}