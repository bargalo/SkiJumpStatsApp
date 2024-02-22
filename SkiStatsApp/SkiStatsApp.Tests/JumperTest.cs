namespace SkiStatsApp.Tests
{
    public class JumperTest
    {
        [Test]
        public void WhenGetStatisticsCalledShouldReturnCorrectLongest()
        {
            string fileNameAdamMa�ysz = "AdamMa�ysz.txt";
            if (File.Exists(fileNameAdamMa�ysz))
            {
                File.Delete(fileNameAdamMa�ysz);
            }
            
            var jumper = new JumperAMa�ysz("Takanobu", "Okabe");
            jumper.AddDistance(125);
            jumper.AddDistance(150);
            jumper.AddDistance(155);
            jumper.AddDistance(111);           
            
            var stats = jumper.GetStatistics();

            Assert.AreEqual(155, stats.Longest);            
        }
        [Test]
        public void WhenGetStatisticsCalledShouldReturnCorrectShortest()
        {
            string fileNameAdamMa�ysz = "AdamMa�ysz.txt";
            if (File.Exists(fileNameAdamMa�ysz))
            {
                File.Delete(fileNameAdamMa�ysz);
            }

            var jumper = new JumperAMa�ysz("Takanobu", "Okabe");
            jumper.AddDistance(125);
            jumper.AddDistance(150);
            jumper.AddDistance(155);
            jumper.AddDistance(90);            

            var stats = jumper.GetStatistics();

            Assert.AreEqual(90, stats.Shortest);
            
        }
        [Test]
        public void WhenGetStatisticsCalledShouldReturnCorrectCount()
        {
            string fileNameAdamMa�ysz = "AdamMa�ysz.txt";
            if (File.Exists(fileNameAdamMa�ysz))
            {
                File.Delete(fileNameAdamMa�ysz);
            }

            var jumper = new JumperAMa�ysz("Takanobu", "Okabe");
            jumper.AddDistance(110);
            jumper.AddDistance(141);
            jumper.AddDistance(157);
            jumper.AddDistance(85);

            var stats = jumper.GetStatistics();

            Assert.AreEqual(4, stats.Count);

        }
        [Test]
        public void WhenGetStatisticsCalledShouldReturnCorrectAverage()
        {
            string fileNameAdamMa�ysz = "AdamMa�ysz.txt";
            if (File.Exists(fileNameAdamMa�ysz))
            {
                File.Delete(fileNameAdamMa�ysz);
            }

            var jumper = new JumperAMa�ysz("Takanobu", "Okabe");
            jumper.AddDistance(145);
            jumper.AddDistance(130);
            jumper.AddDistance(157);
            jumper.AddDistance(85);

            var stats = jumper.GetStatistics();

            Assert.AreEqual(129.25f, stats.Average);

        }
        [Test]
        public void WhenGetStatisticsCalledShouldReturnCorrectTotalLenght()
        {
            string fileNameAdamMa�ysz = "AdamMa�ysz.txt";
            if (File.Exists(fileNameAdamMa�ysz))
            {
                File.Delete(fileNameAdamMa�ysz);
            }

            var jumper = new JumperAMa�ysz("Takanobu", "Okabe");
            jumper.AddDistance(130);
            jumper.AddDistance(115.5f);
            jumper.AddDistance(88);
            jumper.AddDistance(85);

            var stats = jumper.GetStatistics();

            Assert.AreEqual(418.5f, stats.TotalLenght);

        }
        [Test]
        public void WhenGetStatisticsCalledShouldReturnCorrectJumperLevel()
        {
            string fileNameAdamMa�ysz = "AdamMa�ysz.txt";
            if (File.Exists(fileNameAdamMa�ysz))
            {
                File.Delete(fileNameAdamMa�ysz);
            }

            var jumper = new JumperAMa�ysz("Takanobu", "Okabe");
            jumper.AddDistance(110);
            jumper.AddDistance(115.5f);
            jumper.AddDistance(148);
            jumper.AddDistance(100);

            var stats = jumper.GetStatistics();

            Assert.AreEqual("Good", stats.JumperLevel);

        }
    }
}