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
    /// Defines an action to write to the Amazon DynamoDB table that you created. The default
    /// action payload contains all the information about the detector model instance and
    /// the event that triggered the action. You can customize the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_Payload.html">payload</a>.
    /// A separate column of the DynamoDB table receives one attribute-value pair in the payload
    /// that you specify.
    /// 
    ///  
    /// <para>
    /// You must use expressions for all parameters in <c>DynamoDBv2Action</c>. The expressions
    /// accept literals, operators, functions, references, and substitution templates.
    /// </para>
    ///  
    /// <para>
    ///  <b>Examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For literal values, the expressions must contain single quotes. For example, the value
    /// for the <c>tableName</c> parameter can be <c>'GreenhouseTemperatureTable'</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For references, you must specify either variables or input values. For example, the
    /// value for the <c>tableName</c> parameter can be <c>$variable.ddbtableName</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a substitution template, you must use <c>${}</c>, and the template must be in
    /// single quotes. A substitution template can also contain a combination of literals,
    /// operators, functions, references, and substitution templates.
    /// </para>
    ///  
    /// <para>
    /// In the following example, the value for the <c>contentExpression</c> parameter in
    /// <c>Payload</c> uses a substitution template. 
    /// </para>
    ///  
    /// <para>
    ///  <c>'{\"sensorID\": \"${$input.GreenhouseInput.sensor_id}\", \"temperature\": \"${$input.GreenhouseInput.temperature
    /// * 9 / 5 + 32}\"}'</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a string concatenation, you must use <c>+</c>. A string concatenation can also
    /// contain a combination of literals, operators, functions, references, and substitution
    /// templates.
    /// </para>
    ///  
    /// <para>
    /// In the following example, the value for the <c>tableName</c> parameter uses a string
    /// concatenation. 
    /// </para>
    ///  
    /// <para>
    ///  <c>'GreenhouseTemperatureTable ' + $input.GreenhouseInput.date</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-expressions.html">Expressions</a>
    /// in the <i>AWS IoT Events Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The value for the <c>type</c> parameter in <c>Payload</c> must be <c>JSON</c>.
    /// </para>
    /// </summary>
    public partial class DynamoDBv2Action
    {
        private Payload _payload;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property Payload.
        /// </summary>
        public Payload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the DynamoDB table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}