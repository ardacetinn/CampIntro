using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args) 
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();
            ICreditManager tradesmanCreditManager = new TradesmanCreditManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, smsLoggerService };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(tradesmanCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager> { personalFinanceCreditManager, vehicleCreditManager };

            //applicationManager.MakeCreditInformation(credits);

        }
    }
}