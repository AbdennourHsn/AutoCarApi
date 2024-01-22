namespace api.DTOs
{
    public class ShowroomDto
    {
        public string  Name { get; set; }
        public string  Descriptiom { get; set; }
        public string  DateOfCreation { get; set; }
        public int NbrOfCars { get; set; }
        public int[] Cars {get ; set;}
        public int EnvironmentId{get; set;}
        public int OwnerId {get ; set;}
        
    }
}