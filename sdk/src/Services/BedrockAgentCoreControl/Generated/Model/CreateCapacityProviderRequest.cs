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
    /// Container for the parameters to the CreateCapacityProvider operation.
    /// Creates a capacity provider. A capacity provider defines the Amazon EC2 infrastructure
    /// for AgentCore Runtime, including the operating system, allowed instance types, networking,
    /// and storage. It also specifies the IAM permissions that AgentCore uses to manage those
    /// instances.
    /// 
    ///  
    /// <para>
    /// The capacity provider name must be unique within your account. After you create the
    /// capacity provider, it enters a <c>CREATING</c> state and transitions to <c>READY</c>
    /// when it is available for use.
    /// </para>
    /// </summary>
    public partial class CreateCapacityProviderRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private ComputeConfiguration _computeConfiguration;
        private string _description;
        private string _name;
        private PermissionsConfiguration _permissionsConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration for the capacity provider. This defines the Amazon EC2 compute
        /// resources used to launch instances: the operating system, allowed instance types,
        /// networking, and storage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeConfiguration ComputeConfiguration
        {
            get { return this._computeConfiguration; }
            set { this._computeConfiguration = value; }
        }

        // Check to see if ComputeConfiguration property is set
        internal bool IsSetComputeConfiguration()
        {
            return this._computeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the capacity provider. If you don't specify a description,
        /// the service creates the capacity provider without one.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity provider. The name must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsConfiguration. 
        /// <para>
        /// The permissions configuration for the capacity provider. This specifies the IAM role
        /// that AgentCore uses to manage the Amazon EC2 instances on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PermissionsConfiguration PermissionsConfiguration
        {
            get { return this._permissionsConfiguration; }
            set { this._permissionsConfiguration = value; }
        }

        // Check to see if PermissionsConfiguration property is set
        internal bool IsSetPermissionsConfiguration()
        {
            return this._permissionsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to associate with the capacity provider. If you don't
        /// specify tags, the capacity provider is created with no tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}