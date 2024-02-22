using static SkiStatsApp.JumperBase;

namespace SkiStatsApp
{
    public class JumperNKasai : JumperBase
    {
        public override event JumpLenghtDelegate JumpAdded;

        private const string fileNameNoriakiKasai = "NoriakiKasai.txt";

        public JumperNKasai(string name, string surname)
            : base(name, surname)
        {
        }
        public override void AddDistance(float distance)
        {
            if (distance >= 0 && distance <= 180)
            {
                using (var writer = File.AppendText(fileNameNoriakiKasai))
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

            if (File.Exists(fileNameNoriakiKasai))
            {
                using (var reader = File.OpenText(fileNameNoriakiKasai))
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
