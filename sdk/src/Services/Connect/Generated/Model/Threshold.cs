/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A <code>Threshold</code> object that includes a comparison and <code>ThresholdValue</code>
    /// to compare to. Used with service level metrics.
    /// </summary>
    public partial class Threshold
    {
        private Comparison _comparison;
        private double? _thresholdValue;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The Threshold to use to compare service level metrics to. Only "Less than" (LT) comparisons
        /// are supported.
        /// </para>
        /// </summary>
        public Comparison Comparison
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
        /// The value of the threshold to compare the metric to. Only "Less than" (LT) comparisons
        /// are supported.
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