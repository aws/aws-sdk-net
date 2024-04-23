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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains details about topics that the guardrail should identify and deny.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateGuardrail.html#API_CreateGuardrail_RequestSyntax">CreateGuardrail
    /// request body</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_UpdateGuardrail.html#API_UpdateGuardrail_RequestSyntax">UpdateGuardrail
    /// request body</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GuardrailTopicPolicyConfig
    {
        private List<GuardrailTopicConfig> _topicsConfig = AWSConfigs.InitializeCollections ? new List<GuardrailTopicConfig>() : null;

        /// <summary>
        /// Gets and sets the property TopicsConfig. 
        /// <para>
        /// A list of policies related to topics that the guardrail should deny.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<GuardrailTopicConfig> TopicsConfig
        {
            get { return this._topicsConfig; }
            set { this._topicsConfig = value; }
        }

        // Check to see if TopicsConfig property is set
        internal bool IsSetTopicsConfig()
        {
            return this._topicsConfig != null && (this._topicsConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}