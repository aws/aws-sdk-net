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
    /// Container for the parameters to the UpdateLifecyclePolicy operation.
    /// Updates the specified lifecycle policy.
    /// 
    ///  
    /// <para>
    /// For more information about updating a policy, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/view-modify-delete.html#modify">Modify
    /// lifecycle policies</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLifecyclePolicyRequest : AmazonDLMRequest
    {
        private bool? _copyTags;
        private int? _createInterval;
        private List<CrossRegionCopyTarget> _crossRegionCopyTargets = AWSConfigs.InitializeCollections ? new List<CrossRegionCopyTarget>() : null;
        private string _description;
        private Exclusions _exclusions;
        private string _executionRoleArn;
        private bool? _extendDeletion;
        private PolicyDetails _policyDetails;
        private string _policyId;
        private int? _retainInterval;
        private SettablePolicyStateValues _state;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        ///  <b>[Default policies only]</b> Indicates whether the policy should copy tags from
        /// the source resource to the snapshot or AMI.
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
        /// snapshots or AMIs. The creation frequency can range from 1 to 7 days.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to run the operations specified
        /// by the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
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
        /// Gets and sets the property PolicyDetails. 
        /// <para>
        /// The configuration of the lifecycle policy. You cannot update the policy type or the
        /// resource type.
        /// </para>
        /// </summary>
        public PolicyDetails PolicyDetails
        {
            get { return this._policyDetails; }
            set { this._policyDetails = value; }
        }

        // Check to see if PolicyDetails property is set
        internal bool IsSetPolicyDetails()
        {
            return this._policyDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The identifier of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property RetainInterval. 
        /// <para>
        ///  <b>[Default policies only]</b> Specifies how long the policy should retain snapshots
        /// or AMIs before deleting them. The retention period can range from 2 to 14 days, but
        /// it must be greater than the creation frequency to ensure that the policy retains at
        /// least 1 snapshot or AMI at any given time.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The desired activation state of the lifecycle policy after creation.
        /// </para>
        /// </summary>
        public SettablePolicyStateValues State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}