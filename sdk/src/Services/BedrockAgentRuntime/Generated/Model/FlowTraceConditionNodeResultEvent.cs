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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about an output from a condition node. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-trace.html">Track
    /// each step in your prompt flow by viewing its trace in Amazon Bedrock</a>.
    /// </summary>
    public partial class FlowTraceConditionNodeResultEvent
    {
        private string _nodeName;
        private List<FlowTraceCondition> _satisfiedConditions = AWSConfigs.InitializeCollections ? new List<FlowTraceCondition>() : null;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the condition node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeName
        {
            get { return this._nodeName; }
            set { this._nodeName = value; }
        }

        // Check to see if NodeName property is set
        internal bool IsSetNodeName()
        {
            return this._nodeName != null;
        }

        /// <summary>
        /// Gets and sets the property SatisfiedConditions. 
        /// <para>
        /// An array of objects containing information about the conditions that were satisfied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<FlowTraceCondition> SatisfiedConditions
        {
            get { return this._satisfiedConditions; }
            set { this._satisfiedConditions = value; }
        }

        // Check to see if SatisfiedConditions property is set
        internal bool IsSetSatisfiedConditions()
        {
            return this._satisfiedConditions != null && (this._satisfiedConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time that the trace was returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}