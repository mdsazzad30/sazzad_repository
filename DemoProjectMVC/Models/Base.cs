﻿namespace DemoProjectMVC.Models
{
    public class Base
    {
        public int Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public int CreateBy { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public int UpdateBy { get; set; }
    }
}
