/*
* Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
* 
* Licensed under the Apache License, Version 2.0 (the "License").
* You may not use this file except in compliance with the License.
* A copy of the License is located at
* 
*  http://aws.amazon.com/apache2.0
* 
* or in the "license" file accompanying this file. This file is distributed
* on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
* express or implied. See the License for the specific language governing
* permissions and limitations under the License.
*/

using Amazon.Runtime;
using System.Text;

namespace Amazon
{
    /// <summary>
    /// Represents a profile in the configuration file. For example in ~/.aws/config:
    /// <code>
    /// [profile foo]
    /// name = value
    /// 
    /// Profile profile = new Profile("foo");
    /// </code>
    /// 
    /// When this is set on the <see cref="IClientConfig"/> and that config is passed to 
    /// the service client constructor the SDK will try to find the credentials associated with the <see cref="Name"/> property.
    /// 
    /// <para />
    /// 
    /// If set, this will override <c>AWS_PROFILE</c> and <c>AWSConfigs.ProfileName</c>.
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
