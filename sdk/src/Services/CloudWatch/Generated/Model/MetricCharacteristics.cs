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
    /// This object includes parameters that you can use to provide information to CloudWatch
    /// to help it build more accurate anomaly detection models.
    /// </summary>
    public partial class MetricCharacteristics
    {
        private bool? _periodicSpikes;

        /// <summary>
        /// Gets and sets the property PeriodicSpikes. 
        /// <para>
        /// Set this parameter to <c>true</c> if values for this metric consistently include spikes
        /// that should not be considered to be anomalies. With this set to <c>true</c>, CloudWatch
        /// will expect to see spikes that occurred consistently during the model training period,
        /// and won't flag future similar spikes as anomalies.
        /// </para>
        /// </summary>
        public bool? PeriodicSpikes
        {
            get { return this._periodicSpikes; }
            set { this._periodicSpikes = value; }
        }

        // Check to see if PeriodicSpikes property is set
        internal bool IsSetPeriodicSpikes()
        {
            return this._periodicSpikes.HasValue; 
        }

    }
}