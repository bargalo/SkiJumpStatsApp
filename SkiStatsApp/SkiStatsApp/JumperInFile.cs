namespace SkiStatsApp
{
    public class JumperInFile : JumperBase
    {
        public override event JumpLenghtDelegate JumpAdded;
        
        public JumperInFile(string name, string surname)
           : base(name, surname)
        {
            FileName = name + surname + ".txt";           
        }
        public string FileName { get; private set; }
        
        public override void AddDistance(float distance)
        {
            if (distance >= 0 && distance <= 180)
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine(distance);
                }
                if (JumpAdded != null)
                {
                    JumpAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Wrong data!");
            }
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        stats.AddDistance(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return stats;
        } 
    }
}
