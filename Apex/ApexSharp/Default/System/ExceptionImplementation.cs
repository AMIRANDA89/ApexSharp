﻿using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Exception))]
    public class ExceptionImplementation
    {
        // Self

        public class ExceptionInstance
        {
            public Exception Cause { get; set; }

            public Exception getCause() => Cause;

            public void initCause(Exception cause) => Cause = cause;

            public int LineNumber { get; set; }

            public int getLineNumber() => LineNumber;

            public string Message { get; set; } = "Exception occured.";

            public string getMessage() => Message;

            public void setMessage(string message) => Message = message;

            public string StackTrace { get; set; }

            public string getStackTraceString() => StackTrace;

            public string TypeName => nameof(Exception);

            public string getTypeName() => TypeName;

            public object clone() => new Exception(this);
        }

        // Implementation

        public dynamic Constructor()
        {
            return new ExceptionInstance();
        }

        public dynamic Constructor(string message)
        {
            return new ExceptionInstance { Message = message };
        }

        public dynamic Constructor(Exception cause)
        {
            return new ExceptionInstance { Cause = cause };
        }

        public dynamic Constructor(string message, Exception cause)
        {
            return new ExceptionInstance { Message = message, Cause = cause };
        }
    }
}
