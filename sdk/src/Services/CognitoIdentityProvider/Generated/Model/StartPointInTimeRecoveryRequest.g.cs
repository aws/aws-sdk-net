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
    /// Container for the parameters to the StartPointInTimeRecovery operation. Applies a
    /// point-in-time recovery to a user pool. Before you start a recovery, review the recovery
    /// preview in the response to a request. You can start a recovery when its status is
    /// <c>PREVIEW_GENERATED</c>. <para> When you start a recovery, Amazon Cognito sets its
    /// status to <c>RESTORING</c> and restores user data in the user pool to its state at
    /// the recovery point. Write operations in the user pool remain paused until the recovery
    /// is complete. Sign-in and read operations continue to work. When the status of the
    /// recovery changes to <c>RESTORE_COMPLETED</c>, Amazon Cognito resumes write operations.
    /// </para> <para> You can't cancel a recovery after you start it. </para> <note> <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para> <para> <b>Learn more</b> </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> </para> </li> </ul>
    /// </note>
    /// </summary>
    public partial class StartPointInTimeRecoveryRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property RestoreId. 
        /// <para>
        /// The ID of the recovery that you want to start. Amazon Cognito returns this ID in the
        /// response to an <c>InitiatePointInTimeRecovery</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string RestoreId { get; set; }

        /// <summary>
        /// Checks to see if the RestoreId property is set.
        /// </summary>
        internal bool IsSetRestoreId() => this.RestoreId != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the recovery that you want to start.
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
