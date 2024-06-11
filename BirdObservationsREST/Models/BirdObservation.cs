namespace BirdObservationsLib
{
    public class BirdObservation
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public int HowMany { get; set; }

        public override string ToString()
        {
            return $"Id: {Id},Species:{Species},HowMany:{HowMany}";

        }
        public void ValidateSpecies() //Validerngsmetoden "ValidateSpecies()" sørger for at den Species der bliver puttet ind overholde dens krav.
        {
            if (string.IsNullOrEmpty(Species))//If Statementen her sikre at Species der bliver tastet in ikke er null
                throw new System.ArgumentNullException("Species must be entered");//Formlen for kravene 
            if (Species.Length < 2)//If Statementen ser om Speciesen der bliver indtastet dækker kravet om min 2 characthers
                throw new System.ArgumentOutOfRangeException("Speicies is requried to be at least 2 characters");//Formlen for kravene
        }
        public void ValidateHowMany()//Validerngsmetoden "ValidateHowMany()" sørger for at det antal der bliver tastet ind er et gyldigt antal.
        {
            if (HowMany < 1)//If Statementen kontrollere at der ikke bliver indtastet værdi som ikke er over 0.
                throw new System.ArgumentOutOfRangeException("the quantatatiy most be more than 0");//Formlen for kravene
        }
        //Metoden under kalder de to valideringsmetoder jeg har lavet
        public void Validate()//Validerngs metoden "Validate()" kontroller om alle at alle indsatte værdier er valide
                              //Den står som public fordi den skal kunne tilgås fra andre klasser
        {
            ValidateSpecies();
            ValidateHowMany();
            
        }
    }
}
