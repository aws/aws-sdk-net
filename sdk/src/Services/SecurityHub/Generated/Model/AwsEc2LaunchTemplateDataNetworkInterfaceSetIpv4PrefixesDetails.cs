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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details on one or more IPv4 prefixes for a network interface.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetails
    {
        private string _ipv4Prefix;

        /// <summary>
        /// Gets and sets the property Ipv4Prefix. 
        /// <para>
        ///  The IPv4 prefix. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-prefix-eni.html">Assigning
        /// prefixes to Amazon EC2 network interfaces</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        public string Ipv4Prefix
        {
            get { return this._ipv4Prefix; }
            set { this._ipv4Prefix = value; }
        }

        // Check to see if Ipv4Prefix property is set
        internal bool IsSetIpv4Prefix()
        {
            return this._ipv4Prefix != null;
        }

    }
}