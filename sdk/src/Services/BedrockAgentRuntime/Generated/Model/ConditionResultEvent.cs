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
    /// Contains information about a condition evaluation result during an async execution.
    /// This event is generated when a condition node in the flow evaluates its conditions.
    /// 
    ///  <note> 
    /// <para>
    /// Asynchronous flows is in preview release for Amazon Bedrock and is subject to change.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ConditionResultEvent
    {
        private string _nodeName;
        private List<SatisfiedCondition> _satisfiedConditions = AWSConfigs.InitializeCollections ? new List<SatisfiedCondition>() : null;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the condition node that evaluated the conditions.
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
        /// A list of conditions that were satisfied during the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<SatisfiedCondition> SatisfiedConditions
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
        /// The timestamp when the condition evaluation occurred.
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