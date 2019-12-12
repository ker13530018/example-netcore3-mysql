using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MysqlDemo.Models
{
    [Table("blogs")]
    public class Blog
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
