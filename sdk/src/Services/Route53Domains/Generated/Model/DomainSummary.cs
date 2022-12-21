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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Summary information about one domain.
    /// </summary>
    public partial class DomainSummary
    {
        private bool? _autoRenew;
        private string _domainName;
        private DateTime? _expiry;
        private bool? _transferLock;

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Indicates whether the domain is automatically renewed upon expiration.
        /// </para>
        /// </summary>
        public bool AutoRenew
        {
            get { return this._autoRenew.GetValueOrDefault(); }
            set { this._autoRenew = value; }
        }

        // Check to see if AutoRenew property is set
        internal bool IsSetAutoRenew()
        {
            return this._autoRenew.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that the summary information applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Expiry. 
        /// <para>
        /// Expiration date of the domain in Unix time format and Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime Expiry
        {
            get { return this._expiry.GetValueOrDefault(); }
            set { this._expiry = value; }
        }

        // Check to see if Expiry property is set
        internal bool IsSetExpiry()
        {
            return this._expiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferLock. 
        /// <para>
        /// Indicates whether a domain is locked from unauthorized transfer to another party.
        /// </para>
        /// </summary>
        public bool TransferLock
        {
            get { return this._transferLock.GetValueOrDefault(); }
            set { this._transferLock = value; }
        }

        // Check to see if TransferLock property is set
        internal bool IsSetTransferLock()
        {
            return this._transferLock.HasValue; 
        }

    }
}