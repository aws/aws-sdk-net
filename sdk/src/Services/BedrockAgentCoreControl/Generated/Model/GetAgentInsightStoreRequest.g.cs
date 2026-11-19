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
    /// Container for the parameters to the GetAgentInsightStore operation. Returns the account's
    /// service-defined default Agent Insight Store. The logical default exists for every
    /// enrolled account; its backing state may be initialized on first access.
    /// </summary>
    public partial class GetAgentInsightStoreRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property AgentInsightStoreId. 
        /// <para>
        /// Specifies the unique identifier of the Agent Insight Store to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgentInsightStoreId { get; set; }

        /// <summary>
        /// Checks to see if the AgentInsightStoreId property is set.
        /// </summary>
        internal bool IsSetAgentInsightStoreId() => this.AgentInsightStoreId != null;
    }
}
