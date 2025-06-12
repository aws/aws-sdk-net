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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the CreateEventRule operation.
    /// Creates an <a href="https://docs.aws.amazon.com/notifications/latest/userguide/glossary.html">
    /// <c>EventRule</c> </a> that is associated with a specified <c>NotificationConfiguration</c>.
    /// </summary>
    public partial class CreateEventRuleRequest : AmazonNotificationsRequest
    {
        private string _eventPattern;
        private string _eventType;
        private string _notificationConfigurationArn;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _source;

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// An additional event pattern used to further filter the events this <c>EventRule</c>
        /// receives.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-patterns.html">Amazon
        /// EventBridge event patterns</a> in the <i>Amazon EventBridge User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string EventPattern
        {
            get { return this._eventPattern; }
            set { this._eventPattern = value; }
        }

        // Check to see if EventPattern property is set
        internal bool IsSetEventPattern()
        {
            return this._eventPattern != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>NotificationConfiguration</c> associated
        /// with this <c>EventRule</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NotificationConfigurationArn
        {
            get { return this._notificationConfigurationArn; }
            set { this._notificationConfigurationArn = value; }
        }

        // Check to see if NotificationConfigurationArn property is set
        internal bool IsSetNotificationConfigurationArn()
        {
            return this._notificationConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A list of Amazon Web Services Regions that send events to this <c>EventRule</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}