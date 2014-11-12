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
    /// The output of the <a>DescribeMetricCollectionTypes</a> action.
    /// </summary>
    public partial class DescribeMetricCollectionTypesResult
    {
        private List<MetricGranularityType> _granularities = new List<MetricGranularityType>();
        private List<MetricCollectionType> _metrics = new List<MetricCollectionType>();


        /// <summary>
        /// Gets and sets the property Granularities. 
        /// <para>
        /// A list of granularities for the listed Metrics.
        /// </para>
        /// </summary>
        public List<MetricGranularityType> Granularities
        {
            get { return this._granularities; }
            set { this._granularities = value; }
        }

        /// <summary>
        /// Sets the Granularities property
        /// </summary>
        /// <param name="granularities">The values to add to the Granularities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMetricCollectionTypesResult WithGranularities(params MetricGranularityType[] granularities)
        {
            foreach (var element in granularities)
            {
                this._granularities.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Granularities property
        /// </summary>
        /// <param name="granularities">The values to add to the Granularities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMetricCollectionTypesResult WithGranularities(IEnumerable<MetricGranularityType> granularities)
        {
            foreach (var element in granularities)
            {
                this._granularities.Add(element);
            }
            return this;
        }
        // Check to see if Granularities property is set
        internal bool IsSetGranularities()
        {
            return this._granularities != null && this._granularities.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The list of Metrics collected. The following metrics are supported:        
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
        public List<MetricCollectionType> Metrics
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
        public DescribeMetricCollectionTypesResult WithMetrics(params MetricCollectionType[] metrics)
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
        public DescribeMetricCollectionTypesResult WithMetrics(IEnumerable<MetricCollectionType> metrics)
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