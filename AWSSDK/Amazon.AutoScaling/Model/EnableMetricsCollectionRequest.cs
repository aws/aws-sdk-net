/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the EnableMetricsCollection operation.
    /// Enables monitoring of group metrics for the            Auto Scaling group
    /// specified in <code>AutoScalingGroupName</code>.            You can specify the list
    /// of enabled metrics with the            <code>Metrics</code> parameter.        
    /// 
    ///         
    /// <para>
    ///             Auto Scaling metrics collection can be turned on only             if the
    /// <code>InstanceMonitoring</code> flag,             in the Auto Scaling group's launch
    /// configuration,             is set to <code>True</code>.        
    /// </para>
    /// </summary>
    public partial class EnableMetricsCollectionRequest : AmazonWebServiceRequest
    {
        private string _autoScalingGroupName;
        private string _granularity;
        private List<string> _metrics = new List<string>();


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name or ARN of the Auto Scaling group.
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableMetricsCollectionRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        ///             The granularity to associate with the metrics to collect.            Currently,
        /// the only legal granularity is "1Minute".        
        /// </para>
        /// </summary>
        public string Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }


        /// <summary>
        /// Sets the Granularity property
        /// </summary>
        /// <param name="granularity">The value to set for the Granularity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableMetricsCollectionRequest WithGranularity(string granularity)
        {
            this._granularity = granularity;
            return this;
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }


        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        ///             The list of metrics to collect.            If no metrics are specified,
        /// all metrics are enabled.            The following metrics are supported:        
        /// </para>
        ///         <ul>            <li>
        /// <para>
        /// GroupMinSize
        /// </para>
        /// </li>            <li>
        /// <para>
        /// GroupMaxSize
        /// </para>
        /// </li>            <li>
        /// <para>
        /// GroupDesiredCapacity
        /// </para>
        /// </li>            <li>
        /// <para>
        /// GroupInServiceInstances
        /// </para>
        /// </li>            <li>
        /// <para>
        /// GroupPendingInstances
        /// </para>
        /// </li>            <li>
        /// <para>
        /// GroupTerminatingInstances
        /// </para>
        /// </li>            <li>
        /// <para>
        /// GroupTotalInstances
        /// </para>
        /// </li>        </ul>
        /// </summary>
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        /// <summary>
        /// Sets the Metrics property
        /// </summary>
        /// <param name="metrics">The values to add to the Metrics collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableMetricsCollectionRequest WithMetrics(params string[] metrics)
        {
            foreach (var element in metrics)
            {
                this._metrics.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Metrics property
        /// </summary>
        /// <param name="metrics">The values to add to the Metrics collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableMetricsCollectionRequest WithMetrics(IEnumerable<string> metrics)
        {
            foreach (var element in metrics)
            {
                this._metrics.Add(element);
            }
            return this;
        }
        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

    }
}