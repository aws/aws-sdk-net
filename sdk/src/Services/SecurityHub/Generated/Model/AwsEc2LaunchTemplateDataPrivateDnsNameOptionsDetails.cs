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
    /// Describes the options for Amazon EC2 instance hostnames.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetails
    {
        private bool? _enableResourceNameDnsAAAARecord;
        private bool? _enableResourceNameDnsARecord;
        private string _hostnameType;

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsAAAARecord. 
        /// <para>
        ///  Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA
        /// records. 
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
        ///  Indicates whether to respond to DNS queries for instance hostnames with DNS A records.
        /// 
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
        /// Gets and sets the property HostnameType. 
        /// <para>
        ///  The type of hostname for EC2 instances. 
        /// </para>
        /// </summary>
        public string HostnameType
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