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
    /// Represents a condition that was satisfied during a condition node evaluation in a
    /// flow execution.
    /// 
    ///  <note> 
    /// <para>
    /// Flow executions is in preview release for Amazon Bedrock and is subject to change.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SatisfiedCondition
    {
        private string _conditionName;

        /// <summary>
        /// Gets and sets the property ConditionName. 
        /// <para>
        /// The name of the condition that was satisfied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConditionName
        {
            get { return this._conditionName; }
            set { this._conditionName = value; }
        }

        // Check to see if ConditionName property is set
        internal bool IsSetConditionName()
        {
            return this._conditionName != null;
        }

    }
}