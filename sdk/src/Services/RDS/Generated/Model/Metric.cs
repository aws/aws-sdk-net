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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The representation of a metric.
    /// </summary>
    public partial class Metric
    {
        private MetricQuery _metricQuery;
        private string _name;
        private List<MetricReference> _references = AWSConfigs.InitializeCollections ? new List<MetricReference>() : null;
        private string _statisticsDetails;

        /// <summary>
        /// Gets and sets the property MetricQuery. 
        /// <para>
        /// The query to retrieve metric data points.
        /// </para>
        /// </summary>
        public MetricQuery MetricQuery
        {
            get { return this._metricQuery; }
            set { this._metricQuery = value; }
        }

        // Check to see if MetricQuery property is set
        internal bool IsSetMetricQuery()
        {
            return this._metricQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a metric.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// A list of metric references (thresholds).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricReference> References
        {
            get { return this._references; }
            set { this._references = value; }
        }

        // Check to see if References property is set
        internal bool IsSetReferences()
        {
            return this._references != null && (this._references.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatisticsDetails. 
        /// <para>
        /// The details of different statistics for a metric. The description might contain markdown.
        /// </para>
        /// </summary>
        public string StatisticsDetails
        {
            get { return this._statisticsDetails; }
            set { this._statisticsDetails = value; }
        }

        // Check to see if StatisticsDetails property is set
        internal bool IsSetStatisticsDetails()
        {
            return this._statisticsDetails != null;
        }

    }
}