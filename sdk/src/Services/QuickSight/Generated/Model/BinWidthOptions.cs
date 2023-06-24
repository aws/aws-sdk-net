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
    /// The options that determine the bin width of a histogram.
    /// </summary>
    public partial class BinWidthOptions
    {
        private long? _binCountLimit;
        private double? _value;

        /// <summary>
        /// Gets and sets the property BinCountLimit. 
        /// <para>
        /// The options that determine the bin count limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public long BinCountLimit
        {
            get { return this._binCountLimit.GetValueOrDefault(); }
            set { this._binCountLimit = value; }
        }

        // Check to see if BinCountLimit property is set
        internal bool IsSetBinCountLimit()
        {
            return this._binCountLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The options that determine the bin width value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}