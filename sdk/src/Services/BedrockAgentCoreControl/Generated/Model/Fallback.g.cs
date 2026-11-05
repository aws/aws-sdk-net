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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The fallback configuration for a route to an inference target. Defines an ordered
    /// list of fallback targets to try when a request to the route's target fails, and the
    /// conditions that trigger a fallback. A fallback can occur only before the gateway sends
    /// the first byte of the response to the caller. After a streaming response starts, the
    /// gateway doesn't fall back.
    /// </summary>
    public partial class Fallback
    {
        /// <summary>
        /// Gets and sets the property CircuitBreaker. 
        /// <para>
        /// Specifies whether the gateway temporarily stops sending your requests to a failing
        /// target. The circuit breaker tracks each combination of target and model separately.
        /// With the circuit breaker enabled, the gateway skips one or more targets and models
        /// that fail repeatedly, and your requests go to the next target in the chain. The gateway
        /// always tries the last remaining target in the chain. The gateway enables the circuit
        /// breaker by default.
        /// </para>
        /// </summary>
        public CircuitBreakerConfiguration CircuitBreaker { get; set; }

        /// <summary>
        /// Checks to see if the CircuitBreaker property is set.
        /// </summary>
        internal bool IsSetCircuitBreaker() => this.CircuitBreaker != null;

        /// <summary>
        /// Gets and sets the property FirstByteTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, from sending the request to the route's target
        /// until the first byte of the response body arrives. If the time expires, the gateway
        /// abandons the request and treats it as a <c>FIRST_BYTE_TIMEOUT</c> error. If you don't
        /// specify a value, no timeout is enforced.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 900000)]
        public int? FirstByteTimeoutMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the FirstByteTimeoutMilliseconds property is set.
        /// </summary>
        internal bool IsSetFirstByteTimeoutMilliseconds() => this.FirstByteTimeoutMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property TargetFallback. 
        /// <para>
        /// The ordered list of fallback targets. The gateway tries each target in order until
        /// a response doesn't match that target's triggers, and returns that response to the
        /// caller. If every target fails, the gateway returns the last response. You can specify
        /// up to two fallback targets. Each combination of target and model, including the route's
        /// target, can appear only once.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<FallbackTarget> TargetFallback { get; set; } = AWSConfigs.InitializeCollections ? new List<FallbackTarget>() : null;

        /// <summary>
        /// Checks to see if the TargetFallback property is set.
        /// </summary>
        internal bool IsSetTargetFallback() => this.TargetFallback != null && (this.TargetFallback.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggerOn. 
        /// <para>
        /// The status codes and errors from the route's target that cause the gateway to send
        /// the request to the first fallback target. If you omit <c>triggerOn</c>, the gateway
        /// falls back on <c>5XX</c> status codes and on the <c>CONNECTION_ERROR</c>, <c>FIRST_BYTE_TIMEOUT</c>,
        /// and <c>UNROUTABLE</c> errors. If you specify <c>triggerOn</c>, only the status codes
        /// and errors that you list trigger a fallback.
        /// </para>
        /// </summary>
        public FallbackTriggers TriggerOn { get; set; }

        /// <summary>
        /// Checks to see if the TriggerOn property is set.
        /// </summary>
        internal bool IsSetTriggerOn() => this.TriggerOn != null;
    }
}
