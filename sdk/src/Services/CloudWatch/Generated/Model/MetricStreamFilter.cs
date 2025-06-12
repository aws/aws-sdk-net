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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This structure contains a metric namespace and optionally, a list of metric names,
    /// to either include in a metric stream or exclude from a metric stream.
    /// 
    ///  
    /// <para>
    /// A metric stream's filters can include up to 1000 total names. This limit applies to
    /// the sum of namespace names and metric names in the filters. For example, this could
    /// include 10 metric namespace filters with 99 metrics each, or 20 namespace filters
    /// with 49 metrics specified in each filter.
    /// </para>
    /// </summary>
    public partial class MetricStreamFilter
    {
        private List<string> _metricNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property MetricNames. 
        /// <para>
        /// The names of the metrics to either include or exclude from the metric stream. 
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, all metrics in the namespace are included or excluded,
        /// depending on whether this filter is specified as an exclude filter or an include filter.
        /// </para>
        ///  
        /// <para>
        /// Each metric name can contain only ASCII printable characters (ASCII range 32 through
        /// 126). Each metric name must contain at least one non-whitespace character.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MetricNames
        {
            get { return this._metricNames; }
            set { this._metricNames = value; }
        }

        // Check to see if MetricNames property is set
        internal bool IsSetMetricNames()
        {
            return this._metricNames != null && (this._metricNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the metric namespace for this filter.
        /// </para>
        ///  
        /// <para>
        /// The namespace can contain only ASCII printable characters (ASCII range 32 through
        /// 126). It must contain at least one non-whitespace character.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

    }
}