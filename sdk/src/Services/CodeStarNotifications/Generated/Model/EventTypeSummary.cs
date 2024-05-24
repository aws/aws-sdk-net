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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
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
namespace Amazon.CodeStarNotifications.Model
{
    /// <summary>
    /// Returns information about an event that has triggered a notification rule.
    /// </summary>
    public partial class EventTypeSummary
    {
        private string _eventTypeId;
        private string _eventTypeName;
        private string _resourceType;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property EventTypeId. 
        /// <para>
        /// The system-generated ID of the event. For a complete list of event types and IDs,
        /// see <a href="https://docs.aws.amazon.com/codestar-notifications/latest/userguide/concepts.html#concepts-api">Notification
        /// concepts</a> in the <i>Developer Tools Console User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string EventTypeId
        {
            get { return this._eventTypeId; }
            set { this._eventTypeId = value; }
        }

        // Check to see if EventTypeId property is set
        internal bool IsSetEventTypeId()
        {
            return this._eventTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The name of the event.
        /// </para>
        /// </summary>
        public string EventTypeName
        {
            get { return this._eventTypeName; }
            set { this._eventTypeName = value; }
        }

        // Check to see if EventTypeName property is set
        internal bool IsSetEventTypeName()
        {
            return this._eventTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ResourceType
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service for which the event applies.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}