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

namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Custom snapshot and AMI policies only]</b> Specifies a schedule for a snapshot
    /// or AMI lifecycle policy.
    /// </summary>
    public partial class Schedule
    {
        /// <summary>
        /// Gets and sets the property ArchiveRule. 
        /// <para>
        ///  <b>[Custom snapshot policies that target volumes only]</b> The snapshot archiving
        /// rule for the schedule. When you specify an archiving rule, snapshots are automatically
        /// moved from the standard tier to the archive tier once the schedule's retention threshold
        /// is met. Snapshots are then retained in the archive tier for the archive retention
        /// period that you specify. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using snapshot archiving, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-ami-policy.html#dlm-archive">Considerations
        /// for snapshot lifecycle policies</a>.
        /// </para>
        /// </summary>
        public ArchiveRule ArchiveRule { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveRule property is set.
        /// </summary>
        internal bool IsSetArchiveRule() => this.ArchiveRule != null;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Copy all user-defined tags on a source volume to snapshots of the volume created by
        /// this policy.
        /// </para>
        /// </summary>
        public bool? CopyTags { get; set; }

        /// <summary>
        /// Checks to see if the CopyTags property is set.
        /// </summary>
        internal bool IsSetCopyTags() => this.CopyTags.HasValue;

        /// <summary>
        /// Gets and sets the property CreateRule. 
        /// <para>
        /// The creation rule.
        /// </para>
        /// </summary>
        public CreateRule CreateRule { get; set; }

        /// <summary>
        /// Checks to see if the CreateRule property is set.
        /// </summary>
        internal bool IsSetCreateRule() => this.CreateRule != null;

        /// <summary>
        /// Gets and sets the property CrossRegionCopyRules. 
        /// <para>
        /// Specifies a rule for copying snapshots or AMIs across Regions.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify cross-Region copy rules for policies that create snapshots on an
        /// Outpost or in a Local Zone. If the policy creates snapshots in a Region, then snapshots
        /// can be copied to up to three Regions or Outposts.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<CrossRegionCopyRule> CrossRegionCopyRules { get; set; } = AWSConfigs.InitializeCollections ? new List<CrossRegionCopyRule>() : null;

        /// <summary>
        /// Checks to see if the CrossRegionCopyRules property is set.
        /// </summary>
        internal bool IsSetCrossRegionCopyRules() => this.CrossRegionCopyRules != null && (this.CrossRegionCopyRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeprecateRule. 
        /// <para>
        ///  <b>[Custom AMI policies only]</b> The AMI deprecation rule for the schedule.
        /// </para>
        /// </summary>
        public DeprecateRule DeprecateRule { get; set; }

        /// <summary>
        /// Checks to see if the DeprecateRule property is set.
        /// </summary>
        internal bool IsSetDeprecateRule() => this.DeprecateRule != null;

        /// <summary>
        /// Gets and sets the property FastRestoreRule. 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> The rule for enabling fast snapshot restore.
        /// </para>
        /// </summary>
        public FastRestoreRule FastRestoreRule { get; set; }

        /// <summary>
        /// Checks to see if the FastRestoreRule property is set.
        /// </summary>
        internal bool IsSetFastRestoreRule() => this.FastRestoreRule != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RetainRule. 
        /// <para>
        /// The retention rule for snapshots or AMIs created by the policy.
        /// </para>
        /// </summary>
        public RetainRule RetainRule { get; set; }

        /// <summary>
        /// Checks to see if the RetainRule property is set.
        /// </summary>
        internal bool IsSetRetainRule() => this.RetainRule != null;

        /// <summary>
        /// Gets and sets the property ShareRules. 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> The rule for sharing snapshots with other
        /// Amazon Web Services accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<ShareRule> ShareRules { get; set; } = AWSConfigs.InitializeCollections ? new List<ShareRule>() : null;

        /// <summary>
        /// Checks to see if the ShareRules property is set.
        /// </summary>
        internal bool IsSetShareRules() => this.ShareRules != null && (this.ShareRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagsToAdd. 
        /// <para>
        /// The tags to apply to policy-created resources. These user-defined tags are in addition
        /// to the Amazon Web Services-added lifecycle tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 45)]
        public List<Tag> TagsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagsToAdd property is set.
        /// </summary>
        internal bool IsSetTagsToAdd() => this.TagsToAdd != null && (this.TagsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VariableTags. 
        /// <para>
        ///  <b>[AMI policies and snapshot policies that target instances only]</b> A collection
        /// of key/value pairs with values determined dynamically when the policy is executed.
        /// Keys may be any valid Amazon EC2 tag key. Values must be in one of the two following
        /// formats: <c>$(instance-id)</c> or <c>$(timestamp)</c>. Variable tags are only valid
        /// for EBS Snapshot Management – Instance policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 45)]
        public List<Tag> VariableTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the VariableTags property is set.
        /// </summary>
        internal bool IsSetVariableTags() => this.VariableTags != null && (this.VariableTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
