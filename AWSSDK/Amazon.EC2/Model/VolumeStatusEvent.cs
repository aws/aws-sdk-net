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
    /// Volume Status Event
    /// </summary>
    public class VolumeStatusEvent
    {
        private string eventTypeField;
        private DateTime? notBeforeField;
        private DateTime? notAfterField;
        private string eventIdField;
        private string descriptionField;

        /// <summary>
        /// The event's type
        /// </summary>
        public string EventType
        {
            get { return this.eventTypeField; }
            set { this.eventTypeField = value; }
        }
        /// <summary>
        /// Checks if EventType property is set
        /// </summary>
        /// <returns>true if EventType property is set</returns>
        public bool IsSetEventType()
        {
            return this.eventTypeField != null;
        }
        /// <summary>
        /// Sets the event's type
        /// </summary>
        /// <param name="eventType">The new event type</param>
        /// <returns>this instance</returns>
        public VolumeStatusEvent WithEventType(string eventType)
        {
            this.eventTypeField = eventType;
            return this;
        }

        /// <summary>
        /// The earliest start time of this event
        /// </summary>
        public DateTime NotBefore
        {
            get { return this.notBeforeField.GetValueOrDefault(); }
            set { this.notBeforeField = value; }
        }
        /// <summary>
        /// Checks if NotBefore property is set
        /// </summary>
        /// <returns>true if NotBefore property is set</returns>
        public bool IsSetNotBefore()
        {
            return this.notBeforeField.HasValue;
        }
        /// <summary>
        /// Sets the earliest start time of this event
        /// </summary>
        /// <param name="notBefore">The new NotBefore value</param>
        /// <returns>this instance</returns>
        public VolumeStatusEvent WithNotBefore(DateTime notBefore)
        {
            this.notBeforeField = notBefore;
            return this;
        }

        /// <summary>
        /// The latest end time of this event
        /// </summary>
        public DateTime NotAfter
        {
            get { return this.notAfterField.GetValueOrDefault(); }
            set { this.notAfterField = value; }
        }
        /// <summary>
        /// Checks if NotAfter property is set
        /// </summary>
        /// <returns>true if NotAfter property is set</returns>
        public bool IsSetNotAfter()
        {
            return this.notAfterField.HasValue;
        }
        /// <summary>
        /// Sets the latest end time of this event
        /// </summary>
        /// <param name="notAfter">The new NotAfter value</param>
        /// <returns>this instance</returns>
        public VolumeStatusEvent WithNotAfter(DateTime notAfter)
        {
            this.notAfterField = notAfter;
            return this;
        }

        /// <summary>
        /// The ID of this event
        /// </summary>
        public string EventId
        {
            get { return this.eventIdField; }
            set { this.eventIdField = value; }
        }
        /// <summary>
        /// Checks if EventId property is set
        /// </summary>
        /// <returns>true if EventId property is set</returns>
        public bool IsSetEventId()
        {
            return this.eventIdField != null;
        }
        /// <summary>
        /// Sets the ID of this event
        /// </summary>
        /// <param name="eventId">The new event id</param>
        /// <returns>this instance</returns>
        public VolumeStatusEvent WithEventId(string eventId)
        {
            this.eventIdField = eventId;
            return this;
        }

        /// <summary>
        /// The description of this event
        /// </summary>
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }
        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }
        /// <summary>
        /// Sets the description of this event
        /// </summary>
        /// <param name="description">The new description</param>
        /// <returns>this instance</returns>
        public VolumeStatusEvent WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }
    }
}
