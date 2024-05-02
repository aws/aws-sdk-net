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
    /// Describes the percentile and percentile value.
    /// </summary>
    public partial class PercentPair
    {
        private double? _percent;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Percent. 
        /// <para>
        /// The percentile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? Percent
        {
            get { return this._percent; }
            set { this._percent = value; }
        }

        // Check to see if Percent property is set
        internal bool IsSetPercent()
        {
            return this._percent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the percentile.
        /// </para>
        /// </summary>
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}