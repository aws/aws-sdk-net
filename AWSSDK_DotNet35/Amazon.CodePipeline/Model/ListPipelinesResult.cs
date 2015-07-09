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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the output of a list pipelines action.
    /// </summary>
    public partial class ListPipelinesResult : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PipelineSummary> _pipelines = new List<PipelineSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the amount of returned information is significantly large, an identifier is also
        /// returned which can be used in a subsequent list pipelines call to return the next
        /// set of pipelines in the list.
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
        /// Gets and sets the property Pipelines. 
        /// <para>
        /// The list of pipelines.
        /// </para>
        /// </summary>
        public List<PipelineSummary> Pipelines
        {
            get { return this._pipelines; }
            set { this._pipelines = value; }
        }

        // Check to see if Pipelines property is set
        internal bool IsSetPipelines()
        {
            return this._pipelines != null && this._pipelines.Count > 0; 
        }

    }
}