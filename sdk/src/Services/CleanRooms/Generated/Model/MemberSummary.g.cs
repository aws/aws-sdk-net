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
    /// The member object listed by the request.
    /// </summary>
    public partial class MemberSummary
    {
        /// <summary>
        /// Gets and sets the property Abilities. 
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
        public List<string> Abilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Abilities property is set.
        /// </summary>
        internal bool IsSetAbilities() => this.Abilities != null && (this.Abilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The identifier used to reference members of the collaboration. Currently only supports
        /// Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the member was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The member's display name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The unique ARN for the member's associated membership, if present.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string MembershipArn { get; set; }

        /// <summary>
        /// Checks to see if the MembershipArn property is set.
        /// </summary>
        internal bool IsSetMembershipArn() => this.MembershipArn != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The unique ID for the member's associated membership, if present.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property MlAbilities. 
        /// <para>
        /// Provides a summary of the ML abilities for the collaboration member.
        /// </para>
        /// </summary>
        public MLMemberAbilities MlAbilities { get; set; }

        /// <summary>
        /// Checks to see if the MlAbilities property is set.
        /// </summary>
        internal bool IsSetMlAbilities() => this.MlAbilities != null;

        /// <summary>
        /// Gets and sets the property PaymentConfiguration. 
        /// <para>
        /// The collaboration member's payment responsibilities set by the collaboration creator.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentConfiguration PaymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PaymentConfiguration property is set.
        /// </summary>
        internal bool IsSetPaymentConfiguration() => this.PaymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the member. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemberStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the member metadata was last updated.
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
