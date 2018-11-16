﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Country : EntityBase
    {
        public string Name  { get; set; }
        public string Flag  { get; set; }

        public ICollection<State> States { get; set; }

    }
}
