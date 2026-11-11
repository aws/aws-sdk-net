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
    /// Container for the parameters to the RenewDomain operation. This operation renews a
    /// domain for the specified number of years. The cost of renewing your domain is billed
    /// to your Amazon Web Services account. <para> We recommend that you renew your domain
    /// several weeks before the expiration date. Some TLD registries delete domains before
    /// the expiration date if you haven't renewed far enough in advance. For more information
    /// about renewing domain registration, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-renew.html">Renewing
    /// Registration for a Domain</a> in the <i>Amazon Route 53 Developer Guide</i>. </para>
    /// </summary>
    public partial class RenewDomainRequest : AmazonRoute53DomainsRequest
    {
        /// <summary>
        /// Gets and sets the property Consent. 
        /// <para>
        /// Specifies the maximum price that you agree to pay to renew the domain name. This element
        /// is required if the domain has registry premium pricing, and optional if the domain
        /// is priced at the standard rate for its TLD. If you include it and the renewal price
        /// is more than <c>MaxPrice</c>, the request fails.
        /// </para>
        /// </summary>
        public Consent Consent { get; set; }

        /// <summary>
        /// Checks to see if the Consent property is set.
        /// </summary>
        internal bool IsSetConsent() => this.Consent != null;

        /// <summary>
        /// Gets and sets the property CurrentExpiryYear. 
        /// <para>
        /// The year when the registration for the domain is set to expire. This value must match
        /// the current expiration date for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? CurrentExpiryYear { get; set; }

        /// <summary>
        /// Checks to see if the CurrentExpiryYear property is set.
        /// </summary>
        internal bool IsSetCurrentExpiryYear() => this.CurrentExpiryYear.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to renew.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DurationInYears. 
        /// <para>
        /// The number of years that you want to renew the domain for. The maximum number of years
        /// depends on the top-level domain. For the range of valid values for your domain, see
        /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// that You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? DurationInYears { get; set; }

        /// <summary>
        /// Checks to see if the DurationInYears property is set.
        /// </summary>
        internal bool IsSetDurationInYears() => this.DurationInYears.HasValue;
    }
}
