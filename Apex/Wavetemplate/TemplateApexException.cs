namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TemplateApexException : Exception
    {
        // infrastructure
        public TemplateApexException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TemplateApexException));
            }
        }

        // API
        public TemplateApexException()
        {
            Self = Implementation.Constructor();
        }

        public TemplateApexException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public TemplateApexException(string msg)
        {
            Self = Implementation.Constructor(msg);
        }

        public TemplateApexException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
