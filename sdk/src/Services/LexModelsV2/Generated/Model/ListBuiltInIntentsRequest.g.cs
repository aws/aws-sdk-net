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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListBuiltInIntents operation. Gets a list of built-in
    /// intents provided by Amazon Lex that you can use in your bot. <para> To use a built-in
    /// intent as a the base for your own intent, include the built-in intent signature in
    /// the <c>parentIntentSignature</c> parameter when you call the <c>CreateIntent</c> operation.
    /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_CreateIntent.html">CreateIntent</a>.
    /// </para>
    /// </summary>
    public partial class ListBuiltInIntentsRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale of the intents to list. The string must
        /// match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of built-in intents to return in each page of results. If there
        /// are fewer results than the max page size, only the actual number of results are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response from the <c>ListBuiltInIntents</c> operation contains more results
        /// than specified in the <c>maxResults</c> parameter, a token is returned in the response.
        /// Use that token in the <c>nextToken</c> parameter to return the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies sorting parameters for the list of built-in intents. You can specify that
        /// the list be sorted by the built-in intent signature in either ascending or descending
        /// order.
        /// </para>
        /// </summary>
        public BuiltInIntentSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;
    }
}
