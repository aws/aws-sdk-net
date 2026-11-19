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
    /// Container for the parameters to the UpdateAgentProfile operation. Updates an existing
    /// optimization profile's configuration, including its pillars, execution role, and aggregation
    /// settings. Include only the fields you want to change. Any field you omit from the
    /// request keeps its current value, so you do not need to retrieve the profile first
    /// and resend the fields you are not changing. <para> To clear an optional text field,
    /// supply an empty string for it; the field is then unset, and a subsequent read omits
    /// it rather than returning an empty string. Omitting the field from the request leaves
    /// the stored value in place. <c>description</c> and <c>businessOverview</c> can be cleared
    /// this way. <c>displayName</c> cannot be cleared because a display name is required,
    /// though you can change it. <c>pillars</c> cannot be cleared because a profile must
    /// target at least one pillar. </para> <para> <c>aggregationConfiguration</c> behaves
    /// differently because it is a list of per-account configurations rather than a text
    /// field. Supplying an empty list removes every account entry, but the field itself remains
    /// set: a subsequent read returns an empty list rather than omitting the field. Omitting
    /// it from the request keeps the stored entries. </para>
    /// </summary>
    public partial class UpdateAgentProfileRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property AggregationConfiguration. 
        /// <para>
        /// The updated aggregation configuration, as a list of per-account entries. Omit this
        /// field to keep the current entries, or supply an empty list to remove them all. The
        /// field remains set either way — an emptied configuration is read back as an empty list,
        /// not as an absent field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<AggregationConfiguration> AggregationConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the AggregationConfiguration property is set.
        /// </summary>
        internal bool IsSetAggregationConfiguration() => this.AggregationConfiguration != null && (this.AggregationConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BusinessOverview. 
        /// <para>
        /// The updated business overview for the profile. Omit this field to keep the current
        /// business overview, or supply an empty string to clear it; a cleared business overview
        /// is read back as absent rather than as an empty string.
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
        /// Indicates whether deletion protection is enabled for the profile.
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
        /// The updated description of the profile. Omit this field to keep the current description,
        /// or supply an empty string to clear it; a cleared description is read back as absent
        /// rather than as an empty string.
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
        /// The updated display name of the profile. Omit this field to keep the current display
        /// name. A display name is required, so it cannot be cleared.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 128)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The updated ARN of the IAM execution role. Omit this field to keep the current execution
        /// role.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The updated Amazon Web Services Well-Architected Framework pillars for the profile.
        /// Omit this field to keep the current pillars. A profile must target at least one pillar,
        /// so an empty list is rejected.
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
        /// The Amazon Resource Name (ARN) of the profile to update.
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
