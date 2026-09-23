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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EventTypeId. 
        /// <para>
        /// The system-generated ID of the event. For a complete list of event types and IDs,
        /// see <a href="https://docs.aws.amazon.com/codestar-notifications/latest/userguide/concepts.html#concepts-api">Notification
        /// concepts</a> in the <i>Developer Tools Console User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string EventTypeId { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeId property is set.
        /// </summary>
        internal bool IsSetEventTypeId() => this.EventTypeId != null;

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The name of the event.
        /// </para>
        /// </summary>
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service for which the event applies.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}
