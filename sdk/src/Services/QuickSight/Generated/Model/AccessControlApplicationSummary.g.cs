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
    /// A summary of an access control application, including its ID, ARN, name, namespace,
    /// authentication type, status, and timestamps.
    /// </summary>
    public partial class AccessControlApplicationSummary
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication protocol that the access control application uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessControlApplicationAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time when the access control application was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IdpAuthorizingConfiguration. 
        /// <para>
        /// A summary of the identity provider configuration of the access control application,
        /// without client secret information.
        /// </para>
        /// </summary>
        public IdpAuthorizingConfigSummary IdpAuthorizingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdpAuthorizingConfiguration property is set.
        /// </summary>
        internal bool IsSetIdpAuthorizingConfiguration() => this.IdpAuthorizingConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the access control application was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Quick Sight namespace that the access control application belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property QuickAuthenticationConfiguration. 
        /// <para>
        /// The Quick Sight authentication configuration of the access control application. Client
        /// secret values are never included.
        /// </para>
        /// </summary>
        public QuickAuthenticationConfig QuickAuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QuickAuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetQuickAuthenticationConfiguration() => this.QuickAuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessControlApplicationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TenantUrl. 
        /// <para>
        /// The tenant URL of the access control application. This URL hosts the OAuth 2.0 and
        /// OpenID Connect endpoints for the application, such as <c>/authorize</c>, <c>/token</c>,
        /// <c>/.well-known/openid-configuration</c>, and <c>/jwks</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TenantUrl { get; set; }

        /// <summary>
        /// Checks to see if the TenantUrl property is set.
        /// </summary>
        internal bool IsSetTenantUrl() => this.TenantUrl != null;
    }
}
