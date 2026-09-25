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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The membership object listed by the request.
    /// </summary>
    public partial class MembershipSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique ARN for the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The unique ARN for the membership's associated collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string CollaborationArn { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationArn property is set.
        /// </summary>
        internal bool IsSetCollaborationArn() => this.CollaborationArn != null;

        /// <summary>
        /// Gets and sets the property CollaborationCreatorAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services principal that created the collaboration.
        /// Currently only supports Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string CollaborationCreatorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationCreatorAccountId property is set.
        /// </summary>
        internal bool IsSetCollaborationCreatorAccountId() => this.CollaborationCreatorAccountId != null;

        /// <summary>
        /// Gets and sets the property CollaborationCreatorDisplayName. 
        /// <para>
        /// The display name of the collaboration creator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string CollaborationCreatorDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationCreatorDisplayName property is set.
        /// </summary>
        internal bool IsSetCollaborationCreatorDisplayName() => this.CollaborationCreatorDisplayName != null;

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique ID for the membership's collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationId { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationId property is set.
        /// </summary>
        internal bool IsSetCollaborationId() => this.CollaborationId != null;

        /// <summary>
        /// Gets and sets the property CollaborationName. 
        /// <para>
        /// The name for the membership's collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string CollaborationName { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationName property is set.
        /// </summary>
        internal bool IsSetCollaborationName() => this.CollaborationName != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the membership was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the membership's collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MemberAbilities. 
        /// <para>
        /// The abilities granted to the collaboration member.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> MemberAbilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MemberAbilities property is set.
        /// </summary>
        internal bool IsSetMemberAbilities() => this.MemberAbilities != null && (this.MemberAbilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MlMemberAbilities. 
        /// <para>
        /// Provides a summary of the ML abilities for the collaboration member.
        /// </para>
        /// </summary>
        public MLMemberAbilities MlMemberAbilities { get; set; }

        /// <summary>
        /// Checks to see if the MlMemberAbilities property is set.
        /// </summary>
        internal bool IsSetMlMemberAbilities() => this.MlMemberAbilities != null;

        /// <summary>
        /// Gets and sets the property PaymentConfiguration. 
        /// <para>
        /// The payment responsibilities accepted by the collaboration member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MembershipPaymentConfiguration PaymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PaymentConfiguration property is set.
        /// </summary>
        internal bool IsSetPaymentConfiguration() => this.PaymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MembershipStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the membership metadata was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
