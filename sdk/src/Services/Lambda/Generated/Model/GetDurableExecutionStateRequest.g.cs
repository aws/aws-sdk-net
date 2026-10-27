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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the GetDurableExecutionState operation. Retrieves
    /// the current execution state required for the replay process during <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-functions.html">durable
    /// function</a> execution. This API is used by the Lambda durable functions SDK to get
    /// state information needed for replay. You typically don't need to call this API directly
    /// as the SDK handles state management automatically. <para> The response contains operations
    /// ordered by start sequence number in ascending order. Completed operations with children
    /// don't include child operation details since they don't need to be replayed. </para>
    /// </summary>
    public partial class GetDurableExecutionStateRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property CheckpointToken. 
        /// <para>
        /// A checkpoint token that identifies the current state of the execution. This token
        /// is provided by the Lambda runtime and ensures that state retrieval is consistent with
        /// the current execution context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string CheckpointToken { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointToken property is set.
        /// </summary>
        internal bool IsSetCheckpointToken() => this.CheckpointToken != null;

        /// <summary>
        /// Gets and sets the property DurableExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DurableExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the DurableExecutionArn property is set.
        /// </summary>
        internal bool IsSetDurableExecutionArn() => this.DurableExecutionArn != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If <c>NextMarker</c> was returned from a previous request, use this value to retrieve
        /// the next page of operations. Each pagination token expires after 24 hours.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of operations to return per call. You can use <c>Marker</c> to
        /// retrieve additional pages of results. The default is 100 and the maximum allowed is
        /// 1000. A value of 0 uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;
    }
}
