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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// A structure that contains timestamp information. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_TimeInNanos.html">TimeInNanos</a>
    /// in the <i>AWS IoT SiteWise API Reference</i>.
    /// 
    ///  
    /// <para>
    /// For parameters that are string data type, you can specify the following options:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a string. For example, the <code>timeInSeconds</code> value can be <code>'1586400675'</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an expression. For example, the <code>timeInSeconds</code> value can be <code>'${$input.TemperatureInput.sensorData.timestamp/1000}'</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-expressions.html">Expressions</a>
    /// in the <i>AWS IoT Events Developer Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssetPropertyTimestamp
    {
        private string _offsetInNanos;
        private string _timeInSeconds;

        /// <summary>
        /// Gets and sets the property OffsetInNanos. 
        /// <para>
        /// The nanosecond offset converted from <code>timeInSeconds</code>. The valid range is
        /// between 0-999999999. You can also specify an expression.
        /// </para>
        /// </summary>
        public string OffsetInNanos
        {
            get { return this._offsetInNanos; }
            set { this._offsetInNanos = value; }
        }

        // Check to see if OffsetInNanos property is set
        internal bool IsSetOffsetInNanos()
        {
            return this._offsetInNanos != null;
        }

        /// <summary>
        /// Gets and sets the property TimeInSeconds. 
        /// <para>
        /// The timestamp, in seconds, in the Unix epoch format. The valid range is between 1-31556889864403199.
        /// You can also specify an expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TimeInSeconds
        {
            get { return this._timeInSeconds; }
            set { this._timeInSeconds = value; }
        }

        // Check to see if TimeInSeconds property is set
        internal bool IsSetTimeInSeconds()
        {
            return this._timeInSeconds != null;
        }

    }
}