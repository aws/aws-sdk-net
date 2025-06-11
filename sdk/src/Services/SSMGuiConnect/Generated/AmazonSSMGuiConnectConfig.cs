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
 * Do not modify this file. This file is generated from the ssm-guiconnect-2021-05-01.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.SSMGuiConnect.Internal;

namespace Amazon.SSMGuiConnect
{
    /// <summary>
    /// Configuration for accessing Amazon SSMGuiConnect service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonSSMGuiConnectConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("SSM GuiConnect", "3.7.400.23");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "SSM GuiConnect";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonSSMGuiConnectConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonSSMGuiConnectDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "SSM GuiConnect";
            this.AuthenticationServiceName = "ssm-guiconnect";
            this.EndpointProvider = new AmazonSSMGuiConnectEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "ssm-guiconnect";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2021-05-01";
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