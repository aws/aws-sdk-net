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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Specifies the action to take when data is missing during anomaly detection evaluation.
    /// </summary>
    public partial class AnomalyDetectorMissingDataAction
    {
        private bool? _markAsAnomaly;
        private bool? _skip;

        /// <summary>
        /// Gets and sets the property MarkAsAnomaly. 
        /// <para>
        /// Marks missing data points as anomalies.
        /// </para>
        /// </summary>
        public bool MarkAsAnomaly
        {
            get { return this._markAsAnomaly.GetValueOrDefault(); }
            set { this._markAsAnomaly = value; }
        }

        // Check to see if MarkAsAnomaly property is set
        internal bool IsSetMarkAsAnomaly()
        {
            return this._markAsAnomaly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Skip. 
        /// <para>
        /// Skips evaluation when data is missing.
        /// </para>
        /// </summary>
        public bool Skip
        {
            get { return this._skip.GetValueOrDefault(); }
            set { this._skip = value; }
        }

        // Check to see if Skip property is set
        internal bool IsSetSkip()
        {
            return this._skip.HasValue; 
        }

    }
}