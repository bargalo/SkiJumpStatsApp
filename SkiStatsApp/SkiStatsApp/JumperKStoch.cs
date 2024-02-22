using System.Xml.Linq;
using static SkiStatsApp.JumperBase;

namespace SkiStatsApp
{
    public class JumperKStoch : JumperBase
    {
        private const string fileNameKamilStoch = "KamilStoch.txt";

        public override event JumpLenghtDelegate JumpAdded;

        public JumperKStoch(string name, string surname)
          : base(name, surname)
        {
        }
        public override void AddDistance(float distance)
        {
            if (distance >= 0 && distance <= 180)
            {
                using (var writer = File.AppendText(fileNameKamilStoch))
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

            if (File.Exists(fileNameKamilStoch))
            {
                using (var reader = File.OpenText(fileNameKamilStoch))
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
