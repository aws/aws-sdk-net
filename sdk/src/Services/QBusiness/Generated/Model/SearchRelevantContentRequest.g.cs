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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the SearchRelevantContent operation. Searches for
    /// relevant content in a Amazon Q Business application based on a query. This operation
    /// takes a search query text, the Amazon Q Business application identifier, and optional
    /// filters (such as content source and maximum results) as input. It returns a list of
    /// relevant content items, where each item includes the content text, the unique document
    /// identifier, the document title, the document URI, any relevant document attributes,
    /// and score attributes indicating the confidence level of the relevance.
    /// </summary>
    public partial class SearchRelevantContentRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application to search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AttributeFilter.
        /// </summary>
        public AttributeFilter AttributeFilter { get; set; }

        /// <summary>
        /// Checks to see if the AttributeFilter property is set.
        /// </summary>
        internal bool IsSetAttributeFilter() => this.AttributeFilter != null;

        /// <summary>
        /// Gets and sets the property ContentSource. 
        /// <para>
        /// The source of content to search in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentSource ContentSource { get; set; }

        /// <summary>
        /// Checks to see if the ContentSource property is set.
        /// </summary>
        internal bool IsSetContentSource() => this.ContentSource != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. (You received this token from a previous call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 800)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The text to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueryText { get; set; }

        /// <summary>
        /// Checks to see if the QueryText property is set.
        /// </summary>
        internal bool IsSetQueryText() => this.QueryText != null;
    }
}
