using System;

namespace Course._2_Fundamentals
{
    /// <summary>
    /// In this class we'll test void methods (the commands)
    /// 1 - Create a test for the LastError property (Log_WhenCalled_SetTheLastErrorProperty)
    /// 2 - Create a test for the ArgumentNullException (remember the conditions to throw exception)
    /// 3 - Create a unit test for the method that raise an event - subscribe the event in the unittest to verify the result of  (commonly used in WPF and Xamarin applications)
    /// 4 - Go to FizzBuzz class
    /// </summary>
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;

            // Write the log to a storage

            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}
