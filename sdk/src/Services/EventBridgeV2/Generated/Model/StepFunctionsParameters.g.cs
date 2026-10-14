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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Step Functions invocation parameters for subscribers. Values are forwarded to the
    /// Step Functions StartExecution or StartSyncExecution API. Every string member accepts
    /// a literal or a JSONata expression (e.g. "{% $events.Data.executionName %}").
    /// </summary>
    public partial class StepFunctionsParameters
    {
        /// <summary>
        /// Gets and sets the property InvocationTimeoutSeconds. Timeout in seconds for each invocation
        /// of the target (1-30). String-typed (not integer) so the value may be a JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string InvocationTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the InvocationTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetInvocationTimeoutSeconds() => this.InvocationTimeoutSeconds != null;

        /// <summary>
        /// Gets and sets the property InvocationType. Selects StartExecution (EVENT) or StartSyncExecution
        /// (REQUEST_RESPONSE) at delivery.
        /// </summary>
        public InvocationType InvocationType { get; set; }

        /// <summary>
        /// Checks to see if the InvocationType property is set.
        /// </summary>
        internal bool IsSetInvocationType() => this.InvocationType != null;

        /// <summary>
        /// Gets and sets the property Name. Name for the execution. Must be unique per account/region/state
        /// machine. Accepts JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TraceHeader. X-Ray trace header for distributed tracing.
        /// Accepts JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string TraceHeader { get; set; }

        /// <summary>
        /// Checks to see if the TraceHeader property is set.
        /// </summary>
        internal bool IsSetTraceHeader() => this.TraceHeader != null;
    }
}
