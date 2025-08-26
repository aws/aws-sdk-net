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

/*
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.CodeGuruSecurity.Internal;

namespace Amazon.CodeGuruSecurity
{
    /// <summary>
    /// Configuration for accessing Amazon CodeGuruSecurity service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonCodeGuruSecurityConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("CodeGuru Security", "3.7.500.11");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "CodeGuru Security";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonCodeGuruSecurityConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonCodeGuruSecurityDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "CodeGuru Security";
            this.AuthenticationServiceName = "codeguru-security";
            this.EndpointProvider = new AmazonCodeGuruSecurityEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "codeguru-security";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2018-05-10";
            }
        }

        /// <summary>
        /// Gets the value of UserAgent property.
        /// </summary>
        public override string UserAgent
        {
            get
            {
                return _userAgent;
            }
        }

    }
}