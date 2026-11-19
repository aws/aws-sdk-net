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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAgentOrganizationalProfile operation. Updates
    /// an Organizational Profile. Organizational Profiles are specific to Profiles created
    /// using AWS Organizations integration. Include only the fields you want to change; any
    /// field you omit from the request keeps its current value. <para> To clear an optional
    /// text field, supply an empty string for it; the field is then unset, and a subsequent
    /// read omits it rather than returning an empty string. Omitting the field from the request
    /// leaves the stored value in place. <c>description</c> and <c>businessOverview</c> can
    /// be cleared this way. <c>displayName</c> cannot be cleared because a display name is
    /// required, though you can change it. <c>pillars</c> cannot be cleared because a profile
    /// must target at least one pillar. </para> <para> <c>organizationalAggregationConfiguration</c>
    /// behaves differently because it is a structure rather than a text field. Supplying
    /// it with both its <c>organizationalUnits</c> and <c>accounts</c> lists empty removes
    /// every monitored organizational unit and account, but the field itself remains set:
    /// a subsequent read returns the structure with two empty lists rather than omitting
    /// it. Omitting the field from the request keeps the stored boundary. </para>
    /// </summary>
    public partial class UpdateAgentOrganizationalProfileRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property BusinessOverview. 
        /// <para>
        /// The updated business overview for the organizational profile. Omit this field to keep
        /// the current business overview, or supply an empty string to clear it; a cleared business
        /// overview is read back as absent rather than as an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 512)]
        public string BusinessOverview { get; set; }

        /// <summary>
        /// Checks to see if the BusinessOverview property is set.
        /// </summary>
        internal bool IsSetBusinessOverview() => this.BusinessOverview != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether deletion protection is enabled for the organizational profile.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the organizational profile. Omit this field to keep the
        /// current description, or supply an empty string to clear it; a cleared description
        /// is read back as absent rather than as an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The updated display name of the organizational profile. Omit this field to keep the
        /// current display name. A display name is required, so it cannot be cleared.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 128)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property OrganizationalAggregationConfiguration. 
        /// <para>
        /// The organizational monitoring boundary. Contains organizational unit or root entries
        /// and individual account entries that define the scope for the profile. Omit this field
        /// to keep the current boundary, or supply this structure with both its <c>organizationalUnits</c>
        /// and <c>accounts</c> lists empty to remove every monitored organizational unit and
        /// account. The field remains set either way — an emptied boundary is read back as a
        /// structure with two empty lists, not as an absent field.
        /// </para>
        /// </summary>
        public OrganizationalAggregationConfiguration OrganizationalAggregationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalAggregationConfiguration property is set.
        /// </summary>
        internal bool IsSetOrganizationalAggregationConfiguration() => this.OrganizationalAggregationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The updated Amazon Web Services Well-Architected Framework pillars for the organizational
        /// profile. Omit this field to keep the current pillars. A profile must target at least
        /// one pillar, so an empty list is rejected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> Pillars { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Pillars property is set.
        /// </summary>
        internal bool IsSetPillars() => this.Pillars != null && (this.Pillars.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the organizational profile to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileArn property is set.
        /// </summary>
        internal bool IsSetProfileArn() => this.ProfileArn != null;
    }
}
