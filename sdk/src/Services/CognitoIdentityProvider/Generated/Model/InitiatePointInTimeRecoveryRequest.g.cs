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
    /// Container for the parameters to the InitiatePointInTimeRecovery operation. Initiates
    /// a point-in-time recovery of a user pool to a time in the past that you specify. This
    /// operation is the first step of a recovery and doesn't change your user pool data.
    /// Amazon Cognito pauses write operations in the user pool and generates a recovery preview
    /// when capacity is available in the Amazon Web Services Region, so the preview might
    /// not be available immediately. The preview shows the number of entities that the recovery
    /// creates, updates, and deletes. To check the status of the recovery and review the
    /// preview, make a request. When the status is <c>PREVIEW_GENERATED</c>, apply the recovery
    /// with a request or discard it with a request. The time that it takes to generate the
    /// recovery preview doesn't depend on the size of your user pool. <important> <para>
    /// Point-in-time recovery is a disaster recovery feature. Use it to recover from accidental
    /// or unauthorized changes that affect your user data, for example the deletion or corruption
    /// of many users. Don't use point-in-time recovery to remove users that were created
    /// recently or to revert changes to individual users. To delete or update individual
    /// users, use operations like and . </para> </important> <para> While a recovery is in
    /// progress, Amazon Cognito blocks operations that write to the user pool, for example
    /// user sign-up, user creation, and attribute updates. Sign-in and read operations continue
    /// to work, with the following exceptions. </para> <ul> <li> <para> Users who must set
    /// a new password, set up MFA, or respond to a TOTP MFA challenge can't complete sign-in.
    /// Sign-in with the <c>NEW_PASSWORD_REQUIRED</c>, <c>MFA_SETUP</c>, and <c>SOFTWARE_TOKEN_MFA</c>
    /// challenges fails until the recovery ends. </para> </li> <li> <para> Federated users
    /// can sign in only if they have previously signed in to the user pool and their attributes
    /// from the external identity provider haven't changed. </para> </li> <li> <para> You
    /// can't create or start user import jobs. Start your import jobs after the recovery
    /// ends. </para> </li> </ul> <para> If you don't start or cancel the recovery within
    /// 24 hours after you initiate it, the recovery preview expires. Amazon Cognito then
    /// resumes write operations and doesn't change your user pool data. The 24-hour period
    /// includes the time that Amazon Cognito waits for available capacity. </para> <para>
    /// A point-in-time recovery restores user data, including user profiles and attributes,
    /// group memberships, passwords, MFA settings, and passkeys. It doesn't restore user
    /// pool configuration, for example app clients, the attribute schema, encryption settings,
    /// or multi-Region replication settings. Users who changed their password after the recovery
    /// point keep their current password. </para> <para> The following requirements and limits
    /// apply to point-in-time recovery. </para> <ul> <li> <para> Your user pool must be on
    /// the Essentials or Plus <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-sign-in-feature-plans.html">feature
    /// plan</a>. With the Essentials feature plan, you can recover your user pool to a point
    /// in time up to 1 day in the past. With the Plus feature plan, you can recover up to
    /// 14 days in the past. Your user pool must have been on the required feature plan at
    /// the recovery point. For example, to recover to a point in time 14 days ago, your user
    /// pool must have been on the Plus feature plan for the past 14 days. </para> </li> <li>
    /// <para> The recovery point must be at least 15 minutes in the past and can't be earlier
    /// than the creation time of the user pool. </para> </li> <li> <para> A user pool can
    /// have only one active recovery at a time. </para> </li> <li> <para> An Amazon Web Services
    /// account can have up to five active recoveries at a time across all of its user pools.
    /// An organization in Amazon Web Services Organizations can have up to ten active recoveries
    /// at a time across all of its accounts. </para> </li> <li> <para> You can complete one
    /// recovery of a user pool in a 24-hour period. </para> </li> <li> <para> You can create
    /// up to three recovery previews of a user pool, ten recovery previews in an Amazon Web
    /// Services account, and 15 recovery previews in an organization in Amazon Web Services
    /// Organizations in a 24-hour period. You can create up to ten recovery previews of a
    /// user pool in a 30-day period. </para> </li> <li> <para> You can't initiate a recovery
    /// while a user import job is in progress in your user pool. Wait for the import job
    /// to complete, or stop it with a request, and then initiate the recovery. </para> </li>
    /// <li> <para> In a user pool with multi-Region replication, you can initiate a recovery
    /// only in the primary Amazon Web Services Region, and only after replication is complete.
    /// </para> </li> <li> <para> If your user pool uses a customer managed key in KMS for
    /// encryption, the key must remain enabled and accessible to Amazon Cognito for the duration
    /// of the recovery. </para> </li> <li> <para> Some user pools don't support point-in-time
    /// recovery, for example some older user pools and user pools that contain user data
    /// with characters or formats that point-in-time recovery doesn't support. If your user
    /// pool doesn't support it, Amazon Cognito returns an error when you initiate a recovery.
    /// To get help with this limitation, contact Amazon Web Services Support. </para> </li>
    /// </ul> <note> <para> Amazon Cognito evaluates Identity and Access Management (IAM)
    /// policies in requests for this API operation. For this operation, you must use IAM
    /// credentials to authorize requests, and you must grant yourself the corresponding IAM
    /// permission in a policy. </para> <para> <b>Learn more</b> </para> <ul> <li> <para>
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> </para> </li> </ul>
    /// </note>
    /// </summary>
    public partial class InitiatePointInTimeRecoveryRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property RestoreTimestamp. 
        /// <para>
        /// The point in time that you want to recover your user pool to. Amazon Cognito reverts
        /// changes to user data that occurred after this time. The recovery point must be at
        /// least 15 minutes in the past and within the recovery period of your user pool feature
        /// plan: up to 1 day in the past with the Essentials feature plan, or up to 14 days in
        /// the past with the Plus feature plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? RestoreTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTimestamp property is set.
        /// </summary>
        internal bool IsSetRestoreTimestamp() => this.RestoreTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that you want to recover.
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
