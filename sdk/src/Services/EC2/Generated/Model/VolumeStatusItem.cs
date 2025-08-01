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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the volume status.
    /// </summary>
    public partial class VolumeStatusItem
    {
        private List<VolumeStatusAction> _actions = AWSConfigs.InitializeCollections ? new List<VolumeStatusAction>() : null;
        private List<VolumeStatusAttachmentStatus> _attachmentStatuses = AWSConfigs.InitializeCollections ? new List<VolumeStatusAttachmentStatus>() : null;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private List<VolumeStatusEvent> _events = AWSConfigs.InitializeCollections ? new List<VolumeStatusEvent>() : null;
        private InitializationStatusDetails _initializationStatusDetails;
        private string _outpostArn;
        private string _volumeId;
        private VolumeStatusInfo _volumeStatus;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The details of the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeStatusAction> Actions
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
        /// Gets and sets the property AttachmentStatuses. 
        /// <para>
        /// Information about the instances to which the volume is attached.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeStatusAttachmentStatus> AttachmentStatuses
        {
            get { return this._attachmentStatuses; }
            set { this._attachmentStatuses = value; }
        }

        // Check to see if AttachmentStatuses property is set
        internal bool IsSetAttachmentStatuses()
        {
            return this._attachmentStatuses != null && (this._attachmentStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the volume.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// A list of events associated with the volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeStatusEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InitializationStatusDetails. 
        /// <para>
        /// Information about the volume initialization. It can take up to 5 minutes for the volume
        /// initialization information to be updated.
        /// </para>
        ///  
        /// <para>
        /// Only available for volumes created from snapshots. Not available for empty volumes
        /// created without a snapshot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/initalize-volume.html">
        /// Initialize Amazon EBS volumes</a>.
        /// </para>
        /// </summary>
        public InitializationStatusDetails InitializationStatusDetails
        {
            get { return this._initializationStatusDetails; }
            set { this._initializationStatusDetails = value; }
        }

        // Check to see if InitializationStatusDetails property is set
        internal bool IsSetInitializationStatusDetails()
        {
            return this._initializationStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The volume ID.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeStatus. 
        /// <para>
        /// The volume status.
        /// </para>
        /// </summary>
        public VolumeStatusInfo VolumeStatus
        {
            get { return this._volumeStatus; }
            set { this._volumeStatus = value; }
        }

        // Check to see if VolumeStatus property is set
        internal bool IsSetVolumeStatus()
        {
            return this._volumeStatus != null;
        }

    }
}