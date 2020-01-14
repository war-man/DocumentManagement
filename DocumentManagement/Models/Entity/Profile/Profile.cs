﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models.Entity.Profile
{
    public class Profile
    {
        // Hồ sơ ID
        public int ProfileID { get; set; }
        // Hộp số ID
        public int GearBoxID { get; set; }
        //Mã hồ sơ
        public string ProfileCode { get; set; }
        // Tiêu đề hồ sơ
        public string ProfileTitle { get; set; }
        // Tên hồ sơ
        public string ProfileName { get; set; }
        // Ngày tạo
        public DateTime CreateTime { get; set; }
        // Ngày Cập nhật
        public DateTime UpdateTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Note { get; set; }
        public int ShelfLife {get;set;}
        public string ProfileTypeName { get; set; }
        public string GearBoxCode { get; set; }

    }
}