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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// This is the response object from the ListHumanLoops operation.
    /// </summary>
    public partial class ListHumanLoopsResponse : AmazonWebServiceResponse
    {
        private List<HumanLoopSummary> _humanLoopSummaries = new List<HumanLoopSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property HumanLoopSummaries. 
        /// <para>
        /// An array of objects containing information about the human loops.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HumanLoopSummary> HumanLoopSummaries
        {
            get { return this._humanLoopSummaries; }
            set { this._humanLoopSummaries = value; }
        }

        // Check to see if HumanLoopSummaries property is set
        internal bool IsSetHumanLoopSummaries()
        {
            return this._humanLoopSummaries != null && this._humanLoopSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to resume pagination.
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