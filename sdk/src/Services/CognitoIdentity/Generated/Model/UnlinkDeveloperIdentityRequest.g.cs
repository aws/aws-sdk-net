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

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the UnlinkDeveloperIdentity operation. Unlinks a <c>DeveloperUserIdentifier</c>
    /// from an existing identity. Unlinked developer users will be considered new identities
    /// next time they are seen. If, for a given Cognito identity, you remove all federated
    /// identities as well as the developer user identifier, the Cognito identity becomes
    /// inaccessible. <para> You must use Amazon Web Services developer credentials to call
    /// this operation. </para>
    /// </summary>
    public partial class UnlinkDeveloperIdentityRequest : AmazonCognitoIdentityRequest
    {
        /// <summary>
        /// Gets and sets the property DeveloperProviderName. 
        /// <para>
        /// The "domain" by which Cognito will refer to your users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DeveloperProviderName { get; set; }

        /// <summary>
        /// Checks to see if the DeveloperProviderName property is set.
        /// </summary>
        internal bool IsSetDeveloperProviderName() => this.DeveloperProviderName != null;

        /// <summary>
        /// Gets and sets the property DeveloperUserIdentifier. 
        /// <para>
        /// A unique ID used by your backend authentication process to identify a user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DeveloperUserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DeveloperUserIdentifier property is set.
        /// </summary>
        internal bool IsSetDeveloperUserIdentifier() => this.DeveloperUserIdentifier != null;

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// A unique identifier in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string IdentityId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityId property is set.
        /// </summary>
        internal bool IsSetIdentityId() => this.IdentityId != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;
    }
}
