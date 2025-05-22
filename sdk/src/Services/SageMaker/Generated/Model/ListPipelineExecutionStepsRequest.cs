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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListPipelineExecutionSteps operation.
    /// Gets a list of <c>PipeLineExecutionStep</c> objects.
    /// </summary>
    public partial class ListPipelineExecutionStepsRequest : AmazonSageMakerRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _pipelineExecutionArn;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of pipeline execution steps to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous <c>ListPipelineExecutionSteps</c> request was truncated,
        /// the response includes a <c>NextToken</c>. To retrieve the next set of pipeline execution
        /// steps, use the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property PipelineExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PipelineExecutionArn
        {
            get { return this._pipelineExecutionArn; }
            set { this._pipelineExecutionArn = value; }
        }

        // Check to see if PipelineExecutionArn property is set
        internal bool IsSetPipelineExecutionArn()
        {
            return this._pipelineExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The field by which to sort results. The default is <c>CreatedTime</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}