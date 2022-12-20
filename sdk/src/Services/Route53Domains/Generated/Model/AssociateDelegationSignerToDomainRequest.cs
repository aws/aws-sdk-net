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
    /// Container for the parameters to the AssociateDelegationSignerToDomain operation.
    /// Creates a delegation signer (DS) record in the registry zone for this domain name.
    /// 
    ///  
    /// <para>
    /// Note that creating DS record at the registry impacts DNSSEC validation of your DNS
    /// records. This action may render your domain name unavailable on the internet if the
    /// steps are completed in the wrong order, or with incorrect timing. For more information
    /// about DNSSEC signing, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-configuring-dnssec.html">Configuring
    /// DNSSEC signing</a> in the <i>Route 53 developer guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateDelegationSignerToDomainRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private DnssecSigningAttributes _signingAttributes;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// Gets and sets the property SigningAttributes. 
        /// <para>
        /// The information about a key, including the algorithm, public key-value, and flags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DnssecSigningAttributes SigningAttributes
        {
            get { return this._signingAttributes; }
            set { this._signingAttributes = value; }
        }

        // Check to see if SigningAttributes property is set
        internal bool IsSetSigningAttributes()
        {
            return this._signingAttributes != null;
        }

    }
}