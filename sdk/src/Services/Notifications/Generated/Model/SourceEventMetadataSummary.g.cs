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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Contains metadata about the event that caused the <c>NotificationEvent</c>. For other
    /// specific values, see <c>sourceEventMetadata</c>.
    /// </summary>
    public partial class SourceEventMetadataSummary
    {
        /// <summary>
        /// Gets and sets the property EventOriginRegion. 
        /// <para>
        /// The Region where the notification originated.
        /// </para>
        ///  
        /// <para>
        /// Unavailable for aggregated notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 32)]
        public string EventOriginRegion { get; set; }

        /// <summary>
        /// Checks to see if the EventOriginRegion property is set.
        /// </summary>
        internal bool IsSetEventOriginRegion() => this.EventOriginRegion != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The event type to match.
        /// </para>
        ///  
        /// <para>
        /// Must match one of the valid Amazon EventBridge event types. For example, EC2 Instance
        /// State-change Notification and Amazon CloudWatch Alarm State Change. For more information,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from Amazon Web Services services</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The matched event source.
        /// </para>
        ///  
        /// <para>
        /// Must match one of the valid EventBridge sources. Only Amazon Web Services service
        /// sourced events are supported. For example, <c>aws.ec2</c> and <c>aws.cloudwatch</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from Amazon Web Services services</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
