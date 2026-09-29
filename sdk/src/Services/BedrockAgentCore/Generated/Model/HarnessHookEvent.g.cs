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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A lifecycle hook event emitted in the invocation stream for visibility into hook decisions.
    /// </summary>
    public partial class HarnessHookEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Decision. 
        /// <para>
        /// The decision applied to the hook event. This field is present only for blocking Lambda
        /// targets.
        /// </para>
        /// </summary>
        public HarnessHookDecision Decision { get; set; }

        /// <summary>
        /// Checks to see if the Decision property is set.
        /// </summary>
        internal bool IsSetDecision() => this.Decision != null;

        /// <summary>
        /// Gets and sets the property HookEventId. 
        /// <para>
        /// The unique identifier for this hook event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HookEventId { get; set; }

        /// <summary>
        /// Checks to see if the HookEventId property is set.
        /// </summary>
        internal bool IsSetHookEventId() => this.HookEventId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hook that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The optional reason for the applied decision.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of lifecycle hook event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarnessHookEventType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
