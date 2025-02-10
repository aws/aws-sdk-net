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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the ListExecutions operation.
    /// Lists all in-progress executions for the specified workflow.
    /// 
    ///  <note> 
    /// <para>
    /// If the specified workflow ID cannot be found, <c>ListExecutions</c> returns a <c>ResourceNotFound</c>
    /// exception.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListExecutionsRequest : AmazonTransferRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _workflowId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        ///  <c>ListExecutions</c> returns the <c>NextToken</c> parameter in the output. You can
        /// then pass the <c>NextToken</c> parameter in a subsequent command to continue listing
        /// additional executions.
        /// </para>
        ///  
        /// <para>
        ///  This is useful for pagination, for instance. If you have 100 executions for a workflow,
        /// you might only want to list first 10. If so, call the API by specifying the <c>max-results</c>:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>aws transfer list-executions --max-results 10</c> 
        /// </para>
        ///  
        /// <para>
        ///  This returns details for the first 10 executions, as well as the pointer (<c>NextToken</c>)
        /// to the eleventh execution. You can now call the API again, supplying the <c>NextToken</c>
        /// value you received: 
        /// </para>
        ///  
        /// <para>
        ///  <c>aws transfer list-executions --max-results 10 --next-token $somePointerReturnedFromPreviousListResult</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This call returns the next 10 executions, the 11th through the 20th. You can then
        /// repeat the call until the details for all 100 executions have been returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
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
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// A unique identifier for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

    }
}