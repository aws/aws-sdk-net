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
    /// Container for the parameters to the CreateApprovalTeam operation. Creates a new approval
    /// team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Approval
    /// team</a> in the <i>Multi-party approval User Guide</i>.
    /// </summary>
    public partial class CreateApprovalTeamRequest : AmazonMPARequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalStrategy. 
        /// <para>
        /// An <c>ApprovalStrategy</c> object. Contains details for how the team grants approval.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApprovalStrategy ApprovalStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalStrategy property is set.
        /// </summary>
        internal bool IsSetApprovalStrategy() => this.ApprovalStrategy != null;

        /// <summary>
        /// Gets and sets the property Approvers. 
        /// <para>
        /// An array of <c>ApprovalTeamRequesterApprovers</c> objects. Contains details for the
        /// approvers in the team.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<ApprovalTeamRequestApprover> Approvers { get; set; } = AWSConfigs.InitializeCollections ? new List<ApprovalTeamRequestApprover>() : null;

        /// <summary>
        /// Checks to see if the Approvers property is set.
        /// </summary>
        internal bool IsSetApprovers() => this.Approvers != null && (this.Approvers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If not provided, the Amazon Web Services populates this field.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>What is idempotency?</b> 
        /// </para>
        ///  
        /// <para>
        /// When you make a mutating API request, the request typically returns a result before
        /// the operation's asynchronous workflows have completed. Operations might also time
        /// out or encounter other server issues before they complete, even though the request
        /// has already returned a result. This could make it difficult to determine whether the
        /// request succeeded or not, and could lead to multiple retries to ensure that the operation
        /// completes successfully. However, if the original request and the subsequent retries
        /// are successful, the operation is completed multiple times. This means that you might
        /// create more resources than you intended.
        /// </para>
        ///  
        /// <para>
        ///  <i>Idempotency</i> ensures that an API request completes no more than one time. With
        /// an idempotent request, if the original request completes successfully, any subsequent
        /// retries complete successfully without performing any further actions.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max = 4096)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the team.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// An array of <c>PolicyReference</c> objects. Contains a list of policies that define
        /// the permissions for team resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<PolicyReference> Policies { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyReference>() : null;

        /// <summary>
        /// Checks to see if the Policies property is set.
        /// </summary>
        internal bool IsSetPolicies() => this.Policies != null && (this.Policies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags you want to attach to the team.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
