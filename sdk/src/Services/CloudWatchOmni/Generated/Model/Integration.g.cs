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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// A connection between CloudWatch and an external system — such as a source of telemetry
    /// or configuration data, a messaging destination, or a model provider.
    /// </summary>
    public partial class Integration
    {
        /// <summary>
        /// Gets and sets the property AuthType.
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property AuthorizationUrl. The URL the customer visits to authorize
        /// the integration. Present while an OAuth authorization is pending.
        /// </summary>
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationUrl property is set.
        /// </summary>
        internal bool IsSetAuthorizationUrl() => this.AuthorizationUrl != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The time at which the integration was created.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialArn. The Amazon Resource Name (ARN) of the secret
        /// that stores the integration's credentials.
        /// </summary>
        public string CredentialArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialArn property is set.
        /// </summary>
        internal bool IsSetCredentialArn() => this.CredentialArn != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. A human-readable description of why the integration
        /// is in an ERROR or FAILED state. Present only when the integration has failed.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property IntegrationArn. The Amazon Resource Name (ARN) of the integration.
        /// </summary>
        public string IntegrationArn { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationArn property is set.
        /// </summary>
        internal bool IsSetIntegrationArn() => this.IntegrationArn != null;

        /// <summary>
        /// Gets and sets the property IntegrationAttributes. Provider-specific key/value attributes
        /// that configure the integration.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> IntegrationAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the IntegrationAttributes property is set.
        /// </summary>
        internal bool IsSetIntegrationAttributes() => this.IntegrationAttributes != null && (this.IntegrationAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegrationId. The unique identifier of the integration.
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property IntegrationType.
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;

        /// <summary>
        /// Gets and sets the property Name. The customer-provided name of the integration.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of the IAM role
        /// that CloudWatch assumes to access the external system.
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Scope. Whether this integration is account-scoped (ACCOUNT,
        /// customer-created) or organization-scoped (ORGANIZATION, created by an org-enablement
        /// rule). Absent on legacy records is treated as ACCOUNT.
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The time at which the integration was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
