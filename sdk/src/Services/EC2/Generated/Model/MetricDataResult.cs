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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains a single data point from a capacity metrics query, including the dimension
    /// values, timestamp, and metric values for that specific combination.
    /// </summary>
    public partial class MetricDataResult
    {
        private CapacityManagerDimension _dimension;
        private List<MetricValue> _metricValues = AWSConfigs.InitializeCollections ? new List<MetricValue>() : null;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        ///  The dimension values that identify this specific data point, such as account ID,
        /// region, and instance family. 
        /// </para>
        /// </summary>
        public CapacityManagerDimension Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property MetricValues. 
        /// <para>
        ///  The metric values and statistics for this data point, containing the actual capacity
        /// usage numbers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricValue> MetricValues
        {
            get { return this._metricValues; }
            set { this._metricValues = value; }
        }

        // Check to see if MetricValues property is set
        internal bool IsSetMetricValues()
        {
            return this._metricValues != null && (this._metricValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        ///  The timestamp for this data point, indicating when the capacity usage occurred. 
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}