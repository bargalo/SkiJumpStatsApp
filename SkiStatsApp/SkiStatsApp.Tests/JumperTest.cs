namespace SkiStatsApp.Tests
{
    public class JumperTest
    {
        [Test]
        public void WhenGetStatisticsCalledShouldReturnCorrectLongest()
        {
            string fileName = "TakanobuOkabe.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            
            var jumper = new JumperInFile("Takanobu", "Okabe");
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
            string fileName = "TakanobuOkabe.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var jumper = new JumperInFile("Takanobu", "Okabe");
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
            string fileName = "TakanobuOkabe.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var jumper = new JumperInFile("Takanobu", "Okabe");
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
            string fileName = "TakanobuOkabe.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var jumper = new JumperInFile("Takanobu", "Okabe");
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
            string fileName = "TakanobuOkabe.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var jumper = new JumperInFile("Takanobu", "Okabe");
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
            string fileName = "TakanobuOkabe.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var jumper = new JumperInFile("Takanobu", "Okabe");
            jumper.AddDistance(110);
            jumper.AddDistance(115.5f);
            jumper.AddDistance(148);
            jumper.AddDistance(100);

            var stats = jumper.GetStatistics();

            Assert.AreEqual("Good", stats.JumperLevel);

        }
    }
}