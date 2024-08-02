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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The details on the use of the guardrail.
    /// </summary>
    public partial class GuardrailUsage
    {
        private int? _contentPolicyUnits;
        private int? _contextualGroundingPolicyUnits;
        private int? _sensitiveInformationPolicyFreeUnits;
        private int? _sensitiveInformationPolicyUnits;
        private int? _topicPolicyUnits;
        private int? _wordPolicyUnits;

        /// <summary>
        /// Gets and sets the property ContentPolicyUnits. 
        /// <para>
        /// The content policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int ContentPolicyUnits
        {
            get { return this._contentPolicyUnits.GetValueOrDefault(); }
            set { this._contentPolicyUnits = value; }
        }

        // Check to see if ContentPolicyUnits property is set
        internal bool IsSetContentPolicyUnits()
        {
            return this._contentPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicyUnits. 
        /// <para>
        /// The contextual grounding policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int ContextualGroundingPolicyUnits
        {
            get { return this._contextualGroundingPolicyUnits.GetValueOrDefault(); }
            set { this._contextualGroundingPolicyUnits = value; }
        }

        // Check to see if ContextualGroundingPolicyUnits property is set
        internal bool IsSetContextualGroundingPolicyUnits()
        {
            return this._contextualGroundingPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyFreeUnits. 
        /// <para>
        /// The sensitive information policy free units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int SensitiveInformationPolicyFreeUnits
        {
            get { return this._sensitiveInformationPolicyFreeUnits.GetValueOrDefault(); }
            set { this._sensitiveInformationPolicyFreeUnits = value; }
        }

        // Check to see if SensitiveInformationPolicyFreeUnits property is set
        internal bool IsSetSensitiveInformationPolicyFreeUnits()
        {
            return this._sensitiveInformationPolicyFreeUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyUnits. 
        /// <para>
        /// The sensitive information policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int SensitiveInformationPolicyUnits
        {
            get { return this._sensitiveInformationPolicyUnits.GetValueOrDefault(); }
            set { this._sensitiveInformationPolicyUnits = value; }
        }

        // Check to see if SensitiveInformationPolicyUnits property is set
        internal bool IsSetSensitiveInformationPolicyUnits()
        {
            return this._sensitiveInformationPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicPolicyUnits. 
        /// <para>
        /// The topic policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int TopicPolicyUnits
        {
            get { return this._topicPolicyUnits.GetValueOrDefault(); }
            set { this._topicPolicyUnits = value; }
        }

        // Check to see if TopicPolicyUnits property is set
        internal bool IsSetTopicPolicyUnits()
        {
            return this._topicPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WordPolicyUnits. 
        /// <para>
        /// The word policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int WordPolicyUnits
        {
            get { return this._wordPolicyUnits.GetValueOrDefault(); }
            set { this._wordPolicyUnits = value; }
        }

        // Check to see if WordPolicyUnits property is set
        internal bool IsSetWordPolicyUnits()
        {
            return this._wordPolicyUnits.HasValue; 
        }

    }
}