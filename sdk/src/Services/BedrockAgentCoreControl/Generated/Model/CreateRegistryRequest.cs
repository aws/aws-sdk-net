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
    /// Container for the parameters to the CreateRegistry operation.
    /// Creates a new registry in your Amazon Web Services account. A registry serves as a
    /// centralized catalog for organizing and managing registry records, including MCP servers,
    /// A2A agents, agent skills, and custom resource types.
    /// 
    ///  
    /// <para>
    /// If you specify <c>CUSTOM_JWT</c> as the <c>authorizerType</c>, you must provide an
    /// <c>authorizerConfiguration</c>.
    /// </para>
    /// </summary>
    public partial class CreateRegistryRequest : AmazonBedrockAgentCoreControlRequest
    {
        private ApprovalConfiguration _approvalConfiguration;
        private AuthorizerConfiguration _authorizerConfiguration;
        private RegistryAuthorizerType _authorizerType;
        private string _clientToken;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property ApprovalConfiguration. 
        /// <para>
        /// The approval configuration for registry records. Controls whether records require
        /// explicit approval before becoming active. See the <c>ApprovalConfiguration</c> data
        /// type for supported configuration options.
        /// </para>
        /// </summary>
        public ApprovalConfiguration ApprovalConfiguration
        {
            get { return this._approvalConfiguration; }
            set { this._approvalConfiguration = value; }
        }

        // Check to see if ApprovalConfiguration property is set
        internal bool IsSetApprovalConfiguration()
        {
            return this._approvalConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The authorizer configuration for the registry. Required if <c>authorizerType</c> is
        /// <c>CUSTOM_JWT</c>. For details, see the <c>AuthorizerConfiguration</c> data type.
        /// </para>
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration
        {
            get { return this._authorizerConfiguration; }
            set { this._authorizerConfiguration = value; }
        }

        // Check to see if AuthorizerConfiguration property is set
        internal bool IsSetAuthorizerConfiguration()
        {
            return this._authorizerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerType. 
        /// <para>
        /// The type of authorizer to use for the registry. This controls the authorization method
        /// for the Search and Invoke APIs used by consumers, and does not affect the standard
        /// CRUDL APIs for registry and registry record management used by administrators.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CUSTOM_JWT</c> - Authorize with a bearer token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_IAM</c> - Authorize with your Amazon Web Services IAM credentials.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RegistryAuthorizerType AuthorizerType
        {
            get { return this._authorizerType; }
            set { this._authorizerType = value; }
        }

        // Check to see if AuthorizerType property is set
        internal bool IsSetAuthorizerType()
        {
            return this._authorizerType != null;
        }

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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the registry.
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
        /// The name of the registry. The name must be unique within your account and can contain
        /// alphanumeric characters and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}