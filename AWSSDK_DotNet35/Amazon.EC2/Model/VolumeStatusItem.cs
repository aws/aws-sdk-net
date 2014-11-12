/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the volume status.
    /// </summary>
    public partial class VolumeStatusItem
    {
        private List<VolumeStatusAction> _actions = new List<VolumeStatusAction>();
        private string _availabilityZone;
        private List<VolumeStatusEvent> _events = new List<VolumeStatusEvent>();
        private string _volumeId;
        private VolumeStatusInfo _volumeStatus;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The details of the operation.
        /// </para>
        /// </summary>
        public List<VolumeStatusAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
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
        /// Gets and sets the property Events. 
        /// <para>
        /// A list of events associated with the volume.
        /// </para>
        /// </summary>
        public List<VolumeStatusEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
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