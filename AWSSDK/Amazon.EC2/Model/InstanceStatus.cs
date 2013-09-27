/*
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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    /// Information about the status of an instance.
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceStatus
    {
        private string instanceIdField;
        private string availabilityZoneField;
        private List<InstanceStatusEvent> instanceStatusEventField;
        private InstanceState instanceStateField;
        private InstanceStatusDetail systemStatusDetailField;
        private InstanceStatusDetail instanceStatusDetailField;

        /// <summary>
        /// Instance ID
        /// </summary>
        [XmlElement(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the instance ID
        /// </summary>
        /// <param name="instanceId">Unique ID of the instance launched.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// The instance's availability zone.
        /// </summary>
        [XmlElement(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the instance's availability zone.
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Check if the AvailabilityZone property is set
        /// </summary>
        /// <returns>trie if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// Extra information regarding instance status.
        /// </summary>
        /// <remarks>
        /// Reports impaired functionality that arises from problems internal to the instance .
        /// </remarks>
        [XmlElement(ElementName = "InstanceStatusEvent")]
        public List<InstanceStatusEvent> InstanceStatusEvent
        {
            get { return this.instanceStatusEventField; }
            set { this.instanceStatusEventField = value; }
        }

        /// <summary>
        /// Sets the extra information regarding instance status.
        /// </summary>
        /// <param name="instanceStatusEvent">Collection of InstanceStatusEvent instances</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithInstanceStatusEvent(List<InstanceStatusEvent> instanceStatusEvent)
        {
            this.instanceStatusEventField = instanceStatusEvent;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceStatusEvent property is set
        /// </summary>
        /// <returns>true of the collection contains one or more events</returns>
        public bool IsSetInstanceStatusEvent()
        {
            return (InstanceStatusEvent.Count > 0);
        }

        /// <summary>
        /// The current state of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceState")]
        public InstanceState InstanceState
        {
            get { return this.instanceStateField; }
            set { this.instanceStateField = value; }
        }

        /// <summary>
        /// Sets the current state of the instance.
        /// </summary>
        /// <param name="instanceState">The current state of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithInstanceState(InstanceState instanceState)
        {
            this.instanceStateField = instanceState;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceState property is set
        /// </summary>
        /// <returns>true if the InstanceState property is set</returns>
        public bool IsSetInstanceState()
        {
            return this.instanceStateField != null;
        }

        /// <summary>
        /// System status detail.
        /// </summary>
        [XmlElementAttribute(ElementName = "SystemStatusDetail")]
        public InstanceStatusDetail SystemStatusDetail
        {
            get { return this.systemStatusDetailField; }
            set { this.systemStatusDetailField = value; }
        }

        /// <summary>
        /// Sets the system status detail.
        /// </summary>
        /// <param name="systemStatusDetail">System status</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithSystemStatusDetail(InstanceStatusDetail systemStatusDetail)
        {
            this.systemStatusDetailField = systemStatusDetail;
            return this;
        }

        /// <summary>
        /// Checks if the SystemStatusDetail property is set
        /// </summary>
        /// <returns>true if the SystemStatusDetail property is set</returns>
        public bool IsSetSystemStatusDetail()
        {
            return this.systemStatusDetailField != null;
        }

        /// <summary>
        /// Instance status detail.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceStatusDetail")]
        public InstanceStatusDetail InstanceStatusDetail
        {
            get { return this.instanceStatusDetailField; }
            set { this.instanceStatusDetailField = value; }
        }

        /// <summary>
        /// Sets the instance status detail.
        /// </summary>
        /// <param name="instanceStatusDetail">Instance status</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithInstanceStatusDetail(InstanceStatusDetail instanceStatusDetail)
        {
            this.instanceStatusDetailField = instanceStatusDetail;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceStatusDetail property is set
        /// </summary>
        /// <returns>true if the InstanceStatusDetail property is set</returns>
        public bool IsSetInstanceStatusDetail()
        {
            return this.instanceStatusDetailField != null;
        }
    }
}
