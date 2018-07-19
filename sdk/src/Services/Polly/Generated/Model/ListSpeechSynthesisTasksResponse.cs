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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Polly.Model
{
    /// <summary>
    /// This is the response object from the ListSpeechSynthesisTasks operation.
    /// </summary>
    public partial class ListSpeechSynthesisTasksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SynthesisTask> _synthesisTasks = new List<SynthesisTask>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token returned from the previous List operation in this request.
        /// If present, this indicates where to continue the listing.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SynthesisTasks. 
        /// <para>
        /// SynthesisTask object that provides information from the specified task in the list
        /// request, including output format, creation time, task status, and so on.
        /// </para>
        /// </summary>
        public List<SynthesisTask> SynthesisTasks
        {
            get { return this._synthesisTasks; }
            set { this._synthesisTasks = value; }
        }

        // Check to see if SynthesisTasks property is set
        internal bool IsSetSynthesisTasks()
        {
            return this._synthesisTasks != null && this._synthesisTasks.Count > 0; 
        }

    }
}