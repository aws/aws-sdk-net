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
    /// Container for the parameters to the CreateCIMDPolicy operation. Creates a Client ID
    /// Metadata Document (CIMD) policy for an app client. A CIMD policy lets OAuth clients
    /// identify themselves to your user pool with an HTTPS URL as their client ID. Amazon
    /// Cognito retrieves the client metadata document from that URL and accepts the client
    /// only when the URL matches one of the URL patterns in the policy. <note> <para> Amazon
    /// Cognito evaluates Identity and Access Management (IAM) policies in requests for this
    /// API operation. For this operation, you must use IAM credentials to authorize requests,
    /// and you must grant yourself the corresponding IAM permission in a policy. </para>
    /// <para> <b>Learn more</b> </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> </para> </li> </ul>
    /// </note>
    /// </summary>
    public partial class CreateCIMDPolicyRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property CacheDuration. 
        /// <para>
        /// The length of time, in seconds, that Amazon Cognito caches a client metadata document
        /// that it retrieved from a URL that matches the policy. The value must be between 86,400
        /// seconds (one day) and 31,556,952 seconds (one year).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 86400, Max = 31556952)]
        public int? CacheDuration { get; set; }

        /// <summary>
        /// Checks to see if the CacheDuration property is set.
        /// </summary>
        internal bool IsSetCacheDuration() => this.CacheDuration.HasValue;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that you want to associate with the CIMD policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// A friendly name for the CIMD policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property URLPatterns. 
        /// <para>
        /// One to five HTTPS URL patterns. Amazon Cognito accepts a client ID metadata document
        /// URL only when it matches one of these patterns. Patterns can contain the <c>*</c>
        /// wildcard character.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<string> URLPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the URLPatterns property is set.
        /// </summary>
        internal bool IsSetURLPatterns() => this.URLPatterns != null && (this.URLPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to create the CIMD policy.
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
