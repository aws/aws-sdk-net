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
    /// Selects the metrics in one namespace, for use in the <c>IncludeFilters</c> or <c>ExcludeFilters</c>
    /// parameter of <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_StartOTelEnrichment.html">StartOTelEnrichment</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UpdateOTelEnrichment.html">UpdateOTelEnrichment</a>.
    /// 
    ///  
    /// <para>
    /// A maximum of 100 selectors is allowed across <c>IncludeFilters</c> and <c>ExcludeFilters</c>
    /// combined.
    /// </para>
    /// </summary>
    public partial class OTelEnrichmentMetricSelector
    {
        private List<string> _metricNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property MetricNames. 
        /// <para>
        /// The names of the metrics to select within the namespace. Metric names are matched
        /// exactly and are case-sensitive. If this parameter is omitted, every metric in the
        /// namespace is selected.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 100 metric names is allowed for each selector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// The namespace of the metrics to select. Namespaces are matched exactly and are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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