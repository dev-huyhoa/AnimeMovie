using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Shared.ViewModels;

namespace MovieShare.Ultilities
{
    public class Ultility
    {
        public static Response Responses(string message, bool success, object data = null, string description = null)
        {
            Response res = new Response();
            res.Success = success;
            res.Message = message;
            res.Data = data;
            res.Description = description;
            return res;
        }
    }
}
