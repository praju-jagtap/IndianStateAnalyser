using StateCensusAnalyser.UsingCensus;
using StateCensusAnalyser.UsingStateCode;

namespace IndianStateAnalyserTest
{
    public class Tests
    {
        public string stateCensusFilePath = @"C:\GitRepository\IndianStatesCensusAnalyser\IndianStateAnalyser\StateCensusAnalyser\UsingCensus\StateCensus.csv";
        public string stateCodeFilePath = @"C:\GitRepository\IndianStatesCensusAnalyser\IndianStateAnalyser\StateCensusAnalyser\UsingStateCode\StateCode.csv";

        //TC1.1 - Given the States Census CSV file, Check to ensure the Number of Record matches

        [Test]
        public void GivenStateCensusData_ShouldReturnNoOfRecordsMatches()
        {
            StateCensusAnalyzer analyser = new StateCensusAnalyzer();
            CSVStateCensus stateCensus = new CSVStateCensus();
            Assert.AreEqual(stateCensus.ReadStateCensusData(stateCensusFilePath), analyser.ReadStateCensusData(stateCensusFilePath));
        }

        //TC1.2 - Given the State Census CSV File if incorrect Returns a custom Exception

        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenSAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer analyser = new StateCensusAnalyzer();
            try
            {
                int records = analyser.ReadStateCensusData(stateCensusFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Path");

            }
        }

        //TC1.3 - Given the State Census CSV File when correct but type incorrect Returns a custom Exception

        [Test]
        public void GivenStateCensusDataFileTypeIncorrect_WhenSAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer analyser = new StateCensusAnalyzer();
            try
            {
                int records = analyser.ReadStateCensusData(stateCensusFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Path");

            }
        }

        //TC1.4 - Given the State Census CSV File when correct but delemeter incorrect Returns a custom Exception

        [Test]
        public void GivenStateCensusDataFileDelemeterIncorrect_WhenSAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer analyser = new StateCensusAnalyzer();
            try
            {
                int records = analyser.ReadStateCensusData(stateCensusFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delemeter");

            }
        }

        //TC1.5 - Given the State Census CSV File when correct but csv header incorrect Returns a custom Exception

        [Test]
        public void GivenStateCensusDataFileHeaderIncorrect_WhenSAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer analyser = new StateCensusAnalyzer();
            try
            {
                bool records = analyser.ReadStateCensusData(stateCensusFilePath, "State/Population,AreaInSqKm,DensityPerSqKm");
                Assert.IsTrue(records);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");

            }
        }

        // TC2.1 - Given the State Code CSV file, Check to ensure the Number of Record matches

        [Test]
        public void GivenStateCodeData_ShouldReturnNoOfRecordsMatches()
        {
            StateCodeAnalyzer analyser = new StateCodeAnalyzer();
            CSVStateCensus stateCode = new CSVStateCensus();
            Assert.AreEqual(stateCode.ReadStateCodeData(stateCodeFilePath), analyser.ReadStateCodeData(stateCodeFilePath));
        }
        //TC2.2 - Given the State Code CSV File if incorrect Returns a custom Exception

        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenSAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer analyser = new StateCodeAnalyzer();
            try
            {
                int records = analyser.ReadStateCodeData(stateCodeFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Path");

            }
        }
        //TC2.3 - Given the State Code CSV File when correct but type incorrect Returns a custom Exception

        [Test]
        public void GivenStateCodeDataFileTypeIncorrect_WhenSAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer analyser = new StateCodeAnalyzer();
            try
            {
                int records = analyser.ReadStateCodeData(stateCodeFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Path");

            }
        }

        //TC2.4 - Given the State Code CSV File when correct but delemeter incorrect Returns a custom Exception


        [Test]
        public void GivenStateCodeDataFileDelemeterIncorrect_WhenSAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer analyser = new StateCodeAnalyzer();
            try
            {
                int records = analyser.ReadStateCodeData(stateCodeFilePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delemeter");

            }
        }

        //TC2.5 - Given the State Code CSV File when correct but csv header incorrect Returns a custom Exception

        [Test]
        public void GivenStateCodeDataFileHeaderIncorrect_WhenSAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer analyser = new StateCodeAnalyzer();
            try
            {
                bool records = analyser.ReadStateCodeData(stateCodeFilePath, "serialNumber/stateName,tin,stateCode");
                Assert.IsTrue(records);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");

            }
        }
    }
}