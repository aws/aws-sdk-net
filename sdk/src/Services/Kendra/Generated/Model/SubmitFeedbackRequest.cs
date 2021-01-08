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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the SubmitFeedback operation.
    /// Enables you to provide feedback to Amazon Kendra to improve the performance of the
    /// service.
    /// </summary>
    public partial class SubmitFeedbackRequest : AmazonKendraRequest
    {
        private List<ClickFeedback> _clickFeedbackItems = new List<ClickFeedback>();
        private string _indexId;
        private string _queryId;
        private List<RelevanceFeedback> _relevanceFeedbackItems = new List<RelevanceFeedback>();

        /// <summary>
        /// Gets and sets the property ClickFeedbackItems. 
        /// <para>
        /// Tells Amazon Kendra that a particular search result link was chosen by the user. 
        /// </para>
        /// </summary>
        public List<ClickFeedback> ClickFeedbackItems
        {
            get { return this._clickFeedbackItems; }
            set { this._clickFeedbackItems = value; }
        }

        // Check to see if ClickFeedbackItems property is set
        internal bool IsSetClickFeedbackItems()
        {
            return this._clickFeedbackItems != null && this._clickFeedbackItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index that was queried.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The identifier of the specific query for which you are submitting feedback. The query
        /// ID is returned in the response to the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property RelevanceFeedbackItems. 
        /// <para>
        /// Provides Amazon Kendra with relevant or not relevant feedback for whether a particular
        /// item was relevant to the search.
        /// </para>
        /// </summary>
        public List<RelevanceFeedback> RelevanceFeedbackItems
        {
            get { return this._relevanceFeedbackItems; }
            set { this._relevanceFeedbackItems = value; }
        }

        // Check to see if RelevanceFeedbackItems property is set
        internal bool IsSetRelevanceFeedbackItems()
        {
            return this._relevanceFeedbackItems != null && this._relevanceFeedbackItems.Count > 0; 
        }

    }
}