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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// An <c>AnomalySubscription</c> resource (also referred to as an alert subscription)
    /// sends notifications about specific anomalies that meet an alerting criteria defined
    /// by you.
    /// 
    ///  
    /// <para>
    /// You can specify the frequency of the alerts and the subscribers to notify.
    /// </para>
    ///  
    /// <para>
    /// Anomaly subscriptions can be associated with one or more <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AnomalyMonitor.html">
    /// <c>AnomalyMonitor</c> </a> resources, and they only send notifications about anomalies
    /// detected by those associated monitors. You can also configure a threshold to further
    /// control which anomalies are included in the notifications.
    /// </para>
    ///  
    /// <para>
    /// Anomalies that don’t exceed the chosen threshold and therefore don’t trigger notifications
    /// from an anomaly subscription will still be available on the console and from the <a
    /// href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_GetAnomalies.html">
    /// <c>GetAnomalies</c> </a> API.
    /// </para>
    /// </summary>
    public partial class AnomalySubscription
    {
        private string _accountId;
        private AnomalySubscriptionFrequency _frequency;
        private List<string> _monitorArnList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Subscriber> _subscribers = AWSConfigs.InitializeCollections ? new List<Subscriber>() : null;
        private string _subscriptionArn;
        private string _subscriptionName;
        private double? _threshold;
        private Expression _thresholdExpression;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Your unique account identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The frequency that anomaly notifications are sent. Notifications are sent either over
        /// email (for DAILY and WEEKLY frequencies) or SNS (for IMMEDIATE frequency). For more
        /// information, see <a href="https://docs.aws.amazon.com/cost-management/latest/userguide/ad-SNS.html">Creating
        /// an Amazon SNS topic for anomaly notifications</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of cost anomaly monitors. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> MonitorArnList
        {
            get { return this._monitorArnList; }
            set { this._monitorArnList = value; }
        }

        // Check to see if MonitorArnList property is set
        internal bool IsSetMonitorArnList()
        {
            return this._monitorArnList != null && (this._monitorArnList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subscribers. 
        /// <para>
        /// A list of subscribers to notify. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Subscriber> Subscribers
        {
            get { return this._subscribers; }
            set { this._subscribers = value; }
        }

        // Check to see if Subscribers property is set
        internal bool IsSetSubscribers()
        {
            return this._subscribers != null && (this._subscribers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubscriptionArn. 
        /// <para>
        /// The <c>AnomalySubscription</c> Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The name for the subscription. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        /// (deprecated)
        /// </para>
        ///  
        /// <para>
        /// An absolute dollar value that must be exceeded by the anomaly's total impact (see
        /// <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Impact.html">Impact</a>
        /// for more details) for an anomaly notification to be generated.
        /// </para>
        ///  
        /// <para>
        /// This field has been deprecated. To specify a threshold, use ThresholdExpression. Continued
        /// use of Threshold will be treated as shorthand syntax for a ThresholdExpression.
        /// </para>
        ///  
        /// <para>
        /// One of Threshold or ThresholdExpression is required for this resource. You cannot
        /// specify both.
        /// </para>
        /// </summary>
        [Obsolete("Threshold has been deprecated in favor of ThresholdExpression")]
        [AWSProperty(Min=0)]
        public double? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdExpression. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object used to specify the anomalies that you want to generate alerts for. This supports
        /// dimensions and nested expressions. The supported dimensions are <c>ANOMALY_TOTAL_IMPACT_ABSOLUTE</c>
        /// and <c>ANOMALY_TOTAL_IMPACT_PERCENTAGE</c>, corresponding to an anomaly’s TotalImpact
        /// and TotalImpactPercentage, respectively (see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Impact.html">Impact</a>
        /// for more details). The supported nested expression types are <c>AND</c> and <c>OR</c>.
        /// The match option <c>GREATER_THAN_OR_EQUAL</c> is required. Values must be numbers
        /// between 0 and 10,000,000,000 in string format.
        /// </para>
        ///  
        /// <para>
        /// One of Threshold or ThresholdExpression is required for this resource. You cannot
        /// specify both.
        /// </para>
        ///  
        /// <para>
        /// The following are examples of valid ThresholdExpressions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Absolute threshold: <c>{ "Dimensions": { "Key": "ANOMALY_TOTAL_IMPACT_ABSOLUTE", "MatchOptions":
        /// [ "GREATER_THAN_OR_EQUAL" ], "Values": [ "100" ] } }</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Percentage threshold: <c>{ "Dimensions": { "Key": "ANOMALY_TOTAL_IMPACT_PERCENTAGE",
        /// "MatchOptions": [ "GREATER_THAN_OR_EQUAL" ], "Values": [ "100" ] } }</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AND</c> two thresholds together: <c>{ "And": [ { "Dimensions": { "Key": "ANOMALY_TOTAL_IMPACT_ABSOLUTE",
        /// "MatchOptions": [ "GREATER_THAN_OR_EQUAL" ], "Values": [ "100" ] } }, { "Dimensions":
        /// { "Key": "ANOMALY_TOTAL_IMPACT_PERCENTAGE", "MatchOptions": [ "GREATER_THAN_OR_EQUAL"
        /// ], "Values": [ "100" ] } } ] }</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OR</c> two thresholds together: <c>{ "Or": [ { "Dimensions": { "Key": "ANOMALY_TOTAL_IMPACT_ABSOLUTE",
        /// "MatchOptions": [ "GREATER_THAN_OR_EQUAL" ], "Values": [ "100" ] } }, { "Dimensions":
        /// { "Key": "ANOMALY_TOTAL_IMPACT_PERCENTAGE", "MatchOptions": [ "GREATER_THAN_OR_EQUAL"
        /// ], "Values": [ "100" ] } } ] }</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Expression ThresholdExpression
        {
            get { return this._thresholdExpression; }
            set { this._thresholdExpression = value; }
        }

        // Check to see if ThresholdExpression property is set
        internal bool IsSetThresholdExpression()
        {
            return this._thresholdExpression != null;
        }

    }
}