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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Structured detail about the current evaluation.
    /// </summary>
    public partial class AlertStateData
    {
        private double? _thresholdBreached;

        /// <summary>
        /// Gets and sets the property ThresholdBreached. 
        /// <para>
        /// For COUNT_OF_RESULTS alerts, the row count that breached; null for FIELD_VALUE (multi-contributor)
        /// alerts.
        /// </para>
        /// </summary>
        public double? ThresholdBreached
        {
            get { return this._thresholdBreached; }
            set { this._thresholdBreached = value; }
        }

        // Check to see if ThresholdBreached property is set
        internal bool IsSetThresholdBreached()
        {
            return this._thresholdBreached.HasValue; 
        }

    }
}