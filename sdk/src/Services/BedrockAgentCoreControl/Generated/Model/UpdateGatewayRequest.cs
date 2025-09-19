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
    /// Container for the parameters to the UpdateGateway operation.
    /// Updates an existing gateway.
    /// </summary>
    public partial class UpdateGatewayRequest : AmazonBedrockAgentCoreControlRequest
    {
        private AuthorizerConfiguration _authorizerConfiguration;
        private AuthorizerType _authorizerType;
        private string _description;
        private ExceptionLevel _exceptionLevel;
        private string _gatewayIdentifier;
        private string _kmsKeyArn;
        private string _name;
        private GatewayProtocolConfiguration _protocolConfiguration;
        private GatewayProtocolType _protocolType;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The updated authorizer configuration for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The updated authorizer type for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthorizerType AuthorizerType
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
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
        /// Gets and sets the property ExceptionLevel. 
        /// <para>
        /// The level of detail in error messages returned when invoking the gateway.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <c>DEBUG</c>, granular exception messages are returned to help a user
        /// debug the gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is omitted, a generic error message is returned to the end user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExceptionLevel ExceptionLevel
        {
            get { return this._exceptionLevel; }
            set { this._exceptionLevel = value; }
        }

        // Check to see if ExceptionLevel property is set
        internal bool IsSetExceptionLevel()
        {
            return this._exceptionLevel != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayIdentifier. 
        /// <para>
        /// The identifier of the gateway to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayIdentifier
        {
            get { return this._gatewayIdentifier; }
            set { this._gatewayIdentifier = value; }
        }

        // Check to see if GatewayIdentifier property is set
        internal bool IsSetGatewayIdentifier()
        {
            return this._gatewayIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The updated ARN of the KMS key used to encrypt the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the gateway. This name must be the same as the one when the gateway was
        /// created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property ProtocolConfiguration.
        /// </summary>
        public GatewayProtocolConfiguration ProtocolConfiguration
        {
            get { return this._protocolConfiguration; }
            set { this._protocolConfiguration = value; }
        }

        // Check to see if ProtocolConfiguration property is set
        internal bool IsSetProtocolConfiguration()
        {
            return this._protocolConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The updated protocol type for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayProtocolType ProtocolType
        {
            get { return this._protocolType; }
            set { this._protocolType = value; }
        }

        // Check to see if ProtocolType property is set
        internal bool IsSetProtocolType()
        {
            return this._protocolType != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The updated IAM role ARN that provides permissions for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}