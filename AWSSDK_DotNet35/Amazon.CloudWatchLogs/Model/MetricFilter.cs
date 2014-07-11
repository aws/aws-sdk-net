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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Metric filters can be used to express how Amazon CloudWatch Logs would extract metric
    /// observations from ingested log events and transform them to metric data in a CloudWatch
    /// metric.
    /// </summary>
    public partial class MetricFilter
    {
        private DateTime? _creationTime;
        private string _filterName;
        private string _filterPattern;
        private List<MetricTransformation> _metricTransformations = new List<MetricTransformation>();


        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property FilterName.
        /// </summary>
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }


        /// <summary>
        /// Gets and sets the property FilterPattern.
        /// </summary>
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }


        /// <summary>
        /// Gets and sets the property MetricTransformations.
        /// </summary>
        public List<MetricTransformation> MetricTransformations
        {
            get { return this._metricTransformations; }
            set { this._metricTransformations = value; }
        }

        // Check to see if MetricTransformations property is set
        internal bool IsSetMetricTransformations()
        {
            return this._metricTransformations != null && this._metricTransformations.Count > 0; 
        }

    }
}