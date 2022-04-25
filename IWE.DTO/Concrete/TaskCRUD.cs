﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWE.DTO.Concrete
{
    public class TaskCRUD
    {
        public string TaskName { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public bool Status { get; set; }
    }
}
