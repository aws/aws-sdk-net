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
    /// This is the response object from the GetEventRule operation.
    /// </summary>
    public partial class GetEventRuleResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _eventPattern;
        private string _eventType;
        private List<string> _managedRules = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _notificationConfigurationArn;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _source;
        private Dictionary<string, EventRuleStatusSummary> _statusSummaryByRegion = AWSConfigs.InitializeCollections ? new Dictionary<string, EventRuleStatusSummary>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date when the EventRule was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// An additional event pattern used to further filter the events this EventRule receives.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-patterns.html">Amazon
        /// EventBridge event patterns</a> in the <i>Amazon EventBridge User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4096)]
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
        /// State-change Notification and AWS CloudWatch Alarm State Change. For more information,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from AWS services</a> in the <i>Amazon EventBridge User Guide</i>.
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
        /// Gets and sets the property ManagedRules. 
        /// <para>
        /// A list of managed rules from EventBridge that are are associated with this EventRule.
        /// </para>
        ///  <note> 
        /// <para>
        /// These are created by AWS User Notifications within your account so this EventRule
        /// functions.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ManagedRules
        {
            get { return this._managedRules; }
            set { this._managedRules = value; }
        }

        // Check to see if ManagedRules property is set
        internal bool IsSetManagedRules()
        {
            return this._managedRules != null && (this._managedRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The ARN of a NotificationConfiguration.
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
        /// A list of AWS Regions that send events to this EventRule.
        /// </para>
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
        /// Must match one of the valid EventBridge sources. Only AWS service sourced events are
        /// supported. For example, <c>aws.ec2</c> and <c>aws.cloudwatch</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from AWS services</a> in the <i>Amazon EventBridge User Guide</i>.
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

        /// <summary>
        /// Gets and sets the property StatusSummaryByRegion. 
        /// <para>
        /// A list of an EventRule's status by Region. Regions are mapped to EventRuleStatusSummary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, EventRuleStatusSummary> StatusSummaryByRegion
        {
            get { return this._statusSummaryByRegion; }
            set { this._statusSummaryByRegion = value; }
        }

        // Check to see if StatusSummaryByRegion property is set
        internal bool IsSetStatusSummaryByRegion()
        {
            return this._statusSummaryByRegion != null && (this._statusSummaryByRegion.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}