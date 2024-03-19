using static SkiStatsApp.JumperBase;

namespace SkiStatsApp
{
    public interface IJumper
    {
        public string Name { get; }
        public string Surname { get; }
        void AddDistance(float distance);
        void AddDistance(string distance);
        void AddDistance(int distance);
        Statistics GetStatistics();

        event JumpLenghtDelegate JumpAdded;
        void ShowStatistics();
    }
}
