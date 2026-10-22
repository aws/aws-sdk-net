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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the ListOrganizationInsights operation.
    /// </summary>
    public partial class ListOrganizationInsightsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProactiveInsights. 
        /// <para>
        /// An integer that specifies the number of open proactive insights in your Amazon Web
        /// Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProactiveOrganizationInsightSummary> ProactiveInsights { get; set; } = AWSConfigs.InitializeCollections ? new List<ProactiveOrganizationInsightSummary>() : null;

        /// <summary>
        /// Checks to see if the ProactiveInsights property is set.
        /// </summary>
        internal bool IsSetProactiveInsights() => this.ProactiveInsights != null && (this.ProactiveInsights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReactiveInsights. 
        /// <para>
        /// An integer that specifies the number of open reactive insights in your Amazon Web
        /// Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReactiveOrganizationInsightSummary> ReactiveInsights { get; set; } = AWSConfigs.InitializeCollections ? new List<ReactiveOrganizationInsightSummary>() : null;

        /// <summary>
        /// Checks to see if the ReactiveInsights property is set.
        /// </summary>
        internal bool IsSetReactiveInsights() => this.ReactiveInsights != null && (this.ReactiveInsights.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
