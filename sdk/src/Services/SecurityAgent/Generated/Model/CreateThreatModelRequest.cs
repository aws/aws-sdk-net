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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateThreatModel operation.
    /// Creates a new threat model configuration in an agent space. A threat model defines
    /// the parameters for automated threat analysis.
    /// </summary>
    public partial class CreateThreatModelRequest : AmazonSecurityAgentRequest
    {
        private string _agentSpaceId;
        private Assets _assets;
        private string _description;
        private CloudWatchLog _logConfig;
        private ReportDestination _reportDestination;
        private List<DocumentInfo> _scopeDocs = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;
        private string _serviceRole;
        private string _title;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space to create the threat model in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The assets to include in the threat model.
        /// </para>
        /// </summary>
        public Assets Assets
        {
            get { return this._assets; }
            set { this._assets = value; }
        }

        // Check to see if Assets property is set
        internal bool IsSetAssets()
        {
            return this._assets != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the application or system being threat modeled.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The CloudWatch Logs configuration for the threat model.
        /// </para>
        /// </summary>
        public CloudWatchLog LogConfig
        {
            get { return this._logConfig; }
            set { this._logConfig = value; }
        }

        // Check to see if LogConfig property is set
        internal bool IsSetLogConfig()
        {
            return this._logConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ReportDestination. 
        /// <para>
        /// The destination for publishing scan reports to an integrated document provider.
        /// </para>
        /// </summary>
        public ReportDestination ReportDestination
        {
            get { return this._reportDestination; }
            set { this._reportDestination = value; }
        }

        // Check to see if ReportDestination property is set
        internal bool IsSetReportDestination()
        {
            return this._reportDestination != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeDocs. 
        /// <para>
        /// The scoped documents for the agent to focus on during threat modeling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentInfo> ScopeDocs
        {
            get { return this._scopeDocs; }
            set { this._scopeDocs = value; }
        }

        // Check to see if ScopeDocs property is set
        internal bool IsSetScopeDocs()
        {
            return this._scopeDocs != null && (this._scopeDocs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM service role to use for the threat model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the threat model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}