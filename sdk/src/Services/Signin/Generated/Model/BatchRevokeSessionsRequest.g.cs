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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// Container for the parameters to the BatchRevokeSessions operation. Revokes up to five
    /// sign-in sessions. A revoked session can no longer be refreshed. Revoking a session
    /// that is already revoked succeeds. Each session must belong to the identity specified
    /// by principalArn, or to the caller if principalArn is omitted. Failures for individual
    /// sessions are returned in the errors list and do not fail the whole request.
    /// </summary>
    public partial class BatchRevokeSessionsRequest : AmazonSigninRequest
    {
        /// <summary>
        /// Gets and sets the property PrincipalArn. The identity that owns the sessions. Omit
        /// to use the caller. Specify arn:aws:iam::{account-id}:* to revoke any session in the
        /// account.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;

        /// <summary>
        /// Gets and sets the property Reason. The reason for revoking the sessions
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property SessionArns. The ARNs of the sessions to revoke
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<string> SessionArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SessionArns property is set.
        /// </summary>
        internal bool IsSetSessionArns() => this.SessionArns != null && (this.SessionArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
