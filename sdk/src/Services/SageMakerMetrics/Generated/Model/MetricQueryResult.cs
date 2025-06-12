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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
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
namespace Amazon.SageMakerMetrics.Model
{
    /// <summary>
    /// The result of a query to retrieve training metrics from SageMaker.
    /// </summary>
    public partial class MetricQueryResult
    {
        private string _message;
        private List<double> _metricValues = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private MetricQueryResultStatus _status;
        private List<long> _xAxisValues = AWSConfigs.InitializeCollections ? new List<long>() : null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message describing the status of the metric query.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MetricValues. 
        /// <para>
        /// The metric values retrieved by the query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<double> MetricValues
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the metric query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricQueryResultStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property XAxisValues. 
        /// <para>
        /// The values for the x-axis of the metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<long> XAxisValues
        {
            get { return this._xAxisValues; }
            set { this._xAxisValues = value; }
        }

        // Check to see if XAxisValues property is set
        internal bool IsSetXAxisValues()
        {
            return this._xAxisValues != null && (this._xAxisValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}