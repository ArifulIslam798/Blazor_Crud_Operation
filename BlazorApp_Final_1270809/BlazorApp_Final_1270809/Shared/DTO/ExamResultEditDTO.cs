using BlazorApp_Final_1270809.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp_Final_1270809.Shared.DTO
{
    public class ExamResultEditDTO
    {
        [Key]
        public int ExamID { get; set; }
        [Required]
        public int TraineeID { get; set; }
        public Result Result { get; set; }
    }
}
