namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_database_deleteresult.htm#apex_methods_system_database_deleteresult
    /// </summary>
    public class DeleteResult
    {
        // infrastructure
        public DeleteResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeleteResult));
            }
        }

        // API
        public Error[] getErrors()
        {
            return Self.getErrors();
        }

        public ID getId()
        {
            return Self.getId();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }

        List<Error> errors
        {
            get
            {
                return Self.errors;
            }
            set
            {
                Self.errors = value;
            }
        }

        ID id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        bool success
        {
            get
            {
                return Self.success;
            }
            set
            {
                Self.success = value;
            }
        }
    }
}
