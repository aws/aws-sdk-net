/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the EnableDomainAutoRenew operation.
    /// This operation configures Amazon Route 53 to automatically renew the specified domain
    /// before the domain registration expires. The cost of renewing your domain registration
    /// is billed to your AWS account.
    /// 
    ///  
    /// <para>
    /// The period during which you can renew a domain name varies by TLD. For a list of TLDs
    /// and their renewal policies, see <a href="http://wiki.gandi.net/en/domains/renew#renewal_restoration_and_deletion_times">"Renewal,
    /// restoration, and deletion times"</a> on the website for our registrar associate, Gandi.
    /// Amazon Route 53 requires that you renew before the end of the renewal period that
    /// is listed on the Gandi website so we can complete processing before the deadline.
    /// </para>
    /// </summary>
    public partial class EnableDomainAutoRenewRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to enable automatic renewal for.
        /// </para>
        /// </summary>
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

    }
}