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
    /// Volume Status Action
    /// </summary>
    public class VolumeStatusAction
    {
        private string codeField;
        private string eventIdField;
        private string eventTypeField;
        private string descriptionField;

        /// <summary>
        /// The code identifying the action.
        /// </summary>
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }
        /// <summary>
        /// Checks if Code property is set
        /// </summary>
        /// <returns>true if Code property is set</returns>
        public bool IsSetCode()
        {
            return this.codeField != null;
        }
        /// <summary>
        /// Sets the code identifying the action.
        /// </summary>
        /// <param name="code">The new code</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatusAction WithCode(string code)
        {
            this.codeField = code;
            return this;
        }

        /// <summary>
        /// The ID of the event associated with this action.
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
        /// Sets the ID of the event associated with this action.
        /// </summary>
        /// <param name="eventId">The new event id</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatusAction WithEventId(string eventId)
        {
            this.eventIdField = eventId;
            return this;
        }

        /// <summary>
        /// The event type associated with this action.
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
        /// Sets the event type associated with this action.
        /// </summary>
        /// <param name="eventType">The new event type</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatusAction WithEventType(string eventType)
        {
            this.eventTypeField = eventType;
            return this;
        }

        /// <summary>
        /// A description of the action.
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
        /// Sets a description of the action.
        /// </summary>
        /// <param name="description">The new description</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatusAction WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }
    }
}
