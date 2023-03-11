using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DemoMvc.Models
{
    public class Student
    {
        [DisplayName("Mã sinh viên")]
        public string Id { get; set; }
        [DisplayName("Tên sinh viên")]
        public string Name { get; set; }
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        [DisplayName("Giới tính")]
        public bool Gender { get; set; }
        [DisplayName("Điểm")]
        public float Avg { get; set; }
    }
}