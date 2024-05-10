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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the metric results.
    /// </summary>
    public partial class MetricResultV2
    {
        private List<MetricDataV2> _collections = AWSConfigs.InitializeCollections ? new List<MetricDataV2>() : null;
        private Dictionary<string, string> _dimensions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private MetricInterval _metricInterval;

        /// <summary>
        /// Gets and sets the property Collections. 
        /// <para>
        /// The set of metrics.
        /// </para>
        /// </summary>
        public List<MetricDataV2> Collections
        {
            get { return this._collections; }
            set { this._collections = value; }
        }

        // Check to see if Collections property is set
        internal bool IsSetCollections()
        {
            return this._collections != null && (this._collections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimension for the metrics.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricInterval. 
        /// <para>
        /// The interval period with the start and end time for the metrics.
        /// </para>
        /// </summary>
        public MetricInterval MetricInterval
        {
            get { return this._metricInterval; }
            set { this._metricInterval = value; }
        }

        // Check to see if MetricInterval property is set
        internal bool IsSetMetricInterval()
        {
            return this._metricInterval != null;
        }

    }
}