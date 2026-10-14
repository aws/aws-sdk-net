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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the SubmitFeedback operation. Enables you to provide
    /// feedback to Amazon Kendra to improve the performance of your index. <para> <c>SubmitFeedback</c>
    /// is currently not supported in the Amazon Web Services GovCloud (US-West) region. </para>
    /// </summary>
    public partial class SubmitFeedbackRequest : AmazonKendraRequest
    {
        /// <summary>
        /// Gets and sets the property ClickFeedbackItems. 
        /// <para>
        /// Tells Amazon Kendra that a particular search result link was chosen by the user. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClickFeedback> ClickFeedbackItems { get; set; } = AWSConfigs.InitializeCollections ? new List<ClickFeedback>() : null;

        /// <summary>
        /// Checks to see if the ClickFeedbackItems property is set.
        /// </summary>
        internal bool IsSetClickFeedbackItems() => this.ClickFeedbackItems != null && (this.ClickFeedbackItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index that was queried.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The identifier of the specific query for which you are submitting feedback. The query
        /// ID is returned in the response to the <c>Query</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property RelevanceFeedbackItems. 
        /// <para>
        /// Provides Amazon Kendra with relevant or not relevant feedback for whether a particular
        /// item was relevant to the search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelevanceFeedback> RelevanceFeedbackItems { get; set; } = AWSConfigs.InitializeCollections ? new List<RelevanceFeedback>() : null;

        /// <summary>
        /// Checks to see if the RelevanceFeedbackItems property is set.
        /// </summary>
        internal bool IsSetRelevanceFeedbackItems() => this.RelevanceFeedbackItems != null && (this.RelevanceFeedbackItems.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
