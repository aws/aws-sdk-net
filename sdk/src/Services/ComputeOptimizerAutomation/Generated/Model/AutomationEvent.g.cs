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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Contains information about an automation event.
    /// </summary>
    public partial class AutomationEvent
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with the automation event. 
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CompletedTimestamp. 
        /// <para>
        ///  The timestamp when the automation event completed. 
        /// </para>
        /// </summary>
        public DateTime? CompletedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CompletedTimestamp property is set.
        /// </summary>
        internal bool IsSetCompletedTimestamp() => this.CompletedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp when the automation event was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        ///  The estimated monthly cost savings associated with this automation event. 
        /// </para>
        /// </summary>
        public EstimatedMonthlySavings EstimatedMonthlySavings { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavings property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavings() => this.EstimatedMonthlySavings != null;

        /// <summary>
        /// Gets and sets the property EventDescription. 
        /// <para>
        ///  A description of the automation event. 
        /// </para>
        /// </summary>
        public string EventDescription { get; set; }

        /// <summary>
        /// Checks to see if the EventDescription property is set.
        /// </summary>
        internal bool IsSetEventDescription() => this.EventDescription != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        ///  The unique identifier for the automation event. 
        /// </para>
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        ///  The current status of the automation event. 
        /// </para>
        /// </summary>
        public EventStatus EventStatus { get; set; }

        /// <summary>
        /// Checks to see if the EventStatus property is set.
        /// </summary>
        internal bool IsSetEventStatus() => this.EventStatus != null;

        /// <summary>
        /// Gets and sets the property EventStatusReason. 
        /// <para>
        ///  The reason for the current event status. 
        /// </para>
        /// </summary>
        public string EventStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the EventStatusReason property is set.
        /// </summary>
        internal bool IsSetEventStatusReason() => this.EventStatusReason != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        ///  The type of automation event. 
        /// </para>
        /// </summary>
        public EventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property RecommendedActionId. 
        /// <para>
        ///  The ID of the recommended action associated with this automation event. 
        /// </para>
        /// </summary>
        public string RecommendedActionId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedActionId property is set.
        /// </summary>
        internal bool IsSetRecommendedActionId() => this.RecommendedActionId != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The Amazon Web Services Region where the automation event occurred. 
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the resource affected by the automation event.
        /// 
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        ///  The ID of the resource affected by the automation event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  The type of resource affected by the automation event. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        ///  The ID of the automation rule that triggered this event. 
        /// </para>
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// Checks to see if the RuleId property is set.
        /// </summary>
        internal bool IsSetRuleId() => this.RuleId != null;
    }
}
