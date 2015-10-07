/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ReplaceTopicRule operation.
    /// Replaces the specified rule. You must specify all parameters for the new rule.
    /// </summary>
    public partial class ReplaceTopicRuleRequest : AmazonIoTRequest
    {
        private string _ruleName;
        private TopicRulePayload _topicRulePayload;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property TopicRulePayload. 
        /// <para>
        /// The rule payload.
        /// </para>
        /// </summary>
        public TopicRulePayload TopicRulePayload
        {
            get { return this._topicRulePayload; }
            set { this._topicRulePayload = value; }
        }

        // Check to see if TopicRulePayload property is set
        internal bool IsSetTopicRulePayload()
        {
            return this._topicRulePayload != null;
        }

    }
}