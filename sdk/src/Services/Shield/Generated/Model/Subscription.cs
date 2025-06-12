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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
        private AutoRenew _autoRenew;
        private DateTime? _endTime;
        private List<Limit> _limits = AWSConfigs.InitializeCollections ? new List<Limit>() : null;
        private ProactiveEngagementStatus _proactiveEngagementStatus;
        private DateTime? _startTime;
        private string _subscriptionArn;
        private SubscriptionLimits _subscriptionLimits;
        private long? _timeCommitmentInSeconds;

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
        public AutoRenew AutoRenew
        {
            get { return this._autoRenew; }
            set { this._autoRenew = value; }
        }

        // Check to see if AutoRenew property is set
        internal bool IsSetAutoRenew()
        {
            return this._autoRenew != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time your subscription will end.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// Specifies how many protections of a given type you can create.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Limit> Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null && (this._limits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public ProactiveEngagementStatus ProactiveEngagementStatus
        {
            get { return this._proactiveEngagementStatus; }
            set { this._proactiveEngagementStatus = value; }
        }

        // Check to see if ProactiveEngagementStatus property is set
        internal bool IsSetProactiveEngagementStatus()
        {
            return this._proactiveEngagementStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the subscription, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubscriptionArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SubscriptionArn
        {
            get { return this._subscriptionArn; }
            set { this._subscriptionArn = value; }
        }

        // Check to see if SubscriptionArn property is set
        internal bool IsSetSubscriptionArn()
        {
            return this._subscriptionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionLimits. 
        /// <para>
        /// Limits settings for your subscription. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionLimits SubscriptionLimits
        {
            get { return this._subscriptionLimits; }
            set { this._subscriptionLimits = value; }
        }

        // Check to see if SubscriptionLimits property is set
        internal bool IsSetSubscriptionLimits()
        {
            return this._subscriptionLimits != null;
        }

        /// <summary>
        /// Gets and sets the property TimeCommitmentInSeconds. 
        /// <para>
        /// The length, in seconds, of the Shield Advanced subscription for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TimeCommitmentInSeconds
        {
            get { return this._timeCommitmentInSeconds; }
            set { this._timeCommitmentInSeconds = value; }
        }

        // Check to see if TimeCommitmentInSeconds property is set
        internal bool IsSetTimeCommitmentInSeconds()
        {
            return this._timeCommitmentInSeconds.HasValue; 
        }

    }
}