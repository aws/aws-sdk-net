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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the ListInferenceEvents operation.
    /// </summary>
    public partial class ListInferenceEventsResponse : AmazonWebServiceResponse
    {
        private List<InferenceEventSummary> _inferenceEventSummaries = AWSConfigs.InitializeCollections ? new List<InferenceEventSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InferenceEventSummaries. 
        /// <para>
        /// Provides an array of information about the individual inference events returned from
        /// the <c>ListInferenceEvents</c> operation, including scheduler used, event start time,
        /// event end time, diagnostics, and so on. 
        /// </para>
        /// </summary>
        public List<InferenceEventSummary> InferenceEventSummaries
        {
            get { return this._inferenceEventSummaries; }
            set { this._inferenceEventSummaries = value; }
        }

        // Check to see if InferenceEventSummaries property is set
        internal bool IsSetInferenceEventSummaries()
        {
            return this._inferenceEventSummaries != null && (this._inferenceEventSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token indicating where to continue the listing of inference executions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}