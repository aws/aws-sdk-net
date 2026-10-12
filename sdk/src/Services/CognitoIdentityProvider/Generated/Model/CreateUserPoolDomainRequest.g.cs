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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUserPoolDomain operation. A user pool domain
    /// hosts managed login, an authorization server and web server for authentication in
    /// your application. This operation creates a new user pool prefix domain or custom domain
    /// and sets the managed login branding version. Set the branding version to <c>1</c>
    /// for hosted UI (classic) or <c>2</c> for managed login. When you choose a custom domain,
    /// you must provide an SSL certificate in the US East (N. Virginia) Amazon Web Services
    /// Region in your request. <para> Your prefix domain might take up to one minute to take
    /// effect. Your custom domain is online within five minutes, but it can take up to one
    /// hour to distribute your SSL certificate. </para> <para> For more information about
    /// adding a custom domain to your user pool, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">Configuring
    /// a user pool domain</a>. </para> <note> <para> Amazon Cognito evaluates Identity and
    /// Access Management (IAM) policies in requests for this API operation. For this operation,
    /// you must use IAM credentials to authorize requests, and you must grant yourself the
    /// corresponding IAM permission in a policy. </para> <para> <b>Learn more</b> </para>
    /// <ul> <li> <para> <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> </para> </li> </ul>
    /// </note>
    /// </summary>
    public partial class CreateUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property CustomDomainConfig. 
        /// <para>
        /// The configuration for a custom domain. Configures your domain with an Certificate
        /// Manager certificate in the <c>us-east-1</c> Region.
        /// </para>
        ///  
        /// <para>
        /// Provide this parameter only if you want to use a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html">custom
        /// domain</a> for your user pool. Otherwise, you can omit this parameter and use a <a
        /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-assign-domain-prefix.html">prefix
        /// domain</a> instead.
        /// </para>
        ///  
        /// <para>
        /// When you create a custom domain, the passkey RP ID defaults to the custom domain.
        /// If you had a prefix domain active, this will cause passkey integration for your prefix
        /// domain to stop working due to a mismatch in RP ID. To keep the prefix domain passkey
        /// integration working, you can explicitly set RP ID to the prefix domain.
        /// </para>
        /// </summary>
        public CustomDomainConfigType CustomDomainConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainConfig property is set.
        /// </summary>
        internal bool IsSetCustomDomainConfig() => this.CustomDomainConfig != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain string. For custom domains, this is the fully-qualified domain name, such
        /// as <c>auth.example.com</c>. For prefix domains, this is the prefix alone, such as
        /// <c>myprefix</c>. A prefix value of <c>myprefix</c> for a user pool in the <c>us-east-1</c>
        /// Region results in a domain of <c>myprefix.auth.us-east-1.amazoncognito.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property ManagedLoginVersion. 
        /// <para>
        /// The version of managed login branding that you want to apply to your domain. A value
        /// of <c>1</c> indicates hosted UI (classic) and a version of <c>2</c> indicates managed
        /// login.
        /// </para>
        ///  
        /// <para>
        /// Managed login requires that your user pool be configured for any <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-sign-in-feature-plans.html">feature
        /// plan</a> other than <c>Lite</c>.
        /// </para>
        ///  
        /// <para>
        /// A <c>ManagedLoginVersion</c> value of <c>2</c> does not activate managed login pages
        /// for your app client. When you create an app client programmatically, your app client
        /// has no branding style. To use managed login, create a branding style using the <a
        /// href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateManagedLoginBranding.html">CreateManagedLoginBranding</a>
        /// operation. When you use the console, Amazon Cognito assigns a default branding style
        /// automatically. When you use the API or an SDK, you must create a branding style yourself.
        /// </para>
        /// </summary>
        public int? ManagedLoginVersion { get; set; }

        /// <summary>
        /// Checks to see if the ManagedLoginVersion property is set.
        /// </summary>
        internal bool IsSetManagedLoginVersion() => this.ManagedLoginVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Routing. 
        /// <para>
        /// The configuration of routing for requests to the domain for replicas of a replicated
        /// user pool. The routing configuration is currently only supported for custom domains.
        /// </para>
        /// </summary>
        public RoutingType Routing { get; set; }

        /// <summary>
        /// Checks to see if the Routing property is set.
        /// </summary>
        internal bool IsSetRouting() => this.Routing != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to add a domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
