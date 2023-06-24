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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DisableAwsNetworkPerformanceMetricSubscription operation.
    /// Disables Infrastructure Performance metric subscriptions.
    /// </summary>
    public partial class DisableAwsNetworkPerformanceMetricSubscriptionRequest : AmazonEC2Request
    {
        private string _destination;
        private MetricType _metric;
        private string _source;
        private StatisticType _statistic;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The target Region or Availability Zone that the metric subscription is disabled for.
        /// For example, <code>eu-north-1</code>.
        /// </para>
        /// </summary>
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The metric used for the disabled subscription.
        /// </para>
        /// </summary>
        public MetricType Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source Region or Availability Zone that the metric subscription is disabled for.
        /// For example, <code>us-east-1</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic used for the disabled subscription. 
        /// </para>
        /// </summary>
        public StatisticType Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

    }
}