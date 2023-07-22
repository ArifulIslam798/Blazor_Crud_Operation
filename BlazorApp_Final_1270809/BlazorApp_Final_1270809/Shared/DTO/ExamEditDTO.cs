﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorApp_Final_1270809.Shared.DTO
{
    public class ExamEditDTO
    {
        public int ExamID { get; set; }
        [StringLength(50), Display(Name = "Exam Name")]
        public string ExamName { get; set; } = default!;

        [Column(TypeName = "money"), DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal ExamFee { get; set; }
        public virtual ICollection<ExamResultEditDTO> ExamResults { get; set; } = new List<ExamResultEditDTO>();
    }
}
