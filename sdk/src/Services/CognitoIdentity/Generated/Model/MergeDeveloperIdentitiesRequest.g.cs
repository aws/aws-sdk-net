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
    /// Container for the parameters to the MergeDeveloperIdentities operation. Merges two
    /// users having different <c>IdentityId</c>s, existing in the same identity pool, and
    /// identified by the same developer provider. You can use this action to request that
    /// discrete users be merged and identified as a single user in the Cognito environment.
    /// Cognito associates the given source user (<c>SourceUserIdentifier</c>) with the <c>IdentityId</c>
    /// of the <c>DestinationUserIdentifier</c>. Only developer-authenticated users can be
    /// merged. If the users to be merged are associated with the same public provider, but
    /// as two different users, an exception will be thrown. <para> The number of linked logins
    /// is limited to 20. So, the number of linked logins for the source user, <c>SourceUserIdentifier</c>,
    /// and the destination user, <c>DestinationUserIdentifier</c>, together should not be
    /// larger than 20. Otherwise, an exception will be thrown. </para> <para> You must use
    /// Amazon Web Services developer credentials to call this operation. </para>
    /// </summary>
    public partial class MergeDeveloperIdentitiesRequest : AmazonCognitoIdentityRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationUserIdentifier. 
        /// <para>
        /// User identifier for the destination user. The value should be a <c>DeveloperUserIdentifier</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DestinationUserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DestinationUserIdentifier property is set.
        /// </summary>
        internal bool IsSetDestinationUserIdentifier() => this.DestinationUserIdentifier != null;

        /// <summary>
        /// Gets and sets the property DeveloperProviderName. 
        /// <para>
        /// The "domain" by which Cognito will refer to your users. This is a (pseudo) domain
        /// name that you provide while creating an identity pool. This name acts as a placeholder
        /// that allows your backend and the Cognito service to communicate about the developer
        /// provider. For the <c>DeveloperProviderName</c>, you can use letters as well as period
        /// (.), underscore (_), and dash (-).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DeveloperProviderName { get; set; }

        /// <summary>
        /// Checks to see if the DeveloperProviderName property is set.
        /// </summary>
        internal bool IsSetDeveloperProviderName() => this.DeveloperProviderName != null;

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

        /// <summary>
        /// Gets and sets the property SourceUserIdentifier. 
        /// <para>
        /// User identifier for the source user. The value should be a <c>DeveloperUserIdentifier</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string SourceUserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceUserIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceUserIdentifier() => this.SourceUserIdentifier != null;
    }
}
