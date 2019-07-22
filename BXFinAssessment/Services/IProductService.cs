using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BXFinAssessment.Services
{
    public interface IProductService
    {
        int[] Reverse(int[] productIds);

        int[] DeletePart(int position, int[] productIds);
    }
}