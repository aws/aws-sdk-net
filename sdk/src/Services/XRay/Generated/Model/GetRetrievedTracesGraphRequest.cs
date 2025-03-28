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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the GetRetrievedTracesGraph operation.
    /// Retrieves a service graph for traces based on the specified <c>RetrievalToken</c>
    /// from the CloudWatch log group generated by Transaction Search. This API does not initiate
    /// a retrieval job. You must first execute <c>StartTraceRetrieval</c> to obtain the required
    /// <c>RetrievalToken</c>. 
    /// 
    ///  
    /// <para>
    /// The trace graph describes services that process incoming requests and any downstream
    /// services they call, which may include Amazon Web Services resources, external APIs,
    /// or databases.
    /// </para>
    ///  
    /// <para>
    /// The response is empty until the <c>RetrievalStatus</c> is <i>COMPLETE</i>. Retry the
    /// request after the status changes from <i>RUNNING</i> or <i>SCHEDULED</i> to <i>COMPLETE</i>
    /// to access the full service graph.
    /// </para>
    ///  
    /// <para>
    ///  When CloudWatch log is the destination, this API can support cross-account observability
    /// and service graph retrieval across linked accounts.
    /// </para>
    ///  
    /// <para>
    /// For retrieving graphs from X-Ray directly as opposed to the Transaction-Search Log
    /// group, see <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetTraceGraph.html">GetTraceGraph</a>.
    /// </para>
    /// </summary>
    public partial class GetRetrievedTracesGraphRequest : AmazonXRayRequest
    {
        private string _nextToken;
        private string _retrievalToken;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Specify the pagination token returned by a previous request to retrieve the next
        /// page of indexes. 
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
        /// Gets and sets the property RetrievalToken. 
        /// <para>
        ///  Retrieval token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1020)]
        public string RetrievalToken
        {
            get { return this._retrievalToken; }
            set { this._retrievalToken = value; }
        }

        // Check to see if RetrievalToken property is set
        internal bool IsSetRetrievalToken()
        {
            return this._retrievalToken != null;
        }

    }
}