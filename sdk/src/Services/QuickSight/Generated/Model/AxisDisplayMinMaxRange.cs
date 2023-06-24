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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The minimum and maximum setup for an axis display range.
    /// </summary>
    public partial class AxisDisplayMinMaxRange
    {
        private double? _maximum;
        private double? _minimum;

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum setup for an axis display range.
        /// </para>
        /// </summary>
        public double Maximum
        {
            get { return this._maximum.GetValueOrDefault(); }
            set { this._maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this._maximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum setup for an axis display range.
        /// </para>
        /// </summary>
        public double Minimum
        {
            get { return this._minimum.GetValueOrDefault(); }
            set { this._minimum = value; }
        }

        // Check to see if Minimum property is set
        internal bool IsSetMinimum()
        {
            return this._minimum.HasValue; 
        }

    }
}