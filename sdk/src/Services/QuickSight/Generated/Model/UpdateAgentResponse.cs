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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _agentId;
        private AgentStatus _agentStatus;
        private string _arn;
        private List<FailedToUpdateAssociation> _failedToAddActionConnectors = AWSConfigs.InitializeCollections ? new List<FailedToUpdateAssociation>() : null;
        private List<FailedToUpdateAssociation> _failedToAddSpaces = AWSConfigs.InitializeCollections ? new List<FailedToUpdateAssociation>() : null;
        private List<FailedToUpdateAssociation> _failedToRemoveActionConnectors = AWSConfigs.InitializeCollections ? new List<FailedToUpdateAssociation>() : null;
        private List<FailedToUpdateAssociation> _failedToRemoveSpaces = AWSConfigs.InitializeCollections ? new List<FailedToUpdateAssociation>() : null;
        private string _requestId;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentStatus AgentStatus
        {
            get { return this._agentStatus; }
            set { this._agentStatus = value; }
        }

        // Check to see if AgentStatus property is set
        internal bool IsSetAgentStatus()
        {
            return this._agentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property FailedToAddActionConnectors. 
        /// <para>
        /// A list of per-ARN failures from the action connectors that were requested to be added.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedToUpdateAssociation> FailedToAddActionConnectors
        {
            get { return this._failedToAddActionConnectors; }
            set { this._failedToAddActionConnectors = value; }
        }

        // Check to see if FailedToAddActionConnectors property is set
        internal bool IsSetFailedToAddActionConnectors()
        {
            return this._failedToAddActionConnectors != null && (this._failedToAddActionConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedToAddSpaces. 
        /// <para>
        /// A list of per-ARN failures from the spaces that were requested to be added.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedToUpdateAssociation> FailedToAddSpaces
        {
            get { return this._failedToAddSpaces; }
            set { this._failedToAddSpaces = value; }
        }

        // Check to see if FailedToAddSpaces property is set
        internal bool IsSetFailedToAddSpaces()
        {
            return this._failedToAddSpaces != null && (this._failedToAddSpaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedToRemoveActionConnectors. 
        /// <para>
        /// A list of per-ARN failures from the action connectors that were requested to be removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedToUpdateAssociation> FailedToRemoveActionConnectors
        {
            get { return this._failedToRemoveActionConnectors; }
            set { this._failedToRemoveActionConnectors = value; }
        }

        // Check to see if FailedToRemoveActionConnectors property is set
        internal bool IsSetFailedToRemoveActionConnectors()
        {
            return this._failedToRemoveActionConnectors != null && (this._failedToRemoveActionConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedToRemoveSpaces. 
        /// <para>
        /// A list of per-ARN failures from the spaces that were requested to be removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedToUpdateAssociation> FailedToRemoveSpaces
        {
            get { return this._failedToRemoveSpaces; }
            set { this._failedToRemoveSpaces = value; }
        }

        // Check to see if FailedToRemoveSpaces property is set
        internal bool IsSetFailedToRemoveSpaces()
        {
            return this._failedToRemoveSpaces != null && (this._failedToRemoveSpaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

    }
}