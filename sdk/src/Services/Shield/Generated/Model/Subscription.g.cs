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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Information about the Shield Advanced subscription for an account.
    /// </summary>
    public partial class Subscription
    {
        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// If <c>ENABLED</c>, the subscription will be automatically renewed at the end of the
        /// existing subscription period.
        /// </para>
        ///  
        /// <para>
        /// When you initally create a subscription, <c>AutoRenew</c> is set to <c>ENABLED</c>.
        /// You can change this by submitting an <c>UpdateSubscription</c> request. If the <c>UpdateSubscription</c>
        /// request does not included a value for <c>AutoRenew</c>, the existing value for <c>AutoRenew</c>
        /// remains unchanged.
        /// </para>
        /// </summary>
        public AutoRenew AutoRenew { get; set; }

        /// <summary>
        /// Checks to see if the AutoRenew property is set.
        /// </summary>
        internal bool IsSetAutoRenew() => this.AutoRenew != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time your subscription will end.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// Specifies how many protections of a given type you can create.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Limit> Limits { get; set; } = AWSConfigs.InitializeCollections ? new List<Limit>() : null;

        /// <summary>
        /// Checks to see if the Limits property is set.
        /// </summary>
        internal bool IsSetLimits() => this.Limits != null && (this.Limits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProactiveEngagementStatus. 
        /// <para>
        /// If <c>ENABLED</c>, the Shield Response Team (SRT) will use email and phone to notify
        /// contacts about escalations to the SRT and to initiate proactive customer support.
        /// </para>
        ///  
        /// <para>
        /// If <c>PENDING</c>, you have requested proactive engagement and the request is pending.
        /// The status changes to <c>ENABLED</c> when your request is fully processed.
        /// </para>
        ///  
        /// <para>
        /// If <c>DISABLED</c>, the SRT will not proactively notify contacts about escalations
        /// or to initiate proactive customer support. 
        /// </para>
        /// </summary>
        public ProactiveEngagementStatus ProactiveEngagementStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProactiveEngagementStatus property is set.
        /// </summary>
        internal bool IsSetProactiveEngagementStatus() => this.ProactiveEngagementStatus != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the subscription, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SubscriptionArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SubscriptionArn { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionArn property is set.
        /// </summary>
        internal bool IsSetSubscriptionArn() => this.SubscriptionArn != null;

        /// <summary>
        /// Gets and sets the property SubscriptionLimits. 
        /// <para>
        /// Limits settings for your subscription. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionLimits SubscriptionLimits { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionLimits property is set.
        /// </summary>
        internal bool IsSetSubscriptionLimits() => this.SubscriptionLimits != null;

        /// <summary>
        /// Gets and sets the property TimeCommitmentInSeconds. 
        /// <para>
        /// The length, in seconds, of the Shield Advanced subscription for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TimeCommitmentInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeCommitmentInSeconds property is set.
        /// </summary>
        internal bool IsSetTimeCommitmentInSeconds() => this.TimeCommitmentInSeconds.HasValue;
    }
}
