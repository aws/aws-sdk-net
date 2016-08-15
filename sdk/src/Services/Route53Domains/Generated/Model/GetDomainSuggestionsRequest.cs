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
    /// 
    ///  
    /// <para>
    ///  Parameters: <ul><li>DomainName (string): The basis for your domain suggestion search,
    /// a string with (or without) top-level domain specified.</li> <li>SuggestionCount (int):
    /// The number of domain suggestions to be returned, maximum 50, minimum 1.</li> <li>OnlyAvailable
    /// (bool): If true, availability check will be performed on suggestion results, and only
    /// available domains will be returned. If false, suggestions will be returned without
    /// checking whether the domain is actually available, and caller will have to call checkDomainAvailability
    /// for each suggestion to determine availability for registration.</li> </ul> 
    /// </para>
    /// </summary>
    public partial class GetDomainSuggestionsRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private bool? _onlyAvailable;
        private int? _suggestionCount;

        /// <summary>
        /// Gets and sets the property DomainName.
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