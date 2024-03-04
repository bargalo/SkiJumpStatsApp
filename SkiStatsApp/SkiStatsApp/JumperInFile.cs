using System.Xml.Linq;

namespace SkiStatsApp
{
    public class JumperInFile : JumperBase
    {
        public override event JumpLenghtDelegate JumpAdded;
        
        public JumperInFile(string name, string surname)
           : base(name, surname)
        {
            var fileName = File.AppendText(name + surname + ".txt");           
            fileName.Close();
        }
        public override void AddDistance(float distance)
        {
            if (distance >= 0 && distance <= 180)
            {
                using (var writer = File.AppendText(Name + Surname + ".txt"))
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
        public override void AddDistance(string distance)
        {
            if (float.TryParse(distance, out float result))
            {
                AddDistance(result);
            }
            else
            {
                throw new Exception("Wrong data!");
            }
        }

        public override void AddDistance(int distance)
        {
            AddDistance((float)distance);
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            if (File.Exists(Name + Surname + ".txt"))
            {
                using (var reader = File.OpenText(Name + Surname + ".txt"))
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
