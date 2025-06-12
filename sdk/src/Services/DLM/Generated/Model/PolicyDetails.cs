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
    /// Specifies the configuration of a lifecycle policy.
    /// </summary>
    public partial class PolicyDetails
    {
        private List<Action> _actions = AWSConfigs.InitializeCollections ? new List<Action>() : null;
        private bool? _copyTags;
        private int? _createInterval;
        private List<CrossRegionCopyTarget> _crossRegionCopyTargets = AWSConfigs.InitializeCollections ? new List<CrossRegionCopyTarget>() : null;
        private EventSource _eventSource;
        private Exclusions _exclusions;
        private bool? _extendDeletion;
        private Parameters _parameters;
        private PolicyLanguageValues _policyLanguage;
        private PolicyTypeValues _policyType;
        private List<string> _resourceLocations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceTypeValues _resourceType;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _retainInterval;
        private List<Schedule> _schedules = AWSConfigs.InitializeCollections ? new List<Schedule>() : null;
        private List<Tag> _targetTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        ///  <b>[Event-based policies only]</b> The actions to be performed when the event-based
        /// policy is activated. You can specify only one action per policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<Action> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1)]
        public int? CreateInterval
        {
            get { return this._createInterval; }
            set { this._createInterval = value; }
        }

        // Check to see if CreateInterval property is set
        internal bool IsSetCreateInterval()
        {
            return this._createInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrossRegionCopyTargets. 
        /// <para>
        ///  <b>[Default policies only]</b> Specifies destination Regions for snapshot or AMI
        /// copies. You can specify up to 3 destination Regions. If you do not want to create
        /// cross-Region copies, omit this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<CrossRegionCopyTarget> CrossRegionCopyTargets
        {
            get { return this._crossRegionCopyTargets; }
            set { this._crossRegionCopyTargets = value; }
        }

        // Check to see if CrossRegionCopyTargets property is set
        internal bool IsSetCrossRegionCopyTargets()
        {
            return this._crossRegionCopyTargets != null && (this._crossRegionCopyTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        ///  <b>[Event-based policies only]</b> The event that activates the event-based policy.
        /// </para>
        /// </summary>
        public EventSource EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        ///  <b>[Default policies only]</b> Specifies exclusion parameters for volumes or instances
        /// for which you do not want to create snapshots or AMIs. The policy will not create
        /// snapshots or AMIs for target resources that match any of the specified exclusion parameters.
        /// </para>
        /// </summary>
        public Exclusions Exclusions
        {
            get { return this._exclusions; }
            set { this._exclusions = value; }
        }

        // Check to see if Exclusions property is set
        internal bool IsSetExclusions()
        {
            return this._exclusions != null;
        }

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
        public bool? ExtendDeletion
        {
            get { return this._extendDeletion; }
            set { this._extendDeletion = value; }
        }

        // Check to see if ExtendDeletion property is set
        internal bool IsSetExtendDeletion()
        {
            return this._extendDeletion.HasValue; 
        }

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
        public Parameters Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

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
        public PolicyLanguageValues PolicyLanguage
        {
            get { return this._policyLanguage; }
            set { this._policyLanguage = value; }
        }

        // Check to see if PolicyLanguage property is set
        internal bool IsSetPolicyLanguage()
        {
            return this._policyLanguage != null;
        }

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
        public PolicyTypeValues PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ResourceLocations
        {
            get { return this._resourceLocations; }
            set { this._resourceLocations = value; }
        }

        // Check to see if ResourceLocations property is set
        internal bool IsSetResourceLocations()
        {
            return this._resourceLocations != null && (this._resourceLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public ResourceTypeValues ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> The target resource type for snapshot and
        /// AMI lifecycle policies. Use <c>VOLUME </c>to create snapshots of individual volumes
        /// or use <c>INSTANCE</c> to create multi-volume snapshots from the volumes for an instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1)]
        public int? RetainInterval
        {
            get { return this._retainInterval; }
            set { this._retainInterval = value; }
        }

        // Check to see if RetainInterval property is set
        internal bool IsSetRetainInterval()
        {
            return this._retainInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedules. 
        /// <para>
        ///  <b>[Custom snapshot and AMI policies only]</b> The schedules of policy-defined actions
        /// for snapshot and AMI lifecycle policies. A policy can have up to four schedules—one
        /// mandatory schedule and up to three optional schedules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<Schedule> Schedules
        {
            get { return this._schedules; }
            set { this._schedules = value; }
        }

        // Check to see if Schedules property is set
        internal bool IsSetSchedules()
        {
            return this._schedules != null && (this._schedules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetTags. 
        /// <para>
        ///  <b>[Custom snapshot and AMI policies only]</b> The single tag that identifies targeted
        /// resources for this policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> TargetTags
        {
            get { return this._targetTags; }
            set { this._targetTags = value; }
        }

        // Check to see if TargetTags property is set
        internal bool IsSetTargetTags()
        {
            return this._targetTags != null && (this._targetTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}