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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
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
        private ArchiveRule _archiveRule;
        private bool? _copyTags;
        private CreateRule _createRule;
        private List<CrossRegionCopyRule> _crossRegionCopyRules = AWSConfigs.InitializeCollections ? new List<CrossRegionCopyRule>() : null;
        private DeprecateRule _deprecateRule;
        private FastRestoreRule _fastRestoreRule;
        private string _name;
        private RetainRule _retainRule;
        private List<ShareRule> _shareRules = AWSConfigs.InitializeCollections ? new List<ShareRule>() : null;
        private List<Tag> _tagsToAdd = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<Tag> _variableTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        public ArchiveRule ArchiveRule
        {
            get { return this._archiveRule; }
            set { this._archiveRule = value; }
        }

        // Check to see if ArchiveRule property is set
        internal bool IsSetArchiveRule()
        {
            return this._archiveRule != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Copy all user-defined tags on a source volume to snapshots of the volume created by
        /// this policy.
        /// </para>
        /// </summary>
        public bool? CopyTags
        {
            get { return this._copyTags; }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateRule. 
        /// <para>
        /// The creation rule.
        /// </para>
        /// </summary>
        public CreateRule CreateRule
        {
            get { return this._createRule; }
            set { this._createRule = value; }
        }

        // Check to see if CreateRule property is set
        internal bool IsSetCreateRule()
        {
            return this._createRule != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<CrossRegionCopyRule> CrossRegionCopyRules
        {
            get { return this._crossRegionCopyRules; }
            set { this._crossRegionCopyRules = value; }
        }

        // Check to see if CrossRegionCopyRules property is set
        internal bool IsSetCrossRegionCopyRules()
        {
            return this._crossRegionCopyRules != null && (this._crossRegionCopyRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeprecateRule. 
        /// <para>
        ///  <b>[Custom AMI policies only]</b> The AMI deprecation rule for the schedule.
        /// </para>
        /// </summary>
        public DeprecateRule DeprecateRule
        {
            get { return this._deprecateRule; }
            set { this._deprecateRule = value; }
        }

        // Check to see if DeprecateRule property is set
        internal bool IsSetDeprecateRule()
        {
            return this._deprecateRule != null;
        }

        /// <summary>
        /// Gets and sets the property FastRestoreRule. 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> The rule for enabling fast snapshot restore.
        /// </para>
        /// </summary>
        public FastRestoreRule FastRestoreRule
        {
            get { return this._fastRestoreRule; }
            set { this._fastRestoreRule = value; }
        }

        // Check to see if FastRestoreRule property is set
        internal bool IsSetFastRestoreRule()
        {
            return this._fastRestoreRule != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=120)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RetainRule. 
        /// <para>
        /// The retention rule for snapshots or AMIs created by the policy.
        /// </para>
        /// </summary>
        public RetainRule RetainRule
        {
            get { return this._retainRule; }
            set { this._retainRule = value; }
        }

        // Check to see if RetainRule property is set
        internal bool IsSetRetainRule()
        {
            return this._retainRule != null;
        }

        /// <summary>
        /// Gets and sets the property ShareRules. 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> The rule for sharing snapshots with other
        /// Amazon Web Services accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<ShareRule> ShareRules
        {
            get { return this._shareRules; }
            set { this._shareRules = value; }
        }

        // Check to see if ShareRules property is set
        internal bool IsSetShareRules()
        {
            return this._shareRules != null && (this._shareRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagsToAdd. 
        /// <para>
        /// The tags to apply to policy-created resources. These user-defined tags are in addition
        /// to the Amazon Web Services-added lifecycle tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=45)]
        public List<Tag> TagsToAdd
        {
            get { return this._tagsToAdd; }
            set { this._tagsToAdd = value; }
        }

        // Check to see if TagsToAdd property is set
        internal bool IsSetTagsToAdd()
        {
            return this._tagsToAdd != null && (this._tagsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=45)]
        public List<Tag> VariableTags
        {
            get { return this._variableTags; }
            set { this._variableTags = value; }
        }

        // Check to see if VariableTags property is set
        internal bool IsSetVariableTags()
        {
            return this._variableTags != null && (this._variableTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}