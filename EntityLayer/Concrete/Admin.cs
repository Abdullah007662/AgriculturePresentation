﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Admin
	{
        public int AdminID { get; set; }
        public string? KullanıcıAdı { get; set; }
        public string? Şifre { get; set; }
    }
}
