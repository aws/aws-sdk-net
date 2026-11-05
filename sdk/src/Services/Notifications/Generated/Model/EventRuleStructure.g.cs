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
    /// Contains a complete list of fields related to an <c>EventRule</c>.
    /// </summary>
    public partial class EventRuleStructure
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>EventRule</c>. CloudFormation stack generates
        /// this ARN and then uses this ARN to associate with the <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the <c>EventRule</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        [AWSProperty(Required = true, Min = 0, Max = 4096)]
        public string EventPattern { get; set; }

        /// <summary>
        /// Checks to see if the EventPattern property is set.
        /// </summary>
        internal bool IsSetEventPattern() => this.EventPattern != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The event type this rule should match with the EventBridge events. It must match with
        /// atleast one of the valid EventBridge event types. For example, Amazon EC2 Instance
        /// State change Notification and Amazon CloudWatch State Change. For more information,
        /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from Amazon Web Services services</a> in the <i> Amazon EventBridge User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property ManagedRules. 
        /// <para>
        /// A list of Amazon EventBridge Managed Rule ARNs associated with this <c>EventRule</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// These are created by User Notifications within your account so your <c>EventRules</c>
        /// can function.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ManagedRules { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ManagedRules property is set.
        /// </summary>
        internal bool IsSetManagedRules() => this.ManagedRules != null && (this.ManagedRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The ARN for the <c>NotificationConfiguration</c> associated with this <c>EventRule</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetNotificationConfigurationArn() => this.NotificationConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A list of Amazon Web Services Regions that send events to this <c>EventRule</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The event source this rule should match with the EventBridge event sources. It must
        /// match with atleast one of the valid EventBridge event sources. Only Amazon Web Services
        /// service sourced events are supported. For example, <c>aws.ec2</c> and <c>aws.cloudwatch</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from Amazon Web Services services</a> in the <i> Amazon EventBridge User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property StatusSummaryByRegion. 
        /// <para>
        /// A list of an <c>EventRule</c>'s status by Region. Regions are mapped to <c>EventRuleStatusSummary</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, EventRuleStatusSummary> StatusSummaryByRegion { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, EventRuleStatusSummary>() : null;

        /// <summary>
        /// Checks to see if the StatusSummaryByRegion property is set.
        /// </summary>
        internal bool IsSetStatusSummaryByRegion() => this.StatusSummaryByRegion != null && (this.StatusSummaryByRegion.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
