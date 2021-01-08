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
    /// A range of IPv4 addresses.
    /// </summary>
    public partial class AwsEc2SecurityGroupIpRange
    {
        private string _cidrIp;

        /// <summary>
        /// Gets and sets the property CidrIp. 
        /// <para>
        /// The IPv4 CIDR range. You can specify either a CIDR range or a source security group,
        /// but not both. To specify a single IPv4 address, use the /32 prefix length.
        /// </para>
        /// </summary>
        public string CidrIp
        {
            get { return this._cidrIp; }
            set { this._cidrIp = value; }
        }

        // Check to see if CidrIp property is set
        internal bool IsSetCidrIp()
        {
            return this._cidrIp != null;
        }

    }
}