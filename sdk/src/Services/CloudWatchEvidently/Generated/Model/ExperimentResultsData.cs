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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// A structure that contains experiment results for one metric that is monitored in the
    /// experiment.
    /// </summary>
    public partial class ExperimentResultsData
    {
        private string _metricName;
        private ExperimentResultResponseType _resultStat;
        private string _treatmentName;
        private List<double> _values = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
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
        /// Gets and sets the property ResultStat. 
        /// <para>
        /// The experiment statistic that these results pertain to.
        /// </para>
        /// </summary>
        public ExperimentResultResponseType ResultStat
        {
            get { return this._resultStat; }
            set { this._resultStat = value; }
        }

        // Check to see if ResultStat property is set
        internal bool IsSetResultStat()
        {
            return this._resultStat != null;
        }

        /// <summary>
        /// Gets and sets the property TreatmentName. 
        /// <para>
        /// The treatment, or variation, that returned the <c>values</c> in this structure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string TreatmentName
        {
            get { return this._treatmentName; }
            set { this._treatmentName = value; }
        }

        // Check to see if TreatmentName property is set
        internal bool IsSetTreatmentName()
        {
            return this._treatmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values for the <c>metricName</c> that were recorded in the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100800)]
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}