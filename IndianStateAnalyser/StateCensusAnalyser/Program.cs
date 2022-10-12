using StateCensusAnalyser.UsingCensus;
using StateCensusAnalyser.UsingStateCode;

namespace StateCensusAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePathStateCensus = @"C:\GitRepository\IndianStatesCensusAnalyser\IndianStateAnalyser\StateCensusAnalyser\UsingCensus\StateCensus.csv";
            string filePath = @"C:\GitRepository\IndianStatesCensusAnalyser\IndianStateAnalyser\StateCensusAnalyser\UsingStateCode\StateCode.csv";

            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            int StateCensusRecords = analyzer.ReadStateCensusData(filePathStateCensus);
            CSVStateCensus census = new CSVStateCensus();
            int censusRecords = census.ReadStateCensusData(filePathStateCensus);
            if (StateCensusRecords == censusRecords)
                Console.WriteLine("Numbers Of Records Matches");

            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            int StateCodeRecords = stateCodeAnalyzer.ReadStateCodeData(filePath);
            CSVStateCensus stateCensus = new CSVStateCensus();
            int codeRecords = stateCensus.ReadStateCodeData(filePath);
            if (StateCodeRecords == codeRecords)
                Console.WriteLine("Number of records match");
        }
    }
}