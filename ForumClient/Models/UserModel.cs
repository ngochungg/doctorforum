﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumClient.Models
{
    public partial class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Experience { get; set; }
        public string Qualification { get; set; }
        public string Professional { get; set; }
        public string CreatedAt { get; set; }
        public string RoleId { get; set; }
        public int Status { get; set; }
        public int Look { get; set; }
        public int Share { get; set; }

    }
}
