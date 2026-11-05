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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDelegationRequest operation. Creates an
    /// IAM delegation request for temporary access delegation. <para> This API is not available
    /// for general use. In order to use this API, a caller first need to go through an onboarding
    /// process described in the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies-temporary-delegation-partner-guide.html">partner
    /// onboarding documentation</a>. </para>
    /// </summary>
    public partial class CreateDelegationRequestRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property NotificationChannel. 
        /// <para>
        /// The notification channel for updates about the delegation request.
        /// </para>
        ///  
        /// <para>
        /// At this time,only SNS topic ARNs are accepted for notification. This topic ARN must
        /// have a resource policy granting <c>SNS:Publish</c> permission to the IAM service principal
        /// (<c>iam.amazonaws.com</c>). See <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies-temporary-delegation-partner-guide.html">partner
        /// onboarding documentation</a> for more details. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 400)]
        public string NotificationChannel { get; set; }

        /// <summary>
        /// Checks to see if the NotificationChannel property is set.
        /// </summary>
        internal bool IsSetNotificationChannel() => this.NotificationChannel != null;

        /// <summary>
        /// Gets and sets the property OnlySendByOwner. 
        /// <para>
        /// Specifies whether the delegation token should only be sent by the owner.
        /// </para>
        ///  
        /// <para>
        /// This flag prevents any party other than the owner from calling <c>SendDelegationToken</c>
        /// API for this delegation request. This behavior becomes useful when the delegation
        /// request owner needs to be present for subsequent partner interactions, but the delegation
        /// request was sent to a more privileged user for approval due to the owner lacking sufficient
        /// delegation permissions. 
        /// </para>
        /// </summary>
        public bool? OnlySendByOwner { get; set; }

        /// <summary>
        /// Checks to see if the OnlySendByOwner property is set.
        /// </summary>
        internal bool IsSetOnlySendByOwner() => this.OnlySendByOwner.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID this delegation request is targeted to.
        /// </para>
        ///  
        /// <para>
        /// If the account ID is not known, this parameter can be omitted, resulting in a request
        /// that can be associated by any account. If the account ID passed, then the created
        /// delegation request can only be associated with an identity of that target account.
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions to be delegated in this delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DelegationPermission Permissions { get; set; }

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null;

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// The URL to redirect to after the delegation request is processed.
        /// </para>
        ///  
        /// <para>
        /// This URL is used by the IAM console to show a link to the customer to re-load the
        /// partner workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUrl property is set.
        /// </summary>
        internal bool IsSetRedirectUrl() => this.RedirectUrl != null;

        /// <summary>
        /// Gets and sets the property RequestMessage. 
        /// <para>
        /// A message explaining the reason for the delegation request.
        /// </para>
        ///  
        /// <para>
        /// Requesters can utilize this field to add a custom note to the delegation request.
        /// This field is different from the description such that this is to be utilized for
        /// a custom messaging on a case-by-case basis.
        /// </para>
        ///  
        /// <para>
        /// For example, if the current delegation request is in response to a previous request
        /// being rejected, this explanation can be added to the request via this field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Checks to see if the RequestMessage property is set.
        /// </summary>
        internal bool IsSetRequestMessage() => this.RequestMessage != null;

        /// <summary>
        /// Gets and sets the property RequestorWorkflowId. 
        /// <para>
        /// The workflow ID associated with the requestor.
        /// </para>
        ///  
        /// <para>
        /// This is the unique identifier on the partner side that can be used to track the progress
        /// of the request.
        /// </para>
        ///  
        /// <para>
        /// IAM maintains a uniqueness check on this workflow id for each request - if a workflow
        /// id for an existing request is passed, this API call will fail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 400)]
        public string RequestorWorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the RequestorWorkflowId property is set.
        /// </summary>
        internal bool IsSetRequestorWorkflowId() => this.RequestorWorkflowId != null;

        /// <summary>
        /// Gets and sets the property SessionDuration. 
        /// <para>
        /// The duration for which the delegated session should remain active, in seconds.
        /// </para>
        ///  
        /// <para>
        /// The active time window for the session starts when the customer calls the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SendDelegationToken.html">SendDelegationToken</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 300, Max = 43200)]
        public int? SessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the SessionDuration property is set.
        /// </summary>
        internal bool IsSetSessionDuration() => this.SessionDuration.HasValue;
    }
}
