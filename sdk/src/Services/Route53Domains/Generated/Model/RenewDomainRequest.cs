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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the RenewDomain operation.
    /// This operation renews a domain for the specified number of years. The cost of renewing
    /// your domain is billed to your Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// We recommend that you renew your domain several weeks before the expiration date.
    /// Some TLD registries delete domains before the expiration date if you haven't renewed
    /// far enough in advance. For more information about renewing domain registration, see
    /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-renew.html">Renewing
    /// Registration for a Domain</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RenewDomainRequest : AmazonRoute53DomainsRequest
    {
        private int? _currentExpiryYear;
        private string _domainName;
        private int? _durationInYears;

        /// <summary>
        /// Gets and sets the property CurrentExpiryYear. 
        /// <para>
        /// The year when the registration for the domain is set to expire. This value must match
        /// the current expiration date for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? CurrentExpiryYear
        {
            get { return this._currentExpiryYear; }
            set { this._currentExpiryYear = value; }
        }

        // Check to see if CurrentExpiryYear property is set
        internal bool IsSetCurrentExpiryYear()
        {
            return this._currentExpiryYear.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to renew.
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
        [AWSProperty(Min=1, Max=10)]
        public int? DurationInYears
        {
            get { return this._durationInYears; }
            set { this._durationInYears = value; }
        }

        // Check to see if DurationInYears property is set
        internal bool IsSetDurationInYears()
        {
            return this._durationInYears.HasValue; 
        }

    }
}