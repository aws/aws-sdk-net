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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the EnableMetricsCollection operation.
    /// Enables group metrics collection for the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// You can use these metrics to track changes in an Auto Scaling group and to set alarms
    /// on threshold values. You can view group metrics using the Amazon EC2 Auto Scaling
    /// console or the CloudWatch console. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-cloudwatch-monitoring.html">Monitor
    /// CloudWatch metrics for your Auto Scaling groups and instances</a> in the <i>Amazon
    /// EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableMetricsCollectionRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private string _granularity;
        private List<string> _metrics = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The frequency at which Amazon EC2 Auto Scaling sends aggregated data to CloudWatch.
        /// The only valid value is <c>1Minute</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Identifies the metrics to enable.
        /// </para>
        ///  
        /// <para>
        /// You can specify one or more of the following metrics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GroupMinSize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupMaxSize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupDesiredCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupInServiceInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupPendingInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupStandbyInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupTerminatingInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupTotalInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupInServiceCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupPendingCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupStandbyCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupTerminatingCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupTotalCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolDesiredCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolWarmedCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolPendingCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolTerminatingCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolTotalCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupAndWarmPoolDesiredCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupAndWarmPoolTotalCapacity</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify <c>Granularity</c> and don't specify any metrics, all metrics are enabled.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-metrics.html">Amazon
        /// CloudWatch metrics for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}