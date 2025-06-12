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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
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
namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Container for the parameters to the PublishMetrics operation.
    /// <b>Internal only</b>. Publishes environment health metrics to Amazon CloudWatch.
    /// </summary>
    [Obsolete("This type is for internal use and not meant for public use. Data set for this type will be ignored.")]
    public partial class PublishMetricsRequest : AmazonMWAARequest
    {
        private string _environmentName;
        private List<MetricDatum> _metricData = AWSConfigs.InitializeCollections ? new List<MetricDatum>() : null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        ///  <b>Internal only</b>. The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricData. 
        /// <para>
        ///  <b>Internal only</b>. Publishes metrics to Amazon CloudWatch. To learn more about
        /// the metrics published to Amazon CloudWatch, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/cw-metrics.html">Amazon
        /// MWAA performance metrics in Amazon CloudWatch</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricDatum> MetricData
        {
            get { return this._metricData; }
            set { this._metricData = value; }
        }

        // Check to see if MetricData property is set
        internal bool IsSetMetricData()
        {
            return this._metricData != null && (this._metricData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}