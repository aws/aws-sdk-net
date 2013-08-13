/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Volume Status
    /// </summary>
    public class VolumeStatus
    {
        private string volumeIdField;
        private string availabilityZoneField;
        private VolumeStatusInfo volumeStatusInfoField;
        private List<VolumeStatusEvent> volumeStatusEventField;
        private List<VolumeStatusAction> volumeStatusActionField;

        /// <summary>
        /// The volume ID
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }
        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return this.volumeIdField != null;
        }
        /// <summary>
        /// Sets the volume ID
        /// </summary>
        /// <param name="volumeId">The new volume id</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatus WithVolumeId(string volumeId)
        {
            this.volumeIdField = volumeId;
            return this;
        }

        /// <summary>
        /// Availability Zone of the volume
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }
        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }
        /// <summary>
        /// Sets the Availability Zone of the volume
        /// </summary>
        /// <param name="availabilityZone">The new availability zone</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatus WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Status of the volume
        /// </summary>
        public VolumeStatusInfo VolumeStatusInfo
        {
            get { return this.volumeStatusInfoField; }
            set { this.volumeStatusInfoField = value; }
        }
        /// <summary>
        /// Checks if VolumeStatusInfo property is set
        /// </summary>
        /// <returns>true if VolumeStatusInfo property is set</returns>
        public bool IsSetVolumeStatusInfo()
        {
            return this.volumeStatusInfoField != null;
        }
        /// <summary>
        /// Sets the status of the volume
        /// </summary>
        /// <param name="volumeStatusInfo">The new VolumeStatusInfo</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatus WithVolumeStatusInfo(VolumeStatusInfo volumeStatusInfo)
        {
            this.volumeStatusInfoField = volumeStatusInfo;
            return this;
        }

        /// <summary>
        /// A list of events associated with the volume
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeStatusEvent")]
        public List<VolumeStatusEvent> VolumeStatusEvent
        {
            get
            {
                if (this.volumeStatusEventField == null)
                {
                    this.volumeStatusEventField = new List<VolumeStatusEvent>();
                }
                return this.volumeStatusEventField;
            }
            set { this.volumeStatusEventField = value; }
        }
        /// <summary>
        /// Checks if VolumeStatusEvent property is set
        /// </summary>
        /// <returns>true if VolumeStatusEvent property is set</returns>
        public bool IsSetVolumeStatusEvent()
        {
            return this.volumeStatusEventField != null;
        }
        /// <summary>
        /// Sets a list of events associated with the volume
        /// </summary>
        /// <param name="list">The new VolumeStatusEvent</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatus WithVolumeStatusEvent(params VolumeStatusEvent[] list)
        {
            foreach (VolumeStatusEvent item in list)
            {
                this.volumeStatusEventField.Add(item);
            }
            return this;
        }

        /// <summary>
        /// A list of actions associated with the volume
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeStatusAction")]
        public List<VolumeStatusAction> VolumeStatusAction
        {
            get
            {
                if (this.volumeStatusActionField == null)
                {
                    this.volumeStatusActionField = new List<VolumeStatusAction>();
                }
                return this.volumeStatusActionField;
            }
            set { this.volumeStatusActionField = value; }
        }
        /// <summary>
        /// Checks if VolumeStatusAction property is set
        /// </summary>
        /// <returns>true if VolumeStatusAction property is set</returns>
        public bool IsSetVolumeStatusAction()
        {
            return this.volumeStatusActionField != null;
        }
        /// <summary>
        /// Sets a list of actions associated with the volume
        /// </summary>
        /// <param name="list">The new VolumeStatusAction</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatus WithVolumeStatusAction(params VolumeStatusAction[] list)
        {
            foreach (VolumeStatusAction item in list)
            {
                this.volumeStatusActionField.Add(item);
            }
            return this;
        }
    }
}
