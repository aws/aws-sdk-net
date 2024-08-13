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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// Container for the parameters to the Suggest operation.
    /// Retrieves autocomplete suggestions for a partial query string. You can use suggestions
    /// enable you to display likely matches before users finish typing. In Amazon CloudSearch,
    /// suggestions are based on the contents of a particular text field. When you request
    /// suggestions, Amazon CloudSearch finds all of the documents whose values in the suggester
    /// field start with the specified query string. The beginning of the field must match
    /// the query string to be considered a match. 
    /// 
    ///  
    /// <para>
    /// For more information about configuring suggesters and retrieving suggestions, see
    /// <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html">Getting
    /// Suggestions</a> in the <i>Amazon CloudSearch Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// The endpoint for submitting <c>Suggest</c> requests is domain-specific. You submit
    /// suggest requests to a domain's search endpoint. To get the search endpoint for your
    /// domain, use the Amazon CloudSearch configuration service <c>DescribeDomains</c> action.
    /// A domain's endpoints are also displayed on the domain dashboard in the Amazon CloudSearch
    /// console. 
    /// </para>
    /// </summary>
    public partial class SuggestRequest : AmazonCloudSearchDomainRequest
    {
        private string _query;
        private long? _size;
        private string _suggester;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// Specifies the string for which you want to get suggestions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// Specifies the maximum number of suggestions to return. 
        /// </para>
        /// </summary>
        public long? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Suggester. 
        /// <para>
        /// Specifies the name of the suggester to use to find suggested matches.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Suggester
        {
            get { return this._suggester; }
            set { this._suggester = value; }
        }

        // Check to see if Suggester property is set
        internal bool IsSetSuggester()
        {
            return this._suggester != null;
        }

    }
}