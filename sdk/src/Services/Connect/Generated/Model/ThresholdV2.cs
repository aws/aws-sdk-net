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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the threshold for service level metrics.
    /// </summary>
    public partial class ThresholdV2
    {
        private string _comparison;
        private double? _thresholdValue;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The type of comparison. Only "less than" (LT) comparisons are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string Comparison
        {
            get { return this._comparison; }
            set { this._comparison = value; }
        }

        // Check to see if Comparison property is set
        internal bool IsSetComparison()
        {
            return this._comparison != null;
        }

        /// <summary>
        /// Gets and sets the property ThresholdValue. 
        /// <para>
        /// The threshold value to compare.
        /// </para>
        /// </summary>
        public double ThresholdValue
        {
            get { return this._thresholdValue.GetValueOrDefault(); }
            set { this._thresholdValue = value; }
        }

        // Check to see if ThresholdValue property is set
        internal bool IsSetThresholdValue()
        {
            return this._thresholdValue.HasValue; 
        }

    }
}