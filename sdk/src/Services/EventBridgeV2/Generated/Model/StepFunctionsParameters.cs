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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
    /// a literal or a JSONata expression (e.g. &quot;{% $events.Data.executionName %}&quot;).
    /// </summary>
    public partial class StepFunctionsParameters
    {
        private string _invocationTimeoutSeconds;
        private InvocationType _invocationType;
        private string _name;
        private string _traceHeader;

        /// <summary>
        /// Gets and sets the property InvocationTimeoutSeconds. 
        /// <para>
        /// Timeout in seconds for each invocation of the target (1-30). String-typed (not integer)
        /// so the value may be a JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string InvocationTimeoutSeconds
        {
            get { return this._invocationTimeoutSeconds; }
            set { this._invocationTimeoutSeconds = value; }
        }

        // Check to see if InvocationTimeoutSeconds property is set
        internal bool IsSetInvocationTimeoutSeconds()
        {
            return this._invocationTimeoutSeconds != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// Selects StartExecution (EVENT) or StartSyncExecution (REQUEST_RESPONSE) at delivery.
        /// </para>
        /// </summary>
        public InvocationType InvocationType
        {
            get { return this._invocationType; }
            set { this._invocationType = value; }
        }

        // Check to see if InvocationType property is set
        internal bool IsSetInvocationType()
        {
            return this._invocationType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name for the execution. Must be unique per account/region/state machine. Accepts JSONata
        /// expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TraceHeader. 
        /// <para>
        /// X-Ray trace header for distributed tracing. Accepts JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string TraceHeader
        {
            get { return this._traceHeader; }
            set { this._traceHeader = value; }
        }

        // Check to see if TraceHeader property is set
        internal bool IsSetTraceHeader()
        {
            return this._traceHeader != null;
        }

    }
}