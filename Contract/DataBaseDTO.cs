namespace BackEndDevelopment.Contract
{
    public class DataBaseDTO
    {
        public string Name { get; set; }
        public double Version {  get; set; }
        public int DefaultPort { get; set; } = 5432;
    }
}
