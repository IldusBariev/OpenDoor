namespace OpenDoor.Entitty
{
    public class ApplicantEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }

        public ApplicantEntity()
        {

        }

        public ApplicantEntity(string name)
        {
            Name = name;
            DateTime = DateTime.Now;
        }
    }
}
