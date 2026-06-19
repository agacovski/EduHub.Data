namespace EduHub.Data.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the default EduHub Directory if non-standard environment (ie. testing)
            EduHubContext.DefaultEduHubDirectory = @"C:\eduHub";

            // Simple Sample
            SimpleSample.Run();

            // Navigation Sample
            NavigationSample.Run();

            // Complex Sample (May only run successfully when AKC and AR datasets are manually added to Service C)
           // ComplexSample.Run();

            // Write-Back Sample
            // WriteBackSample.Run();
        }
    }
}
