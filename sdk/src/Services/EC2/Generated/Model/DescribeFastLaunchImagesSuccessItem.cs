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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe details about a fast-launch enabled Windows image that meets the requested
    /// criteria. Criteria are defined by the <code>DescribeFastLaunchImages</code> action
    /// filters.
    /// </summary>
    public partial class DescribeFastLaunchImagesSuccessItem
    {
        private string _imageId;
        private FastLaunchLaunchTemplateSpecificationResponse _launchTemplate;
        private int? _maxParallelLaunches;
        private string _ownerId;
        private FastLaunchResourceType _resourceType;
        private FastLaunchSnapshotConfigurationResponse _snapshotConfiguration;
        private FastLaunchStateCode _state;
        private string _stateTransitionReason;
        private DateTime? _stateTransitionTime;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The image ID that identifies the fast-launch enabled Windows image.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template that the fast-launch enabled Windows AMI uses when it launches
        /// Windows instances from pre-provisioned snapshots.
        /// </para>
        /// </summary>
        public FastLaunchLaunchTemplateSpecificationResponse LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property MaxParallelLaunches. 
        /// <para>
        /// The maximum number of instances that Amazon EC2 can launch at the same time to create
        /// pre-provisioned snapshots for Windows faster launching.
        /// </para>
        /// </summary>
        public int MaxParallelLaunches
        {
            get { return this._maxParallelLaunches.GetValueOrDefault(); }
            set { this._maxParallelLaunches = value; }
        }

        // Check to see if MaxParallelLaunches property is set
        internal bool IsSetMaxParallelLaunches()
        {
            return this._maxParallelLaunches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner ID for the fast-launch enabled Windows AMI.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type that is used for pre-provisioning the Windows AMI. Supported values
        /// include: <code>snapshot</code>.
        /// </para>
        /// </summary>
        public FastLaunchResourceType ResourceType
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
        /// Gets and sets the property SnapshotConfiguration. 
        /// <para>
        /// A group of parameters that are used for pre-provisioning the associated Windows AMI
        /// using snapshots.
        /// </para>
        /// </summary>
        public FastLaunchSnapshotConfigurationResponse SnapshotConfiguration
        {
            get { return this._snapshotConfiguration; }
            set { this._snapshotConfiguration = value; }
        }

        // Check to see if SnapshotConfiguration property is set
        internal bool IsSetSnapshotConfiguration()
        {
            return this._snapshotConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of faster launching for the specified Windows AMI.
        /// </para>
        /// </summary>
        public FastLaunchStateCode State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateTransitionReason. 
        /// <para>
        /// The reason that faster launching for the Windows AMI changed to the current state.
        /// </para>
        /// </summary>
        public string StateTransitionReason
        {
            get { return this._stateTransitionReason; }
            set { this._stateTransitionReason = value; }
        }

        // Check to see if StateTransitionReason property is set
        internal bool IsSetStateTransitionReason()
        {
            return this._stateTransitionReason != null;
        }

        /// <summary>
        /// Gets and sets the property StateTransitionTime. 
        /// <para>
        /// The time that faster launching for the Windows AMI changed to the current state.
        /// </para>
        /// </summary>
        public DateTime StateTransitionTime
        {
            get { return this._stateTransitionTime.GetValueOrDefault(); }
            set { this._stateTransitionTime = value; }
        }

        // Check to see if StateTransitionTime property is set
        internal bool IsSetStateTransitionTime()
        {
            return this._stateTransitionTime.HasValue; 
        }

    }
}