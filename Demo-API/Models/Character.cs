namespace Demo_API.Models{
    public class Character{
        public int Id { get; set; }
        public string Name { get; set; }="Mohamed";
        public int HitPoints { get; set; }=10;
        public int Strength { get; set; }=10;
        public int Defense { get; set; }=10;
        public int Intelligence { get; set; }=10;
        public RgpOption RgpOption { get; set; }=RgpOption.Cleric;
    }
}