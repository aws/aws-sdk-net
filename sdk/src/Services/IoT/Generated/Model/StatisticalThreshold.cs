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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// A statistical ranking (percentile) that indicates a threshold value by which a behavior
    /// is determined to be in compliance or in violation of the behavior.
    /// </summary>
    public partial class StatisticalThreshold
    {
        private string _statistic;

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The percentile that resolves to a threshold value by which compliance with a behavior
        /// is determined. Metrics are collected over the specified period (<c>durationSeconds</c>)
        /// from all reporting devices in your account and statistical ranks are calculated. Then,
        /// the measurements from a device are collected over the same period. If the accumulated
        /// measurements from the device fall above or below (<c>comparisonOperator</c>) the value
        /// associated with the percentile specified, then the device is considered to be in compliance
        /// with the behavior, otherwise a violation occurs.
        /// </para>
        /// </summary>
        public string Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

    }
}