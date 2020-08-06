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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// A structure that contains value information. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_AssetPropertyValue.html">AssetPropertyValue</a>
    /// in the <i>AWS IoT SiteWise API Reference</i>.
    /// 
    ///  
    /// <para>
    /// For parameters that are string data type, you can specify the following options: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a string. For example, the <code>quality</code> value can be <code>'GOOD'</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an expression. For example, the <code>quality</code> value can be <code>$input.TemperatureInput.sensorData.quality</code>
    /// .
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-expressions.html">Expressions</a>
    /// in the <i>AWS IoT Events Developer Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssetPropertyValue
    {
        private string _quality;
        private AssetPropertyTimestamp _timestamp;
        private AssetPropertyVariant _value;

        /// <summary>
        /// Gets and sets the property Quality. 
        /// <para>
        /// The quality of the asset property value. The value must be <code>GOOD</code>, <code>BAD</code>,
        /// or <code>UNCERTAIN</code>. You can also specify an expression.
        /// </para>
        /// </summary>
        public string Quality
        {
            get { return this._quality; }
            set { this._quality = value; }
        }

        // Check to see if Quality property is set
        internal bool IsSetQuality()
        {
            return this._quality != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp associated with the asset property value. The default is the current
        /// event time.
        /// </para>
        /// </summary>
        public AssetPropertyTimestamp Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to send to an asset property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetPropertyVariant Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}