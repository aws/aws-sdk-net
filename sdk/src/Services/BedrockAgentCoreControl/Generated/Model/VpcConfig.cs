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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// VpcConfig for the Agent.
    /// </summary>
    public partial class VpcConfig
    {
        private bool? _requireServiceS3Endpoint;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property RequireServiceS3Endpoint. 
        /// <para>
        /// <note> 
        /// <para>
        /// This field applies only to Agent Runtimes. It is not applicable to Browsers or Code
        /// Interpreters.
        /// </para>
        ///  </note> 
        /// <para>
        /// Controls whether a service-managed Amazon S3 gateway endpoint is provisioned in the
        /// VPC network topology for the agent runtime. This gateway is used by Amazon Bedrock
        /// AgentCore Runtime to download code and container images during agent startup.
        /// </para>
        ///  
        /// <para>
        /// Starting May 5, 2026, Amazon Bedrock AgentCore Runtime is gradually rolling out a
        /// change to how network isolation is configured for VPC mode agents. Agent runtimes
        /// created on or after this rollout will no longer include the service-managed Amazon
        /// S3 gateway. Instead, all network access, including to Amazon S3, is governed exclusively
        /// by your VPC configuration. This field cannot be set on agent runtimes created after
        /// the rollout. Passing this field in an <c>UpdateAgentRuntime</c> request for these
        /// agent runtimes returns a <c>ValidationException</c>.
        /// </para>
        ///  
        /// <para>
        /// Agent runtimes created before the rollout are not affected and continue to operate
        /// with the service-managed Amazon S3 gateway. To enforce full VPC network isolation
        /// on these existing agent runtimes, set this field to <c>false</c> via the <c>UpdateAgentRuntime</c>
        /// API. Before opting out, ensure your VPC provides the Amazon S3 access required for
        /// agent startup. If this field is not specified or is set to <c>true</c>, the service-managed
        /// Amazon S3 gateway remains provisioned.
        /// </para>
        ///  
        /// <para>
        /// This field is only supported in the <c>UpdateAgentRuntime</c> API for pre-rollout
        /// agent runtimes. Passing this field in a <c>CreateAgentRuntime</c> request returns
        /// a <c>ValidationException</c>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        public bool? RequireServiceS3Endpoint
        {
            get { return this._requireServiceS3Endpoint; }
            set { this._requireServiceS3Endpoint = value; }
        }

        // Check to see if RequireServiceS3Endpoint property is set
        internal bool IsSetRequireServiceS3Endpoint()
        {
            return this._requireServiceS3Endpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups associated with the VPC configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The subnets associated with the VPC configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}