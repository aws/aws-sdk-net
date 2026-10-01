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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the UpdateAgent operation.
    /// </summary>
    public partial class UpdateAgentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentStatus AgentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentStatus property is set.
        /// </summary>
        internal bool IsSetAgentStatus() => this.AgentStatus != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1284)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property FailedToAddActionConnectors. 
        /// <para>
        /// A list of per-ARN failures from the action connectors that were requested to be added.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedToUpdateAssociation> FailedToAddActionConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<FailedToUpdateAssociation>() : null;

        /// <summary>
        /// Checks to see if the FailedToAddActionConnectors property is set.
        /// </summary>
        internal bool IsSetFailedToAddActionConnectors() => this.FailedToAddActionConnectors != null && (this.FailedToAddActionConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailedToAddSpaces. 
        /// <para>
        /// A list of per-ARN failures from the spaces that were requested to be added.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedToUpdateAssociation> FailedToAddSpaces { get; set; } = AWSConfigs.InitializeCollections ? new List<FailedToUpdateAssociation>() : null;

        /// <summary>
        /// Checks to see if the FailedToAddSpaces property is set.
        /// </summary>
        internal bool IsSetFailedToAddSpaces() => this.FailedToAddSpaces != null && (this.FailedToAddSpaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailedToRemoveActionConnectors. 
        /// <para>
        /// A list of per-ARN failures from the action connectors that were requested to be removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedToUpdateAssociation> FailedToRemoveActionConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<FailedToUpdateAssociation>() : null;

        /// <summary>
        /// Checks to see if the FailedToRemoveActionConnectors property is set.
        /// </summary>
        internal bool IsSetFailedToRemoveActionConnectors() => this.FailedToRemoveActionConnectors != null && (this.FailedToRemoveActionConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailedToRemoveSpaces. 
        /// <para>
        /// A list of per-ARN failures from the spaces that were requested to be removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedToUpdateAssociation> FailedToRemoveSpaces { get; set; } = AWSConfigs.InitializeCollections ? new List<FailedToUpdateAssociation>() : null;

        /// <summary>
        /// Checks to see if the FailedToRemoveSpaces property is set.
        /// </summary>
        internal bool IsSetFailedToRemoveSpaces() => this.FailedToRemoveSpaces != null && (this.FailedToRemoveSpaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;
    }
}
