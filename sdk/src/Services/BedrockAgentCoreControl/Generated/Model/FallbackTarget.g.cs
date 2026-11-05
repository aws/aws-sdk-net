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
    /// Specifies a target to send the request to when the previous target in the fallback
    /// chain fails. Includes the target name, the model to send, and the conditions that
    /// trigger a fallback from this target to the next one.
    /// </summary>
    public partial class FallbackTarget
    {
        /// <summary>
        /// Gets and sets the property FirstByteTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, from sending the request to this target until the
        /// first byte of the response body arrives. This setting isn't inherited from the route.
        /// If you don't specify a value, no timeout is enforced.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 900000)]
        public int? FirstByteTimeoutMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the FirstByteTimeoutMilliseconds property is set.
        /// </summary>
        internal bool IsSetFirstByteTimeoutMilliseconds() => this.FirstByteTimeoutMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model ID to send to this fallback target. If you don't specify a model, the gateway
        /// sends the model from the original request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the gateway target to fall back to. The target must be an inference target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string TargetName { get; set; }

        /// <summary>
        /// Checks to see if the TargetName property is set.
        /// </summary>
        internal bool IsSetTargetName() => this.TargetName != null;

        /// <summary>
        /// Gets and sets the property TriggerOn. 
        /// <para>
        /// The status codes and errors from this target that cause the gateway to send the request
        /// to the next fallback target. This setting isn't inherited from the route. If you omit
        /// it, the gateway uses the default triggers: <c>5XX</c> status codes and the <c>CONNECTION_ERROR</c>,
        /// <c>FIRST_BYTE_TIMEOUT</c>, and <c>UNROUTABLE</c> errors.
        /// </para>
        /// </summary>
        public FallbackTriggers TriggerOn { get; set; }

        /// <summary>
        /// Checks to see if the TriggerOn property is set.
        /// </summary>
        internal bool IsSetTriggerOn() => this.TriggerOn != null;
    }
}
