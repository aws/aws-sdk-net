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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMembership operation. Updates membership
    /// configuration.
    /// </summary>
    public partial class UpdateMembershipRequest : AmazonSecurityIRRequest
    {
        /// <summary>
        /// Gets and sets the property IncidentResponseTeam. 
        /// <para>
        /// Optional element for UpdateMembership to update the membership name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public List<IncidentResponder> IncidentResponseTeam { get; set; } = AWSConfigs.InitializeCollections ? new List<IncidentResponder>() : null;

        /// <summary>
        /// Checks to see if the IncidentResponseTeam property is set.
        /// </summary>
        internal bool IsSetIncidentResponseTeam() => this.IncidentResponseTeam != null && (this.IncidentResponseTeam.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MembershipAccountsConfigurationsUpdate. 
        /// <para>
        /// The <c>membershipAccountsConfigurationsUpdate</c> field in the <c>UpdateMembershipRequest</c>
        /// structure allows you to update the configuration settings for accounts within a membership.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This field is optional and contains a structure of type <c>MembershipAccountsConfigurationsUpdate
        /// </c> that specifies the updated account configurations for the membership. 
        /// </para>
        /// </summary>
        public MembershipAccountsConfigurationsUpdate MembershipAccountsConfigurationsUpdate { get; set; }

        /// <summary>
        /// Checks to see if the MembershipAccountsConfigurationsUpdate property is set.
        /// </summary>
        internal bool IsSetMembershipAccountsConfigurationsUpdate() => this.MembershipAccountsConfigurationsUpdate != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// Required element for UpdateMembership to identify the membership to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 34)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property MembershipName. 
        /// <para>
        /// Optional element for UpdateMembership to update the membership name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 50)]
        public string MembershipName { get; set; }

        /// <summary>
        /// Checks to see if the MembershipName property is set.
        /// </summary>
        internal bool IsSetMembershipName() => this.MembershipName != null;

        /// <summary>
        /// Gets and sets the property OptInFeatures. 
        /// <para>
        /// Optional element for UpdateMembership to enable or disable opt-in features for the
        /// service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<OptInFeature> OptInFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<OptInFeature>() : null;

        /// <summary>
        /// Checks to see if the OptInFeatures property is set.
        /// </summary>
        internal bool IsSetOptInFeatures() => this.OptInFeatures != null && (this.OptInFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UndoMembershipCancellation. 
        /// <para>
        /// The <c>undoMembershipCancellation</c> parameter is a boolean flag that indicates whether
        /// to reverse a previously requested membership cancellation. When set to true, this
        /// will revoke the cancellation request and maintain the membership status. 
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional and can be used in scenarios where you need to restore
        /// a membership that was marked for cancellation but hasn't been fully terminated yet.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If set to <c>true</c>, the cancellation request will be revoked 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If set to <c>false</c> the service will throw a ValidationException. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? UndoMembershipCancellation { get; set; }

        /// <summary>
        /// Checks to see if the UndoMembershipCancellation property is set.
        /// </summary>
        internal bool IsSetUndoMembershipCancellation() => this.UndoMembershipCancellation.HasValue;
    }
}
