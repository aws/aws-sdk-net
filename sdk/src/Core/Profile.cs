using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Amazon
{
    /// <summary>
    /// Represents a profile in the configuration file. For example in ~/.aws/config
    /// [profile foo]
    /// name = value
    /// Profile profile = new Profile("foo");
    /// When this is set on the ClientConfig and that config is passed to 
    /// the service client constructor the sdk will try to find the credentials associated with the Profile.Name property
    /// If set, this will override AWS_PROFILE and AWSConfigs.ProfileName.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// This represents a profile in the configuration file with the given name
        /// </summary>
        /// <param name="name"></param>
        public Profile(string name)
        {
            Name = name;
        }
        /// <summary>
        /// This represents a profile in the configuration file with the given name
        /// in the given location
        /// </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        public Profile(string name, string location)
        {
            Name = name;
            Location = location;
        }
        private string location;
        /// <summary>
        /// The name of the profile you want to use
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Specifies the location of the profile you want to use. This is optional. If none is set then
        /// it will look in the default location
        /// </summary>
        public string Location 
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Profile Name: {this.Name}");
            sb.AppendLine($"Location: {this.Location}");
            return sb.ToString();
        }
    }
}
