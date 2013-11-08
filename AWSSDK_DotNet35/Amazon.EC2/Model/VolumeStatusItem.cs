/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>Volume Status Item
    /// </summary>
    public class VolumeStatusItem
    {
        
        private string volumeId;
        private string availabilityZone;
        private VolumeStatusInfo volumeStatus;
        private List<VolumeStatusEvent> events = new List<VolumeStatusEvent>();
        private List<VolumeStatusAction> actions = new List<VolumeStatusAction>();

        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }
        public VolumeStatusInfo VolumeStatus
        {
            get { return this.volumeStatus; }
            set { this.volumeStatus = value; }
        }

        // Check to see if VolumeStatus property is set
        internal bool IsSetVolumeStatus()
        {
            return this.volumeStatus != null;
        }
        public List<VolumeStatusEvent> Events
        {
            get { return this.events; }
            set { this.events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this.events.Count > 0;
        }
        public List<VolumeStatusAction> Actions
        {
            get { return this.actions; }
            set { this.actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this.actions.Count > 0;
        }
    }
}
