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
    /// This is the response object from the UpdateRegistry operation.
    /// </summary>
    public partial class UpdateRegistryResponse : AmazonWebServiceResponse
    {
        private ApprovalConfiguration _approvalConfiguration;
        private AuthorizerConfiguration _authorizerConfiguration;
        private RegistryAuthorizerType _authorizerType;
        private DateTime? _createdAt;
        private string _description;
        private string _name;
        private string _registryArn;
        private string _registryId;
        private RegistryStatus _status;
        private string _statusReason;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApprovalConfiguration. 
        /// <para>
        /// The approval configuration for the updated registry. For details, see the <c>ApprovalConfiguration</c>
        /// data type.
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
        /// The authorizer configuration for the updated registry. For details, see the <c>AuthorizerConfiguration</c>
        /// data type.
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
        /// The type of authorizer used by the updated registry. This controls the authorization
        /// method for the Search and Invoke APIs used by consumers.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the registry was created.
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
        /// The description of the updated registry.
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
        /// The name of the updated registry.
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

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistryArn
        {
            get { return this._registryArn; }
            set { this._registryArn = value; }
        }

        // Check to see if RegistryArn property is set
        internal bool IsSetRegistryArn()
        {
            return this._registryArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The unique identifier of the updated registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=16)]
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the updated registry. Possible values include <c>CREATING</c>,
        /// <c>READY</c>, <c>UPDATING</c>, <c>CREATE_FAILED</c>, <c>UPDATE_FAILED</c>, <c>DELETING</c>,
        /// and <c>DELETE_FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistryStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the updated registry.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the registry was last updated.
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

    }
}