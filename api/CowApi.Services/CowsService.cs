using System;
using System.Collections.Generic;
using CowApi.Models.Cows;

namespace CowApi.Services
{
    public class CowsService : ICowsService
    {
        public List<Cow> cows = new List<Cow>();

        public CowsService()
        {
            cows.Add(new Cow
            {
                ID = "Anna",
                BirthDate = new DateOnly(2021, 7, 14),
                Breed = "F",
                MatureBodyWeight = 558
            });
            cows.Add(new Cow
            {
                ID = "Beryl",
                BirthDate = new DateOnly(2021, 5, 2),
                Breed = "F",
                MatureBodyWeight = 593
            });
            cows.Add(new Cow
            {
                ID = "Chloe",
                BirthDate = new DateOnly(2021, 9, 30),
                Breed = "F",
                MatureBodyWeight = 523
            });
        }

        /// <summary>
        /// Adds a new cow to the system
        /// </summary>
        /// <param name="cow"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool AddCow(Cow cow)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// removes a cow from the system
        /// </summary>
        /// <param name="cow"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool DeleteCow(Cow cow)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all of the cows currently in the system
        /// </summary>
        /// <returns></returns>
        public List<Cow> GetAllCows()
        {
            return cows;
        }
    }
}
