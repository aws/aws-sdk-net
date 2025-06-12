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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the Retrieve operation.
    /// </summary>
    public partial class RetrieveResponse : AmazonWebServiceResponse
    {
        private string _queryId;
        private List<RetrieveResultItem> _resultItems = AWSConfigs.InitializeCollections ? new List<RetrieveResultItem>() : null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The identifier of query used for the search. You also use <c>QueryId</c> to identify
        /// the search when using the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_SubmitFeedback.html">Submitfeedback</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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
        /// Gets and sets the property ResultItems. 
        /// <para>
        /// The results of the retrieved relevant passages for the search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RetrieveResultItem> ResultItems
        {
            get { return this._resultItems; }
            set { this._resultItems = value; }
        }

        // Check to see if ResultItems property is set
        internal bool IsSetResultItems()
        {
            return this._resultItems != null && (this._resultItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}