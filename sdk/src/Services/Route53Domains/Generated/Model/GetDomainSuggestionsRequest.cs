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
    /// Container for the parameters to the GetDomainSuggestions operation.
    /// The GetDomainSuggestions operation returns a list of suggested domain names given
    /// a string, which can either be a domain name or simply a word or phrase (without spaces).
    /// </summary>
    public partial class GetDomainSuggestionsRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private bool? _onlyAvailable;
        private int? _suggestionCount;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A domain name that you want to use as the basis for a list of possible domain names.
        /// The domain name must contain a top-level domain (TLD), such as .com, that Amazon Route
        /// 53 supports. For a list of TLDs, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// that You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
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

        /// <summary>
        /// Gets and sets the property OnlyAvailable. 
        /// <para>
        /// If <code>OnlyAvailable</code> is <code>true</code>, Amazon Route 53 returns only domain
        /// names that are available. If <code>OnlyAvailable</code> is <code>false</code>, Amazon
        /// Route 53 returns domain names without checking whether they're available to be registered.
        /// To determine whether the domain is available, you can call <code>checkDomainAvailability</code>
        /// for each suggestion.
        /// </para>
        /// </summary>
        public bool OnlyAvailable
        {
            get { return this._onlyAvailable.GetValueOrDefault(); }
            set { this._onlyAvailable = value; }
        }

        // Check to see if OnlyAvailable property is set
        internal bool IsSetOnlyAvailable()
        {
            return this._onlyAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuggestionCount. 
        /// <para>
        /// The number of suggested domain names that you want Amazon Route 53 to return.
        /// </para>
        /// </summary>
        public int SuggestionCount
        {
            get { return this._suggestionCount.GetValueOrDefault(); }
            set { this._suggestionCount = value; }
        }

        // Check to see if SuggestionCount property is set
        internal bool IsSetSuggestionCount()
        {
            return this._suggestionCount.HasValue; 
        }

    }
}