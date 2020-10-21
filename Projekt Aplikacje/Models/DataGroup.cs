﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Projekt_Aplikacje.Models
{
    public class DataGroup
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Unit { get; set; }

        public List<DataModel> Datas { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}