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
    /// This is the response object from the UpdateAgentInsightStore operation.
    /// </summary>
    public partial class UpdateAgentInsightStoreResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentInsightStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated Agent Insight Store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentInsightStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentInsightStoreArn property is set.
        /// </summary>
        internal bool IsSetAgentInsightStoreArn() => this.AgentInsightStoreArn != null;

        /// <summary>
        /// Gets and sets the property AgentInsightStoreId. 
        /// <para>
        /// The unique identifier of the updated Agent Insight Store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgentInsightStoreId { get; set; }

        /// <summary>
        /// Checks to see if the AgentInsightStoreId property is set.
        /// </summary>
        internal bool IsSetAgentInsightStoreId() => this.AgentInsightStoreId != null;

        /// <summary>
        /// Gets and sets the property EnablementStatus. 
        /// <para>
        /// Specifies whether the Agent Insight Store accepts new Agent Insights after the update
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInsightStoreEnablementStatus EnablementStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnablementStatus property is set.
        /// </summary>
        internal bool IsSetEnablementStatus() => this.EnablementStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Describes the failure that prevented the Agent Insight Store from reaching its requested
        /// lifecycle status.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The lifecycle status of the Agent Insight Store after the update request. Valid values:
        /// </para>
        ///  <dl> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The store is available.
        /// </para>
        ///  </dd> <dt>UPDATING</dt> <dd> 
        /// <para>
        /// The service is applying a requested change.
        /// </para>
        ///  </dd> <dt>INACTIVE</dt> <dd> 
        /// <para>
        /// The store does not accept new Agent Insights.
        /// </para>
        ///  </dd> <dt>ERROR</dt> <dd> 
        /// <para>
        /// The store requires intervention.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInsightStoreStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the Agent Insight Store was last updated.
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
