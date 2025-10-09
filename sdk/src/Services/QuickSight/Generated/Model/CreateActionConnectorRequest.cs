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
    /// Container for the parameters to the CreateActionConnector operation.
    /// Creates an action connector that enables Amazon Quick Sight to connect to external
    /// services and perform actions. Action connectors support various authentication methods
    /// and can be configured with specific actions from supported connector types like Amazon
    /// S3, Salesforce, JIRA.
    /// </summary>
    public partial class CreateActionConnectorRequest : AmazonQuickSightRequest
    {
        private string _actionConnectorId;
        private AuthConfig _authenticationConfig;
        private string _awsAccountId;
        private string _description;
        private string _name;
        private List<ResourcePermission> _permissions = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ActionConnectorType _type;
        private string _vpcConnectionArn;

        /// <summary>
        /// Gets and sets the property ActionConnectorId. 
        /// <para>
        /// A unique identifier for the action connector. This ID must be unique within the Amazon
        /// Web Services account. The <c>ActionConnectorId</c> must not start with the prefix
        /// <c>quicksuite-</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ActionConnectorId
        {
            get { return this._actionConnectorId; }
            set { this._actionConnectorId = value; }
        }

        // Check to see if ActionConnectorId property is set
        internal bool IsSetActionConnectorId()
        {
            return this._actionConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationConfig. 
        /// <para>
        /// The authentication configuration for connecting to the external service. This includes
        /// the authentication type, base URL, and authentication metadata such as client credentials
        /// or API keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthConfig AuthenticationConfig
        {
            get { return this._authenticationConfig; }
            set { this._authenticationConfig = value; }
        }

        // Check to see if AuthenticationConfig property is set
        internal bool IsSetAuthenticationConfig()
        {
            return this._authenticationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
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
        /// A descriptive name for the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions configuration that defines which users, groups, or namespaces can
        /// access this action connector and what operations they can perform.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to apply to the action connector for resource management and organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionConnectorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionArn. 
        /// <para>
        /// The ARN of the VPC connection to use for secure connectivity to the external service.
        /// </para>
        /// </summary>
        public string VpcConnectionArn
        {
            get { return this._vpcConnectionArn; }
            set { this._vpcConnectionArn = value; }
        }

        // Check to see if VpcConnectionArn property is set
        internal bool IsSetVpcConnectionArn()
        {
            return this._vpcConnectionArn != null;
        }

    }
}