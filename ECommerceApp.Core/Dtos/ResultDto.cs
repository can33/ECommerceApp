using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Core.Dtos
{
    public class ResultDto
    {
        public bool Succeeded { get; set; }
        public string[] Errors { get; set; }
        public ResultDto(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }
        public static ResultDto Success()
        {
            return new ResultDto(true, Array.Empty<string>());
        }
        public static ResultDto Failed(IEnumerable<string> errors)
        {
            return new ResultDto(false, errors);
        }
    }
}
