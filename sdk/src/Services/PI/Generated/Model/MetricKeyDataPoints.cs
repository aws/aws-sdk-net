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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// A time-ordered series of data points, corresponding to a dimension of a Performance
    /// Insights metric.
    /// </summary>
    public partial class MetricKeyDataPoints
    {
        private List<DataPoint> _dataPoints = AWSConfigs.InitializeCollections ? new List<DataPoint>() : null;
        private ResponseResourceMetricKey _key;

        /// <summary>
        /// Gets and sets the property DataPoints. 
        /// <para>
        /// An array of timestamp-value pairs, representing measurements over a period of time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataPoint> DataPoints
        {
            get { return this._dataPoints; }
            set { this._dataPoints = value; }
        }

        // Check to see if DataPoints property is set
        internal bool IsSetDataPoints()
        {
            return this._dataPoints != null && (this._dataPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The dimensions to which the data points apply.
        /// </para>
        /// </summary>
        public ResponseResourceMetricKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

    }
}