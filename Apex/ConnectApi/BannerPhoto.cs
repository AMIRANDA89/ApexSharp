namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class BannerPhoto
    {
        // infrastructure
        public BannerPhoto(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BannerPhoto));
            }
        }

        // API
        object bannerPhotoUrl
        {
            get
            {
                return Self.bannerPhotoUrl;
            }
            set
            {
                Self.bannerPhotoUrl = value;
            }
        }

        object bannerPhotoVersionId
        {
            get
            {
                return Self.bannerPhotoVersionId;
            }
            set
            {
                Self.bannerPhotoVersionId = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public BannerPhoto()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
