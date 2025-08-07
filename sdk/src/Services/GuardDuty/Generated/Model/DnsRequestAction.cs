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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the DNS_REQUEST action described in this finding.
    /// </summary>
    public partial class DnsRequestAction
    {
        private bool? _blocked;
        private string _domain;
        private string _domainWithSuffix;
        private string _protocol;
        private string _vpcOwnerAccountId;

        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether the targeted port is blocked.
        /// </para>
        /// </summary>
        public bool? Blocked
        {
            get { return this._blocked; }
            set { this._blocked = value; }
        }

        // Check to see if Blocked property is set
        internal bool IsSetBlocked()
        {
            return this._blocked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain information for the DNS query.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainWithSuffix. 
        /// <para>
        /// The second and top level domain involved in the activity that potentially prompted
        /// GuardDuty to generate this finding. For a list of top-level and second-level domains,
        /// see <a href="https://publicsuffix.org/">public suffix list</a>.
        /// </para>
        /// </summary>
        public string DomainWithSuffix
        {
            get { return this._domainWithSuffix; }
            set { this._domainWithSuffix = value; }
        }

        // Check to see if DomainWithSuffix property is set
        internal bool IsSetDomainWithSuffix()
        {
            return this._domainWithSuffix != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network connection protocol observed in the activity that prompted GuardDuty to
        /// generate the finding.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property VpcOwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the VPC through which the DNS request
        /// was made.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string VpcOwnerAccountId
        {
            get { return this._vpcOwnerAccountId; }
            set { this._vpcOwnerAccountId = value; }
        }

        // Check to see if VpcOwnerAccountId property is set
        internal bool IsSetVpcOwnerAccountId()
        {
            return this._vpcOwnerAccountId != null;
        }

    }
}