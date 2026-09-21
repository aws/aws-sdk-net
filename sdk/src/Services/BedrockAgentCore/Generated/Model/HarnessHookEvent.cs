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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A lifecycle hook event emitted in the invocation stream for visibility into hook decisions.
    /// </summary>
    public partial class HarnessHookEvent
        : IEventStreamEvent
    {
        private HarnessHookDecision _decision;
        private string _hookEventId;
        private string _name;
        private string _reason;
        private HarnessHookEventType _type;

        /// <summary>
        /// Gets and sets the property Decision. 
        /// <para>
        /// The decision applied to the hook event. This field is present only for blocking Lambda
        /// targets.
        /// </para>
        /// </summary>
        public HarnessHookDecision Decision
        {
            get { return this._decision; }
            set { this._decision = value; }
        }

        // Check to see if Decision property is set
        internal bool IsSetDecision()
        {
            return this._decision != null;
        }

        /// <summary>
        /// Gets and sets the property HookEventId. 
        /// <para>
        /// The unique identifier for this hook event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HookEventId
        {
            get { return this._hookEventId; }
            set { this._hookEventId = value; }
        }

        // Check to see if HookEventId property is set
        internal bool IsSetHookEventId()
        {
            return this._hookEventId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hook that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// The optional reason for the applied decision.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of lifecycle hook event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HarnessHookEventType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}