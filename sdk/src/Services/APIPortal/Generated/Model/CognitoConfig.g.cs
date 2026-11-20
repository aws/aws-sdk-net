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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// The Amazon Cognito resources readers use to sign in to a portal.
    /// </summary>
    public partial class CognitoConfig
    {
        /// <summary>
        /// Gets and sets the property AppClientId. The ID of the user pool app client the portal
        /// uses.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AppClientId { get; set; }

        /// <summary>
        /// Checks to see if the AppClientId property is set.
        /// </summary>
        internal bool IsSetAppClientId() => this.AppClientId != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. The ID of the Cognito identity pool. Required
        /// only for fine-grained access control.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property UserPoolArn. The ARN of the Cognito user pool.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string UserPoolArn { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolArn property is set.
        /// </summary>
        internal bool IsSetUserPoolArn() => this.UserPoolArn != null;

        /// <summary>
        /// Gets and sets the property UserPoolDomain. The domain of the user pool's hosted sign-in
        /// pages.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string UserPoolDomain { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolDomain property is set.
        /// </summary>
        internal bool IsSetUserPoolDomain() => this.UserPoolDomain != null;
    }
}
