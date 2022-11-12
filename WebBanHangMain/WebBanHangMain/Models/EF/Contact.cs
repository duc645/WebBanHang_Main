﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace WebBanHangMain.Models.EF
{
    [Table("tb_Contact")]
    public class Contact :CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(150, ErrorMessage = "Không được viết trên 150 ký tự")]
        public string Name { get; set; }

        [StringLength(150, ErrorMessage = "Không được viết trên 150 ký tự")]
        [EmailAddress(ErrorMessage = "Hãy nhập đúng định dạng email")]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string Email { get; set; }

        public string Website { get; set; }

        [StringLength(5000, ErrorMessage = "Không được viết trên 5000 ký tự")]
        public string Message { get; set; }

        public bool IsRead { get; set; }
    }
}