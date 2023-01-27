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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KendraRanking.Model
{
    /// <summary>
    /// This is the response object from the Rescore operation.
    /// </summary>
    public partial class RescoreResponse : AmazonWebServiceResponse
    {
        private string _rescoreId;
        private List<RescoreResultItem> _resultItems = new List<RescoreResultItem>();

        /// <summary>
        /// Gets and sets the property RescoreId. 
        /// <para>
        /// The identifier associated with the scores that Amazon Kendra Intelligent Ranking gives
        /// to the results. Amazon Kendra Intelligent Ranking rescores or re-ranks the results
        /// for the search service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string RescoreId
        {
            get { return this._rescoreId; }
            set { this._rescoreId = value; }
        }

        // Check to see if RescoreId property is set
        internal bool IsSetRescoreId()
        {
            return this._rescoreId != null;
        }

        /// <summary>
        /// Gets and sets the property ResultItems. 
        /// <para>
        /// A list of result items for documents with new relevancy scores. The results are in
        /// descending order.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<RescoreResultItem> ResultItems
        {
            get { return this._resultItems; }
            set { this._resultItems = value; }
        }

        // Check to see if ResultItems property is set
        internal bool IsSetResultItems()
        {
            return this._resultItems != null && this._resultItems.Count > 0; 
        }

    }
}