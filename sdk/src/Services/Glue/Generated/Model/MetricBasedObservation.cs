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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the metric based observation generated based on evaluated data quality metrics.
    /// </summary>
    public partial class MetricBasedObservation
    {
        private string _metricName;
        private DataQualityMetricValues _metricValues;
        private List<string> _newRules = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _statisticId;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the data quality metric used for generating the observation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricValues. 
        /// <para>
        /// An object of type <c>DataQualityMetricValues</c> representing the analysis of the
        /// data quality metric value.
        /// </para>
        /// </summary>
        public DataQualityMetricValues MetricValues
        {
            get { return this._metricValues; }
            set { this._metricValues = value; }
        }

        // Check to see if MetricValues property is set
        internal bool IsSetMetricValues()
        {
            return this._metricValues != null;
        }

        /// <summary>
        /// Gets and sets the property NewRules. 
        /// <para>
        /// A list of new data quality rules generated as part of the observation based on the
        /// data quality metric value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NewRules
        {
            get { return this._newRules; }
            set { this._newRules = value; }
        }

        // Check to see if NewRules property is set
        internal bool IsSetNewRules()
        {
            return this._newRules != null && (this._newRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatisticId. 
        /// <para>
        /// The Statistic ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StatisticId
        {
            get { return this._statisticId; }
            set { this._statisticId = value; }
        }

        // Check to see if StatisticId property is set
        internal bool IsSetStatisticId()
        {
            return this._statisticId != null;
        }

    }
}