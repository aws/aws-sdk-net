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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Contains information about a detector's configuration.
    /// </summary>
    public partial class AnomalyDetectorConfig
    {
        private Frequency _anomalyDetectorFrequency;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorFrequency. 
        /// <para>
        /// The frequency at which the detector analyzes its source data.
        /// </para>
        /// </summary>
        public Frequency AnomalyDetectorFrequency
        {
            get { return this._anomalyDetectorFrequency; }
            set { this._anomalyDetectorFrequency = value; }
        }

        // Check to see if AnomalyDetectorFrequency property is set
        internal bool IsSetAnomalyDetectorFrequency()
        {
            return this._anomalyDetectorFrequency != null;
        }

    }
}