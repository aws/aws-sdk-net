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
    /// Container for the parameters to the CreateActionConnector operation. Creates an action
    /// connector that enables Amazon Quick Sight to connect to external services and perform
    /// actions. Action connectors support various authentication methods and can be configured
    /// with specific actions from supported connector types like Amazon S3, Salesforce, JIRA.
    /// </summary>
    public partial class CreateActionConnectorRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property ActionConnectorId. 
        /// <para>
        /// A unique identifier for the action connector. This ID must be unique within the Amazon
        /// Web Services account. The <c>ActionConnectorId</c> must not start with the prefix
        /// <c>quicksuite-</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ActionConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ActionConnectorId property is set.
        /// </summary>
        internal bool IsSetActionConnectorId() => this.ActionConnectorId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationConfig. 
        /// <para>
        /// The authentication configuration for connecting to the external service. This includes
        /// the authentication type, base URL, and authentication metadata such as client credentials
        /// or API keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthConfig AuthenticationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfig property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfig() => this.AuthenticationConfig != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions configuration that defines which users, groups, or namespaces can
        /// access this action connector and what operations they can perform.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public List<ResourcePermission> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to apply to the action connector for resource management and organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionConnectorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionArn. 
        /// <para>
        /// The ARN of the VPC connection to use for secure connectivity to the external service.
        /// </para>
        /// </summary>
        public string VpcConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionArn property is set.
        /// </summary>
        internal bool IsSetVpcConnectionArn() => this.VpcConnectionArn != null;
    }
}
