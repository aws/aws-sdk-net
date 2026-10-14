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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the GetExecutionHistory operation. Returns the history
    /// of the specified execution as a list of events. By default, the results are returned
    /// in ascending order of the <c>timeStamp</c> of the events. Use the <c>reverseOrder</c>
    /// parameter to get the latest events first. <para> If <c>nextToken</c> is returned,
    /// there are more results available. The value of <c>nextToken</c> is a unique pagination
    /// token for each page. Make the call again using the returned token to retrieve the
    /// next page. Keep all other arguments unchanged. Each pagination token expires after
    /// 24 hours. Using an expired pagination token will return an <i>HTTP 400 InvalidToken</i>
    /// error. </para> <para> This API action is not supported by <c>EXPRESS</c> state machines.
    /// </para>
    /// </summary>
    public partial class GetExecutionHistoryRequest : AmazonStepFunctionsRequest
    {
        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionArn property is set.
        /// </summary>
        internal bool IsSetExecutionArn() => this.ExecutionArn != null;

        /// <summary>
        /// Gets and sets the property IncludeExecutionData. 
        /// <para>
        /// You can select whether execution data (input or output of a history event) is returned.
        /// The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeExecutionData { get; set; }

        /// <summary>
        /// Checks to see if the IncludeExecutionData property is set.
        /// </summary>
        internal bool IsSetIncludeExecutionData() => this.IncludeExecutionData.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned per call. You can use <c>nextToken</c>
        /// to obtain further pages of results. The default is 100 and the maximum allowed page
        /// size is 1000. A value of 0 uses the default.
        /// </para>
        ///  
        /// <para>
        /// This is only an upper limit. The actual number of results returned per call might
        /// be fewer than the specified maximum.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an <i>HTTP
        /// 400 InvalidToken</i> error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ReverseOrder. 
        /// <para>
        /// Lists events in descending order of their <c>timeStamp</c>.
        /// </para>
        /// </summary>
        public bool? ReverseOrder { get; set; }

        /// <summary>
        /// Checks to see if the ReverseOrder property is set.
        /// </summary>
        internal bool IsSetReverseOrder() => this.ReverseOrder.HasValue;
    }
}
