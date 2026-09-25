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
    /// Specifies the configuration of a lifecycle policy.
    /// </summary>
    public partial class PolicyDetails
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        ///  <b>[Event-based policies only]</b> The actions to be performed when the event-based
        /// policy is activated. You can specify only one action per policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Action> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<Action>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        ///  <b>[Default policies only]</b> Indicates whether the policy should copy tags from
        /// the source resource to the snapshot or AMI. If you do not specify a value, the default
        /// is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? CopyTags { get; set; }

        /// <summary>
        /// Checks to see if the CopyTags property is set.
        /// </summary>
        internal bool IsSetCopyTags() => this.CopyTags.HasValue;

        /// <summary>
        /// Gets and sets the property CreateInterval. 
        /// <para>
        ///  <b>[Default policies only]</b> Specifies how often the policy should run and create
        /// snapshots or AMIs. The creation frequency can range from 1 to 7 days. If you do not
        /// specify a value, the default is 1.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? CreateInterval { get; set; }

        /// <summary>
        /// Checks to see if the CreateInterval property is set.
        /// </summary>
        internal bool IsSetCreateInterval() => this.CreateInterval.HasValue;

        /// <summary>
        /// Gets and sets the property CrossRegionCopyTargets. 
        /// <para>
        ///  <b>[Default policies only]</b> Specifies destination Regions for snapshot or AMI
        /// copies. You can specify up to 3 destination Regions. If you do not want to create
        /// cross-Region copies, omit this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<CrossRegionCopyTarget> CrossRegionCopyTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<CrossRegionCopyTarget>() : null;

        /// <summary>
        /// Checks to see if the CrossRegionCopyTargets property is set.
        /// </summary>
        internal bool IsSetCrossRegionCopyTargets() => this.CrossRegionCopyTargets != null && (this.CrossRegionCopyTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        ///  <b>[Event-based policies only]</b> The event that activates the event-based policy.
        /// </para>
        /// </summary>
        public EventSource EventSource { get; set; }

        /// <summary>
        /// Checks to see if the EventSource property is set.
        /// </summary>
        internal bool IsSetEventSource() => this.EventSource != null;

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        ///  <b>[Default policies only]</b> Specifies exclusion parameters for volumes or instances
        /// for which you do not want to create snapshots or AMIs. The policy will not create
        /// snapshots or AMIs for target resources that match any of the specified exclusion parameters.
        /// </para>
        /// </summary>
        public Exclusions Exclusions { get; set; }

        /// <summary>
        /// Checks to see if the Exclusions property is set.
        /// </summary>
        internal bool IsSetExclusions() => this.Exclusions != null;

        /// <summary>
        /// Gets and sets the property ExtendDeletion. 
        /// <para>
        ///  <b>[Default policies only]</b> Defines the snapshot or AMI retention behavior for
        /// the policy if the source volume or instance is deleted, or if the policy enters the
        /// error, disabled, or deleted state.
        /// </para>
        ///  
        /// <para>
        /// By default (<b>ExtendDeletion=false</b>):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a source resource is deleted, Amazon Data Lifecycle Manager will continue to delete
        /// previously created snapshots or AMIs, up to but not including the last one, based
        /// on the specified retention period. If you want Amazon Data Lifecycle Manager to delete
        /// all snapshots or AMIs, including the last one, specify <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a policy enters the error, disabled, or deleted state, Amazon Data Lifecycle Manager
        /// stops deleting snapshots and AMIs. If you want Amazon Data Lifecycle Manager to continue
        /// deleting snapshots or AMIs, including the last one, if the policy enters one of these
        /// states, specify <c>true</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you enable extended deletion (<b>ExtendDeletion=true</b>), you override both default
        /// behaviors simultaneously.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the default is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? ExtendDeletion { get; set; }

        /// <summary>
        /// Checks to see if the ExtendDeletion property is set.
        /// </summary>
        internal bool IsSetExtendDeletion() => this.ExtendDeletion.HasValue;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  <b>[Custom snapshot and AMI policies only]</b> A set of optional parameters for snapshot
        /// and AMI lifecycle policies. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are modifying a policy that was created or previously modified using the Amazon
        /// Data Lifecycle Manager console, then you must include this parameter and specify either
        /// the default values or the new values that you require. You can't omit this parameter
        /// or set its values to null.
        /// </para>
        ///  </note>
        /// </summary>
        public Parameters Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property PolicyLanguage. 
        /// <para>
        /// The type of policy to create. Specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SIMPLIFIED</c> To create a default policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STANDARD</c> To create a custom policy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PolicyLanguageValues PolicyLanguage { get; set; }

        /// <summary>
        /// Checks to see if the PolicyLanguage property is set.
        /// </summary>
        internal bool IsSetPolicyLanguage() => this.PolicyLanguage != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy. Specify <c>EBS_SNAPSHOT_MANAGEMENT</c> to create a lifecycle policy
        /// that manages the lifecycle of Amazon EBS snapshots. Specify <c>IMAGE_MANAGEMENT</c>
        /// to create a lifecycle policy that manages the lifecycle of EBS-backed AMIs. Specify
        /// <c>EVENT_BASED_POLICY </c> to create an event-based policy that performs specific
        /// actions when a defined event occurs in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>EBS_SNAPSHOT_MANAGEMENT</c>.
        /// </para>
        /// </summary>
        public PolicyTypeValues PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property ResourceLocations. 
        /// <para>
        ///  <b>[Custom snapshot and AMI policies only]</b> The location of the resources to backup.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the source resources are located in a Region, specify <c>CLOUD</c>. In this case,
        /// the policy targets all resources of the specified type with matching target tags across
        /// all Availability Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> If the source resources are located in a Local
        /// Zone, specify <c>LOCAL_ZONE</c>. In this case, the policy targets all resources of
        /// the specified type with matching target tags across all Local Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source resources are located on an Outpost in your account, specify <c>OUTPOST</c>.
        /// In this case, the policy targets all resources of the specified type with matching
        /// target tags across all of the Outposts in your account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> ResourceLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceLocations property is set.
        /// </summary>
        internal bool IsSetResourceLocations() => this.ResourceLocations != null && (this.ResourceLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  <b>[Default policies only]</b> Specify the type of default policy to create.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a default policy for EBS snapshots, that creates snapshots of all volumes
        /// in the Region that do not have recent backups, specify <c>VOLUME</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a default policy for EBS-backed AMIs, that creates EBS-backed AMIs from
        /// all instances in the Region that do not have recent backups, specify <c>INSTANCE</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceTypeValues ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> The target resource type for snapshot and
        /// AMI lifecycle policies. Use <c>VOLUME </c>to create snapshots of individual volumes
        /// or use <c>INSTANCE</c> to create multi-volume snapshots from the volumes for an instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RetainInterval. 
        /// <para>
        ///  <b>[Default policies only]</b> Specifies how long the policy should retain snapshots
        /// or AMIs before deleting them. The retention period can range from 2 to 14 days, but
        /// it must be greater than the creation frequency to ensure that the policy retains at
        /// least 1 snapshot or AMI at any given time. If you do not specify a value, the default
        /// is 7.
        /// </para>
        ///  
        /// <para>
        /// Default: 7
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? RetainInterval { get; set; }

        /// <summary>
        /// Checks to see if the RetainInterval property is set.
        /// </summary>
        internal bool IsSetRetainInterval() => this.RetainInterval.HasValue;

        /// <summary>
        /// Gets and sets the property Schedules. 
        /// <para>
        ///  <b>[Custom snapshot and AMI policies only]</b> The schedules of policy-defined actions
        /// for snapshot and AMI lifecycle policies. A policy can have up to four schedules—one
        /// mandatory schedule and up to three optional schedules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<Schedule> Schedules { get; set; } = AWSConfigs.InitializeCollections ? new List<Schedule>() : null;

        /// <summary>
        /// Checks to see if the Schedules property is set.
        /// </summary>
        internal bool IsSetSchedules() => this.Schedules != null && (this.Schedules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetTags. 
        /// <para>
        ///  <b>[Custom snapshot and AMI policies only]</b> The single tag that identifies targeted
        /// resources for this policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> TargetTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TargetTags property is set.
        /// </summary>
        internal bool IsSetTargetTags() => this.TargetTags != null && (this.TargetTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
