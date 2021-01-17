using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SterrenbeeldService.Repositories
{
    public interface ISterrenbeeldRepository
    {
        String getSterrenbeeld(int dag, int maand);
    }
}
