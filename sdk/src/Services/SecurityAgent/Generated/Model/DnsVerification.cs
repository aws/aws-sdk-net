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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents dns txt verification details
    /// </summary>
    public partial class DnsVerification
    {
        private string _dnsRecordName;
        private DNSRecordType _dnsRecordType;
        private string _token;

        /// <summary>
        /// Gets and sets the property DnsRecordName. 
        /// <para>
        /// Record name to be added in DNS for target domain
        /// </para>
        /// </summary>
        public string DnsRecordName
        {
            get { return this._dnsRecordName; }
            set { this._dnsRecordName = value; }
        }

        // Check to see if DnsRecordName property is set
        internal bool IsSetDnsRecordName()
        {
            return this._dnsRecordName != null;
        }

        /// <summary>
        /// Gets and sets the property DnsRecordType. 
        /// <para>
        /// Type of record to be added in DNS for target domain
        /// </para>
        /// </summary>
        public DNSRecordType DnsRecordType
        {
            get { return this._dnsRecordType; }
            set { this._dnsRecordType = value; }
        }

        // Check to see if DnsRecordType property is set
        internal bool IsSetDnsRecordType()
        {
            return this._dnsRecordType != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// Token used to verify domain ownership
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

    }
}