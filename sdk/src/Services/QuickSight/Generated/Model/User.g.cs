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
    /// A registered user of Quick Sight.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// The active status of user. When you create an Quick Sight user that's not an IAM user
        /// or an Active Directory user, that user is inactive until they sign in and provide
        /// a password.
        /// </para>
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the user.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CustomPermissionsName. 
        /// <para>
        /// The custom permissions profile associated with this user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CustomPermissionsName { get; set; }

        /// <summary>
        /// Checks to see if the CustomPermissionsName property is set.
        /// </summary>
        internal bool IsSetCustomPermissionsName() => this.CustomPermissionsName != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The user's email address.
        /// </para>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property ExternalLoginFederationProviderType. 
        /// <para>
        /// The type of supported external login provider that provides identity to let the user
        /// federate into Quick Sight with an associated IAM role. The type can be one of the
        /// following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COGNITO</c>: Amazon Cognito. The provider URL is cognito-identity.amazonaws.com.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM_OIDC</c>: Custom OpenID Connect (OIDC) provider.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ExternalLoginFederationProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ExternalLoginFederationProviderType property is set.
        /// </summary>
        internal bool IsSetExternalLoginFederationProviderType() => this.ExternalLoginFederationProviderType != null;

        /// <summary>
        /// Gets and sets the property ExternalLoginFederationProviderUrl. 
        /// <para>
        /// The URL of the external login provider.
        /// </para>
        /// </summary>
        public string ExternalLoginFederationProviderUrl { get; set; }

        /// <summary>
        /// Checks to see if the ExternalLoginFederationProviderUrl property is set.
        /// </summary>
        internal bool IsSetExternalLoginFederationProviderUrl() => this.ExternalLoginFederationProviderUrl != null;

        /// <summary>
        /// Gets and sets the property ExternalLoginId. 
        /// <para>
        /// The identity ID for the user in the external login provider.
        /// </para>
        /// </summary>
        public string ExternalLoginId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalLoginId property is set.
        /// </summary>
        internal bool IsSetExternalLoginId() => this.ExternalLoginId != null;

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The type of identity authentication used by the user.
        /// </para>
        /// </summary>
        public IdentityType IdentityType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityType property is set.
        /// </summary>
        internal bool IsSetIdentityType() => this.IdentityType != null;

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The principal ID of the user.
        /// </para>
        /// </summary>
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Quick Sight role for the user. The user role can be one of the following:.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READER</c>: A user who has read-only access to dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTHOR</c>: A user who can create data sources, datasets, analyses, and dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADMIN</c>: A user who is an author, who can also manage Amazon Quick Sight settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READER_PRO</c>: Reader Pro adds Generative BI capabilities to the Reader role.
        /// Reader Pros have access to Amazon Q in Quick Sight, can build stories with Amazon
        /// Q, and can generate executive summaries from dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTHOR_PRO</c>: Author Pro adds Generative BI capabilities to the Author role.
        /// Author Pros can author dashboards with natural language with Amazon Q, build stories
        /// with Amazon Q, create Topics for Q&amp;A, and generate executive summaries from dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADMIN_PRO</c>: Admin Pros are Author Pros who can also manage Quick Sight administrative
        /// settings. Admin Pro users are billed at Author Pro pricing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESTRICTED_READER</c>: This role isn't currently available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESTRICTED_AUTHOR</c>: This role isn't currently available for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user's user name. This value is required if you are registering a user that will
        /// be managed in Quick Sight. In the output, the value for <c>UserName</c> is <c>N/A</c>
        /// when the value for <c>IdentityType</c> is <c>IAM</c> and the corresponding IAM user
        /// is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
