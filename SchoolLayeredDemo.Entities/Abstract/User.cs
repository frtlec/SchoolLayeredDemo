using Core.Entities;
using System;

namespace SchoolLayeredDemo.Entities.Abstract
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LastIp { get; set; }
        public string LastloginDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
