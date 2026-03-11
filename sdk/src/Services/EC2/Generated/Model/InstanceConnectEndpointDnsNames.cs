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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The DNS names of the endpoint.
    /// </summary>
    public partial class InstanceConnectEndpointDnsNames
    {
        private string _dnsName;
        private string _fipsDnsName;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property FipsDnsName. 
        /// <para>
        /// The Federal Information Processing Standards (FIPS) compliant DNS name of the EC2
        /// Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string FipsDnsName
        {
            get { return this._fipsDnsName; }
            set { this._fipsDnsName = value; }
        }

        // Check to see if FipsDnsName property is set
        internal bool IsSetFipsDnsName()
        {
            return this._fipsDnsName != null;
        }

    }
}