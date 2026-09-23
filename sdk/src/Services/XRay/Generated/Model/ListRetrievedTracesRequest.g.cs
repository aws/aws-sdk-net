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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListRetrievedTraces operation. Retrieves a list
    /// of traces for a given <c>RetrievalToken</c> from the CloudWatch log group generated
    /// by Transaction Search. For information on what each trace returns, see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
    /// <para> This API does not initiate a retrieval process. To start a trace retrieval,
    /// use <c>StartTraceRetrieval</c>, which generates the required <c>RetrievalToken</c>.
    /// </para> <para> When the <c>RetrievalStatus</c> is not <i>COMPLETE</i>, the API will
    /// return an empty response. Retry the request once the retrieval has completed to access
    /// the full list of traces. </para> <para> For cross-account observability, this API
    /// can retrieve traces from linked accounts when CloudWatch log is set as the destination
    /// across relevant accounts. For more details, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>. </para> <para> For retrieving data from X-Ray directly
    /// as opposed to the Transaction Search generated log group, see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
    /// </para>
    /// </summary>
    public partial class ListRetrievedTracesRequest : AmazonXRayRequest
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Specify the pagination token returned by a previous request to retrieve the next
        /// page of indexes. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RetrievalToken. 
        /// <para>
        ///  Retrieval token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1020)]
        public string RetrievalToken { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalToken property is set.
        /// </summary>
        internal bool IsSetRetrievalToken() => this.RetrievalToken != null;

        /// <summary>
        /// Gets and sets the property TraceFormat. 
        /// <para>
        ///  Format of the requested traces. 
        /// </para>
        /// </summary>
        public TraceFormatType TraceFormat { get; set; }

        /// <summary>
        /// Checks to see if the TraceFormat property is set.
        /// </summary>
        internal bool IsSetTraceFormat() => this.TraceFormat != null;
    }
}
