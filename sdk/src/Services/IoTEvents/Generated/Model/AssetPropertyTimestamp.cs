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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// A structure that contains timestamp information. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_TimeInNanos.html">TimeInNanos</a>
    /// in the <i>AWS IoT SiteWise API Reference</i>.
    /// 
    ///  
    /// <para>
    /// You must use expressions for all parameters in <c>AssetPropertyTimestamp</c>. The
    /// expressions accept literals, operators, functions, references, and substitution templates.
    /// </para>
    ///  
    /// <para>
    ///  <b>Examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For literal values, the expressions must contain single quotes. For example, the value
    /// for the <c>timeInSeconds</c> parameter can be <c>'1586400675'</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For references, you must specify either variables or input values. For example, the
    /// value for the <c>offsetInNanos</c> parameter can be <c>$variable.time</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a substitution template, you must use <c>${}</c>, and the template must be in
    /// single quotes. A substitution template can also contain a combination of literals,
    /// operators, functions, references, and substitution templates.
    /// </para>
    ///  
    /// <para>
    /// In the following example, the value for the <c>timeInSeconds</c> parameter uses a
    /// substitution template.
    /// </para>
    ///  
    /// <para>
    ///  <c>'${$input.TemperatureInput.sensorData.timestamp / 1000}'</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-expressions.html">Expressions</a>
    /// in the <i>AWS IoT Events Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssetPropertyTimestamp
    {
        private string _offsetInNanos;
        private string _timeInSeconds;

        /// <summary>
        /// Gets and sets the property OffsetInNanos. 
        /// <para>
        /// The nanosecond offset converted from <c>timeInSeconds</c>. The valid range is between
        /// 0-999999999.
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