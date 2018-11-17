﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YAMLTest
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public Person Person { get; set; }
    }
}
