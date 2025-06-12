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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details for a resource that the runtime instance of the lifecycle policy
    /// identified for action.
    /// </summary>
    public partial class LifecycleExecutionResource
    {
        private string _accountId;
        private LifecycleExecutionResourceAction _action;
        private DateTime? _endTime;
        private List<string> _imageUris = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _region;
        private string _resourceId;
        private List<LifecycleExecutionSnapshotResource> _snapshots = AWSConfigs.InitializeCollections ? new List<LifecycleExecutionSnapshotResource>() : null;
        private DateTime? _startTime;
        private LifecycleExecutionResourceState _state;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account that owns the impacted resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take for the identified resource.
        /// </para>
        /// </summary>
        public LifecycleExecutionResourceAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The ending timestamp from the lifecycle action that was applied to the resource.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageUris. 
        /// <para>
        /// For an impacted container image, this identifies a list of URIs for associated container
        /// images distributed to ECR repositories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageUris
        {
            get { return this._imageUris; }
            set { this._imageUris = value; }
        }

        // Check to see if ImageUris property is set
        internal bool IsSetImageUris()
        {
            return this._imageUris != null && (this._imageUris.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the lifecycle execution resource is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Identifies the impacted resource. The resource ID depends on the type of resource,
        /// as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Image Builder image resources: Amazon Resource Name (ARN)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Distributed AMIs: AMI ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Container images distributed to an ECR repository: image URI or SHA Digest
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Snapshots. 
        /// <para>
        /// A list of associated resource snapshots for the impacted resource if it’s an AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleExecutionSnapshotResource> Snapshots
        {
            get { return this._snapshots; }
            set { this._snapshots = value; }
        }

        // Check to see if Snapshots property is set
        internal bool IsSetSnapshots()
        {
            return this._snapshots != null && (this._snapshots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The starting timestamp from the lifecycle action that was applied to the resource.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The runtime state for the lifecycle execution.
        /// </para>
        /// </summary>
        public LifecycleExecutionResourceState State
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