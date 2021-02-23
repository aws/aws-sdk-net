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
    /// A structure that contains an asset property value. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_Variant.html">Variant</a>
    /// in the <i>AWS IoT SiteWise API Reference</i>.
    /// 
    ///  
    /// <para>
    /// You must use expressions for all parameters in <code>AssetPropertyVariant</code>.
    /// The expressions accept literals, operators, functions, references, and substitution
    /// templates.
    /// </para>
    ///  <p class="title"> <b>Examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For literal values, the expressions must contain single quotes. For example, the value
    /// for the <code>integerValue</code> parameter can be <code>'100'</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For references, you must specify either variables or parameters. For example, the
    /// value for the <code>booleanValue</code> parameter can be <code>$variable.offline</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a substitution template, you must use <code>${}</code>, and the template must
    /// be in single quotes. A substitution template can also contain a combination of literals,
    /// operators, functions, references, and substitution templates. 
    /// </para>
    ///  
    /// <para>
    /// In the following example, the value for the <code>doubleValue</code> parameter uses
    /// a substitution template. 
    /// </para>
    ///  
    /// <para>
    ///  <code>'${$input.TemperatureInput.sensorData.temperature * 6 / 5 + 32}'</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-expressions.html">Expressions</a>
    /// in the <i>AWS IoT Events Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You must specify one of the following value types, depending on the <code>dataType</code>
    /// of the specified asset property. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_AssetProperty.html">AssetProperty</a>
    /// in the <i>AWS IoT SiteWise API Reference</i>.
    /// </para>
    /// </summary>
    public partial class AssetPropertyVariant
    {
        private string _booleanValue;
        private string _doubleValue;
        private string _integerValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// The asset property value is a Boolean value that must be <code>'TRUE'</code> or <code>'FALSE'</code>.
        /// You must use an expression, and the evaluated result should be a Boolean value.
        /// </para>
        /// </summary>
        public string BooleanValue
        {
            get { return this._booleanValue; }
            set { this._booleanValue = value; }
        }

        // Check to see if BooleanValue property is set
        internal bool IsSetBooleanValue()
        {
            return this._booleanValue != null;
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// The asset property value is a double. You must use an expression, and the evaluated
        /// result should be a double.
        /// </para>
        /// </summary>
        public string DoubleValue
        {
            get { return this._doubleValue; }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// The asset property value is an integer. You must use an expression, and the evaluated
        /// result should be an integer.
        /// </para>
        /// </summary>
        public string IntegerValue
        {
            get { return this._integerValue; }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue != null;
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The asset property value is a string. You must use an expression, and the evaluated
        /// result should be a string.
        /// </para>
        /// </summary>
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}