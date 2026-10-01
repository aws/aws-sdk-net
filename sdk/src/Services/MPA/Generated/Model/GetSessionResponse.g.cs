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

namespace Amazon.MPA.Model
{
    /// <summary>
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionCompletionStrategy. 
        /// <para>
        /// Strategy for executing the protected operation. <c>AUTO_COMPLETION_UPON_APPROVAL</c>
        /// means the operation is automatically executed using the requester's permissions, if
        /// approved.
        /// </para>
        /// </summary>
        public ActionCompletionStrategy ActionCompletionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ActionCompletionStrategy property is set.
        /// </summary>
        internal bool IsSetActionCompletionStrategy() => this.ActionCompletionStrategy != null;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// Name of the protected operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 500)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property AdditionalSecurityRequirements. 
        /// <para>
        /// A list of <c>AdditionalSecurityRequirement</c> applied to the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> AdditionalSecurityRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalSecurityRequirements property is set.
        /// </summary>
        internal bool IsSetAdditionalSecurityRequirements() => this.AdditionalSecurityRequirements != null && (this.AdditionalSecurityRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApprovalStrategy. 
        /// <para>
        /// An <c>ApprovalStrategyResponse</c> object. Contains details for how the team grants
        /// approval
        /// </para>
        /// </summary>
        public ApprovalStrategyResponse ApprovalStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalStrategy property is set.
        /// </summary>
        internal bool IsSetApprovalStrategy() => this.ApprovalStrategy != null;

        /// <summary>
        /// Gets and sets the property ApprovalTeamArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the approval team.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ApprovalTeamArn { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalTeamArn property is set.
        /// </summary>
        internal bool IsSetApprovalTeamArn() => this.ApprovalTeamArn != null;

        /// <summary>
        /// Gets and sets the property ApprovalTeamName. 
        /// <para>
        /// Name of the approval team.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string ApprovalTeamName { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalTeamName property is set.
        /// </summary>
        internal bool IsSetApprovalTeamName() => this.ApprovalTeamName != null;

        /// <summary>
        /// Gets and sets the property ApproverResponses. 
        /// <para>
        /// An array of <c>GetSessionResponseApproverResponse</c> objects. Contains details for
        /// approver responses in the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<GetSessionResponseApproverResponse> ApproverResponses { get; set; } = AWSConfigs.InitializeCollections ? new List<GetSessionResponseApproverResponse>() : null;

        /// <summary>
        /// Checks to see if the ApproverResponses property is set.
        /// </summary>
        internal bool IsSetApproverResponses() => this.ApproverResponses != null && (this.ApproverResponses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// Timestamp when the session completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// Status for the protected operation. For example, if the operation is <c>PENDING</c>.
        /// </para>
        /// </summary>
        public SessionExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// Timestamp when the session will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property InitiationTime. 
        /// <para>
        /// Timestamp when the session was initiated.
        /// </para>
        /// </summary>
        public DateTime? InitiationTime { get; set; }

        /// <summary>
        /// Checks to see if the InitiationTime property is set.
        /// </summary>
        internal bool IsSetInitiationTime() => this.InitiationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata for the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfApprovers. 
        /// <para>
        /// Total number of approvers in the session.
        /// </para>
        /// </summary>
        public int? NumberOfApprovers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfApprovers property is set.
        /// </summary>
        internal bool IsSetNumberOfApprovers() => this.NumberOfApprovers.HasValue;

        /// <summary>
        /// Gets and sets the property ProtectedResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the protected operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string ProtectedResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ProtectedResourceArn property is set.
        /// </summary>
        internal bool IsSetProtectedResourceArn() => this.ProtectedResourceArn != null;

        /// <summary>
        /// Gets and sets the property RequesterAccountId. 
        /// <para>
        /// ID for the account that made the operation request.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 12)]
        public string RequesterAccountId { get; set; }

        /// <summary>
        /// Checks to see if the RequesterAccountId property is set.
        /// </summary>
        internal bool IsSetRequesterAccountId() => this.RequesterAccountId != null;

        /// <summary>
        /// Gets and sets the property RequesterComment. 
        /// <para>
        /// Message from the account that made the operation request
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 200)]
        public string RequesterComment { get; set; }

        /// <summary>
        /// Checks to see if the RequesterComment property is set.
        /// </summary>
        internal bool IsSetRequesterComment() => this.RequesterComment != null;

        /// <summary>
        /// Gets and sets the property RequesterPrincipalArn. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/intro-structure.html#intro-structure-request">IAM
        /// principal</a> that made the operation request.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string RequesterPrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the RequesterPrincipalArn property is set.
        /// </summary>
        internal bool IsSetRequesterPrincipalArn() => this.RequesterPrincipalArn != null;

        /// <summary>
        /// Gets and sets the property RequesterRegion. 
        /// <para>
        /// Amazon Web Services Region where the operation request originated.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string RequesterRegion { get; set; }

        /// <summary>
        /// Checks to see if the RequesterRegion property is set.
        /// </summary>
        internal bool IsSetRequesterRegion() => this.RequesterRegion != null;

        /// <summary>
        /// Gets and sets the property RequesterServicePrincipal. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">Service
        /// principal</a> for the service associated with the protected operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RequesterServicePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the RequesterServicePrincipal property is set.
        /// </summary>
        internal bool IsSetRequesterServicePrincipal() => this.RequesterServicePrincipal != null;

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SessionArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionArn property is set.
        /// </summary>
        internal bool IsSetSessionArn() => this.SessionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the session. For example, if the team has approved the requested operation.
        /// </para>
        /// </summary>
        public SessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Status code of the session.
        /// </para>
        /// </summary>
        public SessionStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Message describing the status for session.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 500)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
