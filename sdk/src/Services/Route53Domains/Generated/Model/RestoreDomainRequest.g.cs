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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreDomain operation. Restores a domain that
    /// has expired, or was deleted, before it becomes available for others to register. The
    /// cost of restoring your domain is billed to your Amazon Web Services account. <para>
    /// Not every TLD registry supports restoring domains, and the period during which a domain
    /// can be restored varies by TLD. To find out whether your domain can be restored and
    /// the period during which you can restore it, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
    /// that you can register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
    /// Guide</i>. </para> <important> <para> Restoring a domain typically costs more, and
    /// sometimes much more, than registering or renewing a domain. To get the restoration
    /// price for a domain before you restore it, use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetDomainPrices.html">GetDomainPrices</a>.
    /// </para> </important> <para> Restoration is asynchronous. The response includes an
    /// operation ID that you can use with <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
    /// to track the progress of the request. When the restoration succeeds, the domain reappears
    /// in the response to <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListDomains.html">ListDomains</a>.
    /// </para> <para> For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-restore-expired.html">Restoring
    /// an expired or deleted domain</a> in the <i>Amazon Route 53 Developer Guide</i>. </para>
    /// </summary>
    public partial class RestoreDomainRequest : AmazonRoute53DomainsRequest
    {
        /// <summary>
        /// Gets and sets the property Consent. 
        /// <para>
        /// Specifies the maximum price that you agree to pay to restore the domain name. This
        /// element is required if the domain has registry premium pricing, and optional if the
        /// domain is priced at the standard rate for its TLD. If you include it and the restoration
        /// price is more than <c>MaxPrice</c>, the request fails.
        /// </para>
        /// </summary>
        public Consent Consent { get; set; }

        /// <summary>
        /// Checks to see if the Consent property is set.
        /// </summary>
        internal bool IsSetConsent() => this.Consent != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to restore. The domain must have been registered
        /// to the Amazon Web Services account that submits the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;
    }
}
