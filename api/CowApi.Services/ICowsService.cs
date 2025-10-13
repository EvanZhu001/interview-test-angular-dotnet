using System.Collections.Generic;
using CowApi.Models.Cows;

namespace CowApi.Services
{
    public interface ICowsService
    {
        List<Cow> GetAllCows();

        bool AddCow(Cow cow);

        bool DeleteCow(Cow cow);
    }
}
    