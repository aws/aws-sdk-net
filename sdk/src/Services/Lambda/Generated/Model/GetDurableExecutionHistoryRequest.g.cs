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
    /// Container for the parameters to the GetDurableExecutionHistory operation. Retrieves
    /// the execution history for a <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-functions.html">durable
    /// execution</a>, showing all the steps, callbacks, and events that occurred during the
    /// execution. This provides a detailed audit trail of the execution's progress over time.
    /// <para> The history is available while the execution is running and for a retention
    /// period after it completes (1-90 days, default 30 days). You can control whether to
    /// include execution data such as step results and callback payloads. </para>
    /// </summary>
    public partial class GetDurableExecutionHistoryRequest : AmazonLambdaRequest
    {
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
        /// Gets and sets the property IncludeExecutionData. 
        /// <para>
        /// Specifies whether to include execution data such as step results and callback payloads
        /// in the history events. Set to <c>true</c> to include data, or <c>false</c> to exclude
        /// it for a more compact response. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeExecutionData { get; set; }

        /// <summary>
        /// Checks to see if the IncludeExecutionData property is set.
        /// </summary>
        internal bool IsSetIncludeExecutionData() => this.IncludeExecutionData.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If <c>NextMarker</c> was returned from a previous request, use this value to retrieve
        /// the next page of results. Each pagination token expires after 24 hours.
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
        /// The maximum number of history events to return per call. You can use <c>Marker</c>
        /// to retrieve additional pages of results. The default is 100 and the maximum allowed
        /// is 1000. A value of 0 uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property ReverseOrder. 
        /// <para>
        /// When set to <c>true</c>, returns the history events in reverse chronological order
        /// (newest first). By default, events are returned in chronological order (oldest first).
        /// </para>
        /// </summary>
        public bool? ReverseOrder { get; set; }

        /// <summary>
        /// Checks to see if the ReverseOrder property is set.
        /// </summary>
        internal bool IsSetReverseOrder() => this.ReverseOrder.HasValue;
    }
}
