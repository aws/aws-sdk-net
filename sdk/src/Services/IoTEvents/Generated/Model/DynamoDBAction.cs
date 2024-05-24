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
    /// Defines an action to write to the Amazon DynamoDB table that you created. The standard
    /// action payload contains all the information about the detector model instance and
    /// the event that triggered the action. You can customize the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_Payload.html">payload</a>.
    /// One column of the DynamoDB table receives all attribute-value pairs in the payload
    /// that you specify.
    /// 
    ///  
    /// <para>
    /// You must use expressions for all parameters in <c>DynamoDBAction</c>. The expressions
    /// accept literals, operators, functions, references, and substitution templates.
    /// </para>
    ///  
    /// <para>
    ///  <b>Examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For literal values, the expressions must contain single quotes. For example, the value
    /// for the <c>hashKeyType</c> parameter can be <c>'STRING'</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For references, you must specify either variables or input values. For example, the
    /// value for the <c>hashKeyField</c> parameter can be <c>$input.GreenhouseInput.name</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a substitution template, you must use <c>${}</c>, and the template must be in
    /// single quotes. A substitution template can also contain a combination of literals,
    /// operators, functions, references, and substitution templates.
    /// </para>
    ///  
    /// <para>
    /// In the following example, the value for the <c>hashKeyValue</c> parameter uses a substitution
    /// template. 
    /// </para>
    ///  
    /// <para>
    ///  <c>'${$input.GreenhouseInput.temperature * 6 / 5 + 32} in Fahrenheit'</c> 
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
    /// If the defined payload type is a string, <c>DynamoDBAction</c> writes non-JSON data
    /// to the DynamoDB table as binary data. The DynamoDB console displays the data as Base64-encoded
    /// text. The value for the <c>payloadField</c> parameter is <c>&lt;payload-field&gt;_raw</c>.
    /// </para>
    /// </summary>
    public partial class DynamoDBAction
    {
        private string _hashKeyField;
        private string _hashKeyType;
        private string _hashKeyValue;
        private string _operation;
        private Payload _payload;
        private string _payloadField;
        private string _rangeKeyField;
        private string _rangeKeyType;
        private string _rangeKeyValue;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property HashKeyField. 
        /// <para>
        /// The name of the hash key (also called the partition key). The <c>hashKeyField</c>
        /// value must match the partition key of the target DynamoDB table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HashKeyField
        {
            get { return this._hashKeyField; }
            set { this._hashKeyField = value; }
        }

        // Check to see if HashKeyField property is set
        internal bool IsSetHashKeyField()
        {
            return this._hashKeyField != null;
        }

        /// <summary>
        /// Gets and sets the property HashKeyType. 
        /// <para>
        /// The data type for the hash key (also called the partition key). You can specify the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>'STRING'</c> - The hash key is a string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>'NUMBER'</c> - The hash key is a number.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify <c>hashKeyType</c>, the default value is <c>'STRING'</c>.
        /// </para>
        /// </summary>
        public string HashKeyType
        {
            get { return this._hashKeyType; }
            set { this._hashKeyType = value; }
        }

        // Check to see if HashKeyType property is set
        internal bool IsSetHashKeyType()
        {
            return this._hashKeyType != null;
        }

        /// <summary>
        /// Gets and sets the property HashKeyValue. 
        /// <para>
        /// The value of the hash key (also called the partition key).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HashKeyValue
        {
            get { return this._hashKeyValue; }
            set { this._hashKeyValue = value; }
        }

        // Check to see if HashKeyValue property is set
        internal bool IsSetHashKeyValue()
        {
            return this._hashKeyValue != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The type of operation to perform. You can specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>'INSERT'</c> - Insert data as a new item into the DynamoDB table. This item uses
        /// the specified hash key as a partition key. If you specified a range key, the item
        /// uses the range key as a sort key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>'UPDATE'</c> - Update an existing item of the DynamoDB table with new data. This
        /// item's partition key must match the specified hash key. If you specified a range key,
        /// the range key must match the item's sort key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>'DELETE'</c> - Delete an existing item of the DynamoDB table. This item's partition
        /// key must match the specified hash key. If you specified a range key, the range key
        /// must match the item's sort key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify this parameter, AWS IoT Events triggers the <c>'INSERT'</c> operation.
        /// </para>
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

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
        /// Gets and sets the property PayloadField. 
        /// <para>
        /// The name of the DynamoDB column that receives the action payload.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, the name of the DynamoDB column is <c>payload</c>.
        /// </para>
        /// </summary>
        public string PayloadField
        {
            get { return this._payloadField; }
            set { this._payloadField = value; }
        }

        // Check to see if PayloadField property is set
        internal bool IsSetPayloadField()
        {
            return this._payloadField != null;
        }

        /// <summary>
        /// Gets and sets the property RangeKeyField. 
        /// <para>
        /// The name of the range key (also called the sort key). The <c>rangeKeyField</c> value
        /// must match the sort key of the target DynamoDB table. 
        /// </para>
        /// </summary>
        public string RangeKeyField
        {
            get { return this._rangeKeyField; }
            set { this._rangeKeyField = value; }
        }

        // Check to see if RangeKeyField property is set
        internal bool IsSetRangeKeyField()
        {
            return this._rangeKeyField != null;
        }

        /// <summary>
        /// Gets and sets the property RangeKeyType. 
        /// <para>
        /// The data type for the range key (also called the sort key), You can specify the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>'STRING'</c> - The range key is a string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>'NUMBER'</c> - The range key is number.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify <c>rangeKeyField</c>, the default value is <c>'STRING'</c>.
        /// </para>
        /// </summary>
        public string RangeKeyType
        {
            get { return this._rangeKeyType; }
            set { this._rangeKeyType = value; }
        }

        // Check to see if RangeKeyType property is set
        internal bool IsSetRangeKeyType()
        {
            return this._rangeKeyType != null;
        }

        /// <summary>
        /// Gets and sets the property RangeKeyValue. 
        /// <para>
        /// The value of the range key (also called the sort key).
        /// </para>
        /// </summary>
        public string RangeKeyValue
        {
            get { return this._rangeKeyValue; }
            set { this._rangeKeyValue = value; }
        }

        // Check to see if RangeKeyValue property is set
        internal bool IsSetRangeKeyValue()
        {
            return this._rangeKeyValue != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the DynamoDB table. The <c>tableName</c> value must match the table name
        /// of the target DynamoDB table. 
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