using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingExamples
{
    class NotValidCountryNameException:Exception
    {
        public NotValidCountryNameException()
        {

        }
        public NotValidCountryNameException(string errorMsg):base(errorMsg)
        {

        }
    }
}
