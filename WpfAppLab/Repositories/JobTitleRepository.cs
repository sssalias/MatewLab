using WpfAppLab.Models;

namespace WpfAppLab.Repositories
{
    internal static class JobTitleRepository
    {

        private static DBConfig _context;

        static JobTitleRepository()
        {
            _context = new DBConfig();
        }

        public static List<JobTitle> GetJobTitles()
        {
            return _context.JobTitles.ToList();
        }

        public static JobTitle? GetJobTitles(int Id)
        {
            JobTitle? jobTitle = _context.JobTitles.Find(Id);
            if (jobTitle == null)
            {
                return null;
            }
            return jobTitle;
        }

        public static JobTitle CreateJobTitle(JobTitle jobTitle)
        {
            _context.JobTitles.Add(jobTitle);
            _context.SaveChanges();
            return jobTitle;
        }

        public static void DeleteJobTitle(int Id)
        {
            JobTitle? jobTitle = _context.JobTitles.Find(Id);

            if (jobTitle == null)
            {
                throw new Exception("Запись не найдена!");
            }
            _context.JobTitles.Remove(jobTitle);
            _context.SaveChanges();
        }
    }
}
