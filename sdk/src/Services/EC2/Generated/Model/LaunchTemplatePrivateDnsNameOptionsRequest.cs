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
    /// Describes the options for instance hostnames.
    /// </summary>
    public partial class LaunchTemplatePrivateDnsNameOptionsRequest
    {
        private bool? _enableResourceNameDnsAAAARecord;
        private bool? _enableResourceNameDnsARecord;
        private HostnameType _hostnameType;

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsAAAARecord. 
        /// <para>
        /// Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.
        /// </para>
        /// </summary>
        public bool? EnableResourceNameDnsAAAARecord
        {
            get { return this._enableResourceNameDnsAAAARecord; }
            set { this._enableResourceNameDnsAAAARecord = value; }
        }

        // Check to see if EnableResourceNameDnsAAAARecord property is set
        internal bool IsSetEnableResourceNameDnsAAAARecord()
        {
            return this._enableResourceNameDnsAAAARecord.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsARecord. 
        /// <para>
        /// Indicates whether to respond to DNS queries for instance hostnames with DNS A records.
        /// </para>
        /// </summary>
        public bool? EnableResourceNameDnsARecord
        {
            get { return this._enableResourceNameDnsARecord; }
            set { this._enableResourceNameDnsARecord = value; }
        }

        // Check to see if EnableResourceNameDnsARecord property is set
        internal bool IsSetEnableResourceNameDnsARecord()
        {
            return this._enableResourceNameDnsARecord.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostnameType. 
        /// <para>
        /// The type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance
        /// DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance
        /// DNS name must be based on the instance ID. For dual-stack subnets, you can specify
        /// whether DNS names use the instance IPv4 address or the instance ID.
        /// </para>
        /// </summary>
        public HostnameType HostnameType
        {
            get { return this._hostnameType; }
            set { this._hostnameType = value; }
        }

        // Check to see if HostnameType property is set
        internal bool IsSetHostnameType()
        {
            return this._hostnameType != null;
        }

    }
}