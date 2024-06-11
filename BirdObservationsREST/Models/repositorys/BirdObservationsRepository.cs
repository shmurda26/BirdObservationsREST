using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdObservationsLib
{
    public class BirdObservationsRepository
    {
        private int _nextId = 6;
        private List<BirdObservation> BirdObservations = new List<BirdObservation>
        {
            new BirdObservation { Id = 1,Species = "Blåmejse",HowMany=2},
            new BirdObservation {  Id = 2,Species = "Ringdue",HowMany=8},
            new BirdObservation {  Id = 3,Species = "Musvit",HowMany=2},
            new BirdObservation { Id = 4,Species = "sølvmåge",HowMany=12},
            new BirdObservation { Id = 5,Species = "spætmejse",HowMany=1},
        };
        public List<BirdObservation> GetAll()
        {
            return BirdObservations;

        }
        public BirdObservation? GetById(int Id)
        {
            return BirdObservations.Find(b => b.Id == Id);
        }
        public BirdObservation Add(BirdObservation birdObs)
        {
            birdObs.Id = _nextId++;
            BirdObservations.Add(birdObs);
            return birdObs;
        }
        //public BirdObservation remove(int Id) 
        //{ 
        //    {
        //    BirdObservation BirdObservations = GetById(Id);
        //        birdObservations.remove(BirdObservations);
        //    return BirdObservations;
        //}
        }
    }


    

