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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetPatchBaseline operation.
    /// </summary>
    public partial class GetPatchBaselineResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApprovalRules. 
        /// <para>
        /// A set of rules used to include patches in the baseline.
        /// </para>
        /// </summary>
        public PatchRuleGroup ApprovalRules { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRules property is set.
        /// </summary>
        internal bool IsSetApprovalRules() => this.ApprovalRules != null;

        /// <summary>
        /// Gets and sets the property ApprovedPatches. 
        /// <para>
        /// A list of explicitly approved patches for the baseline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> ApprovedPatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApprovedPatches property is set.
        /// </summary>
        internal bool IsSetApprovedPatches() => this.ApprovedPatches != null && (this.ApprovedPatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApprovedPatchesComplianceLevel. 
        /// <para>
        /// Returns the specified compliance severity level for approved patches in the patch
        /// baseline.
        /// </para>
        /// </summary>
        public PatchComplianceLevel ApprovedPatchesComplianceLevel { get; set; }

        /// <summary>
        /// Checks to see if the ApprovedPatchesComplianceLevel property is set.
        /// </summary>
        internal bool IsSetApprovedPatchesComplianceLevel() => this.ApprovedPatchesComplianceLevel != null;

        /// <summary>
        /// Gets and sets the property ApprovedPatchesEnableNonSecurity. 
        /// <para>
        /// Indicates whether the list of approved patches includes non-security updates that
        /// should be applied to the managed nodes. The default value is <c>false</c>. Applies
        /// to Linux managed nodes only.
        /// </para>
        /// </summary>
        public bool? ApprovedPatchesEnableNonSecurity { get; set; }

        /// <summary>
        /// Checks to see if the ApprovedPatchesEnableNonSecurity property is set.
        /// </summary>
        internal bool IsSetApprovedPatchesEnableNonSecurity() => this.ApprovedPatchesEnableNonSecurity.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableSecurityUpdatesComplianceStatus. 
        /// <para>
        /// Indicates the compliance status of managed nodes for which security-related patches
        /// are available but were not approved. This preference is specified when the <c>CreatePatchBaseline</c>
        /// or <c>UpdatePatchBaseline</c> commands are run.
        /// </para>
        ///  
        /// <para>
        /// Applies to Windows Server managed nodes only.
        /// </para>
        /// </summary>
        public PatchComplianceStatus AvailableSecurityUpdatesComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the AvailableSecurityUpdatesComplianceStatus property is set.
        /// </summary>
        internal bool IsSetAvailableSecurityUpdatesComplianceStatus() => this.AvailableSecurityUpdatesComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the retrieved patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 128)]
        public string BaselineId { get; set; }

        /// <summary>
        /// Checks to see if the BaselineId property is set.
        /// </summary>
        internal bool IsSetBaselineId() => this.BaselineId != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the patch baseline was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GlobalFilters. 
        /// <para>
        /// A set of global filters used to exclude patches from the baseline.
        /// </para>
        /// </summary>
        public PatchFilterGroup GlobalFilters { get; set; }

        /// <summary>
        /// Checks to see if the GlobalFilters property is set.
        /// </summary>
        internal bool IsSetGlobalFilters() => this.GlobalFilters != null;

        /// <summary>
        /// Gets and sets the property ModifiedDate. 
        /// <para>
        /// The date the patch baseline was last modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedDate property is set.
        /// </summary>
        internal bool IsSetModifiedDate() => this.ModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// Returns the operating system specified for the patch baseline.
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property PatchGroups. 
        /// <para>
        /// Patch groups included in the patch baseline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PatchGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PatchGroups property is set.
        /// </summary>
        internal bool IsSetPatchGroups() => this.PatchGroups != null && (this.PatchGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RejectedPatches. 
        /// <para>
        /// A list of explicitly rejected patches for the baseline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RejectedPatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RejectedPatches property is set.
        /// </summary>
        internal bool IsSetRejectedPatches() => this.RejectedPatches != null && (this.RejectedPatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RejectedPatchesAction. 
        /// <para>
        /// The action specified to take on patches included in the <c>RejectedPatches</c> list.
        /// A patch can be allowed only if it is a dependency of another package, or blocked entirely
        /// along with packages that include it as a dependency.
        /// </para>
        /// </summary>
        public PatchAction RejectedPatchesAction { get; set; }

        /// <summary>
        /// Checks to see if the RejectedPatchesAction property is set.
        /// </summary>
        internal bool IsSetRejectedPatchesAction() => this.RejectedPatchesAction != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Information about the patches to use to update the managed nodes, including target
        /// operating systems and source repositories. Applies to Linux managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<PatchSource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<PatchSource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
