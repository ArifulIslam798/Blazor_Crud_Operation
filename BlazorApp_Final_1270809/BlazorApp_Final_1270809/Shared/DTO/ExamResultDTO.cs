using BlazorApp_Final_1270809.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp_Final_1270809.Shared.DTO
{
    public class ExamResultDTO
    {
        [ForeignKey("Exam")]
        public int ExamID { get; set; }
        [ForeignKey("Trainee")]
        public int TraineeID { get; set; }
        [EnumDataType(typeof(Result))]
        public Result Result { get; set; }
    }
}
