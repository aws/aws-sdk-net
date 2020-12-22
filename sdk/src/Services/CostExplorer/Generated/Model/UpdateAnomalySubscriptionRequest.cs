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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAnomalySubscription operation.
    /// Updates an existing cost anomaly monitor subscription.
    /// </summary>
    public partial class UpdateAnomalySubscriptionRequest : AmazonCostExplorerRequest
    {
        private AnomalySubscriptionFrequency _frequency;
        private List<string> _monitorArnList = new List<string>();
        private List<Subscriber> _subscribers = new List<Subscriber>();
        private string _subscriptionArn;
        private string _subscriptionName;
        private double? _threshold;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        ///  The update to the frequency value at which subscribers will receive notifications.
        /// 
        /// </para>
        /// </summary>
        public AnomalySubscriptionFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorArnList. 
        /// <para>
        ///  A list of cost anomaly monitor ARNs. 
        /// </para>
        /// </summary>
        public List<string> MonitorArnList
        {
            get { return this._monitorArnList; }
            set { this._monitorArnList = value; }
        }

        // Check to see if MonitorArnList property is set
        internal bool IsSetMonitorArnList()
        {
            return this._monitorArnList != null && this._monitorArnList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subscribers. 
        /// <para>
        ///  The update to the subscriber list. 
        /// </para>
        /// </summary>
        public List<Subscriber> Subscribers
        {
            get { return this._subscribers; }
            set { this._subscribers = value; }
        }

        // Check to see if Subscribers property is set
        internal bool IsSetSubscribers()
        {
            return this._subscribers != null && this._subscribers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubscriptionArn. 
        /// <para>
        ///  A cost anomaly subscription Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        ///  The subscription's new name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this._subscriptionName != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        ///  The update to the threshold value for receiving notifications. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double Threshold
        {
            get { return this._threshold.GetValueOrDefault(); }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

    }
}