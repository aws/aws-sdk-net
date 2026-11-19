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
    /// This is the response object from the UpdateAgentInsight operation.
    /// </summary>
    public partial class UpdateAgentInsightResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentInsightId. 
        /// <para>
        /// The unique identifier of the updated Agent Insight.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgentInsightId { get; set; }

        /// <summary>
        /// Checks to see if the AgentInsightId property is set.
        /// </summary>
        internal bool IsSetAgentInsightId() => this.AgentInsightId != null;

        /// <summary>
        /// Gets and sets the property ArchiveStatus. 
        /// <para>
        /// The archive status of the updated Agent Insight. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The insight is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVED</c> - The insight is archived.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInsightArchiveStatus ArchiveStatus { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveStatus property is set.
        /// </summary>
        internal bool IsSetArchiveStatus() => this.ArchiveStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the Agent Insight was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
