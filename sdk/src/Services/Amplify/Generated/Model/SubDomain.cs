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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The subdomain for the domain association.
    /// </summary>
    public partial class SubDomain
    {
        private string _dnsRecord;
        private SubDomainSetting _subDomainSetting;
        private bool? _verified;

        /// <summary>
        /// Gets and sets the property DnsRecord. 
        /// <para>
        ///  The DNS record for the subdomain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string DnsRecord
        {
            get { return this._dnsRecord; }
            set { this._dnsRecord = value; }
        }

        // Check to see if DnsRecord property is set
        internal bool IsSetDnsRecord()
        {
            return this._dnsRecord != null;
        }

        /// <summary>
        /// Gets and sets the property SubDomainSetting. 
        /// <para>
        ///  Describes the settings for the subdomain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubDomainSetting SubDomainSetting
        {
            get { return this._subDomainSetting; }
            set { this._subDomainSetting = value; }
        }

        // Check to see if SubDomainSetting property is set
        internal bool IsSetSubDomainSetting()
        {
            return this._subDomainSetting != null;
        }

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        ///  The verified status of the subdomain 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Verified
        {
            get { return this._verified; }
            set { this._verified = value; }
        }

        // Check to see if Verified property is set
        internal bool IsSetVerified()
        {
            return this._verified.HasValue; 
        }

    }
}