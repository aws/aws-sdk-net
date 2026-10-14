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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAnomalySubscription operation. Updates an
    /// existing cost anomaly subscription. Specify the fields that you want to update. Omitted
    /// fields are unchanged. <note> <para> The JSON below describes the generic construct
    /// for each type. See <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_UpdateAnomalySubscription.html#API_UpdateAnomalySubscription_RequestParameters">Request
    /// Parameters</a> for possible values as they apply to <c>AnomalySubscription</c>. </para>
    /// </note>
    /// </summary>
    public partial class UpdateAnomalySubscriptionRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The update to the frequency value that subscribers receive notifications. 
        /// </para>
        /// </summary>
        public AnomalySubscriptionFrequency Frequency { get; set; }

        /// <summary>
        /// Checks to see if the Frequency property is set.
        /// </summary>
        internal bool IsSetFrequency() => this.Frequency != null;

        /// <summary>
        /// Gets and sets the property MonitorArnList. 
        /// <para>
        /// A list of cost anomaly monitor ARNs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MonitorArnList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MonitorArnList property is set.
        /// </summary>
        internal bool IsSetMonitorArnList() => this.MonitorArnList != null && (this.MonitorArnList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Subscribers. 
        /// <para>
        /// The update to the subscriber list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Subscriber> Subscribers { get; set; } = AWSConfigs.InitializeCollections ? new List<Subscriber>() : null;

        /// <summary>
        /// Checks to see if the Subscribers property is set.
        /// </summary>
        internal bool IsSetSubscribers() => this.Subscribers != null && (this.Subscribers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubscriptionArn. 
        /// <para>
        /// A cost anomaly subscription Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string SubscriptionArn { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionArn property is set.
        /// </summary>
        internal bool IsSetSubscriptionArn() => this.SubscriptionArn != null;

        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        /// The new name of the subscription. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionName property is set.
        /// </summary>
        internal bool IsSetSubscriptionName() => this.SubscriptionName != null;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// (deprecated)
        /// </para>
        ///  
        /// <para>
        /// The update to the threshold value for receiving notifications. 
        /// </para>
        ///  
        /// <para>
        /// This field has been deprecated. To update a threshold, use ThresholdExpression. Continued
        /// use of Threshold will be treated as shorthand syntax for a ThresholdExpression.
        /// </para>
        ///  
        /// <para>
        /// You can specify either Threshold or ThresholdExpression, but not both.
        /// </para>
        /// </summary>
        [Obsolete("Threshold has been deprecated in favor of ThresholdExpression")]
        [AWSProperty(Min = 0)]
        public double? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;

        /// <summary>
        /// Gets and sets the property ThresholdExpression. 
        /// <para>
        /// The update to the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
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
        /// You can specify either Threshold or ThresholdExpression, but not both.
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
        public Expression ThresholdExpression { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdExpression property is set.
        /// </summary>
        internal bool IsSetThresholdExpression() => this.ThresholdExpression != null;
    }
}
