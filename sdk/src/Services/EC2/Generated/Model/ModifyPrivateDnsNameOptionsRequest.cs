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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyPrivateDnsNameOptions operation.
    /// Modifies the options for instance hostnames for the specified instance.
    /// </summary>
    public partial class ModifyPrivateDnsNameOptionsRequest : AmazonEC2Request
    {
        private bool? _enableResourceNameDnsAAAARecord;
        private bool? _enableResourceNameDnsARecord;
        private string _instanceId;
        private HostnameType _privateDnsHostnameType;

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsAAAARecord. 
        /// <para>
        /// Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.
        /// </para>
        /// </summary>
        public bool EnableResourceNameDnsAAAARecord
        {
            get { return this._enableResourceNameDnsAAAARecord.GetValueOrDefault(); }
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
        public bool EnableResourceNameDnsARecord
        {
            get { return this._enableResourceNameDnsARecord.GetValueOrDefault(); }
            set { this._enableResourceNameDnsARecord = value; }
        }

        // Check to see if EnableResourceNameDnsARecord property is set
        internal bool IsSetEnableResourceNameDnsARecord()
        {
            return this._enableResourceNameDnsARecord.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsHostnameType. 
        /// <para>
        /// The type of hostname for EC2 instances. For IPv4 only subnets, an instance DNS name
        /// must be based on the instance IPv4 address. For IPv6 only subnets, an instance DNS
        /// name must be based on the instance ID. For dual-stack subnets, you can specify whether
        /// DNS names use the instance IPv4 address or the instance ID.
        /// </para>
        /// </summary>
        public HostnameType PrivateDnsHostnameType
        {
            get { return this._privateDnsHostnameType; }
            set { this._privateDnsHostnameType = value; }
        }

        // Check to see if PrivateDnsHostnameType property is set
        internal bool IsSetPrivateDnsHostnameType()
        {
            return this._privateDnsHostnameType != null;
        }

    }
}