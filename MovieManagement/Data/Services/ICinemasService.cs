using MovieManagement.Data.Base;
using MovieManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManagement.Data.Services
{
    public interface ICinemasService:IEntityBaseRepository<Cinema>
    {
    }
}
