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
    /// This is the response object from the GetGateway operation.
    /// </summary>
    public partial class GetGatewayResponse : AmazonWebServiceResponse
    {
        private AuthorizerConfiguration _authorizerConfiguration;
        private AuthorizerType _authorizerType;
        private DateTime? _createdAt;
        private string _description;
        private ExceptionLevel _exceptionLevel;
        private string _gatewayArn;
        private string _gatewayId;
        private string _gatewayUrl;
        private string _kmsKeyArn;
        private string _name;
        private GatewayProtocolConfiguration _protocolConfiguration;
        private GatewayProtocolType _protocolType;
        private string _roleArn;
        private GatewayStatus _status;
        private List<string> _statusReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _updatedAt;
        private WorkloadIdentityDetails _workloadIdentityDetails;

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The authorizer configuration for the gateway.
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
        /// Authorizer type for the gateway.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the gateway was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the gateway.
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
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayUrl. 
        /// <para>
        /// An endpoint for invoking gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GatewayUrl
        {
            get { return this._gatewayUrl; }
            set { this._gatewayUrl = value; }
        }

        // Check to see if GatewayUrl property is set
        internal bool IsSetGatewayUrl()
        {
            return this._gatewayUrl != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the gateway.
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
        /// The name of the gateway.
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
        /// Protocol applied to a gateway.
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
        /// The IAM role ARN that provides permissions for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// The reasons for the current status of the gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> StatusReasons
        {
            get { return this._statusReasons; }
            set { this._statusReasons = value; }
        }

        // Check to see if StatusReasons property is set
        internal bool IsSetStatusReasons()
        {
            return this._statusReasons != null && (this._statusReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the gateway was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkloadIdentityDetails. 
        /// <para>
        /// The workload identity details for the gateway.
        /// </para>
        /// </summary>
        public WorkloadIdentityDetails WorkloadIdentityDetails
        {
            get { return this._workloadIdentityDetails; }
            set { this._workloadIdentityDetails = value; }
        }

        // Check to see if WorkloadIdentityDetails property is set
        internal bool IsSetWorkloadIdentityDetails()
        {
            return this._workloadIdentityDetails != null;
        }

    }
}