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
    /// Defines an action to write to the Amazon DynamoDB table that you created. The standard
    /// action payload contains all attribute-value pairs that have the information about
    /// the detector model instance and the event that triggered the action. You can also
    /// customize the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_Payload.html">payload</a>.
    /// One column of the DynamoDB table receives all attribute-value pairs in the payload
    /// that you specify.
    /// 
    ///  
    /// <para>
    /// The <code>tableName</code> and <code>hashKeyField</code> values must match the table
    /// name and the partition key of the DynamoDB table. 
    /// </para>
    ///  <note> 
    /// <para>
    /// If the DynamoDB table also has a sort key, you must specify <code>rangeKeyField</code>.
    /// The <code>rangeKeyField</code> value must match the sort key.
    /// </para>
    ///  </note>  
    /// <para>
    /// The <code>hashKeyValue</code> and <code>rangeKeyValue</code> use substitution templates.
    /// These templates provide data at runtime. The syntax is <code>${sql-expression}</code>.
    /// </para>
    ///  
    /// <para>
    /// You can use expressions for parameters that are string data type. For more information,
    /// see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-expressions.html">Expressions</a>
    /// in the <i>AWS IoT Events Developer Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If the defined payload type is a string, <code>DynamoDBAction</code> writes non-JSON
    /// data to the DynamoDB table as binary data. The DynamoDB console displays the data
    /// as Base64-encoded text. The <code>payloadField</code> is <code>&lt;payload-field&gt;_raw</code>.
    /// </para>
    ///  </note>
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
        /// The name of the hash key (also called the partition key).
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
        ///  <code>STRING</code> - The hash key is a string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NUMBER</code> - The hash key is a number.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify <code>hashKeyType</code>, the default value is <code>STRING</code>.
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
        ///  <code>INSERT</code> - Insert data as a new item into the DynamoDB table. This item
        /// uses the specified hash key as a partition key. If you specified a range key, the
        /// item uses the range key as a sort key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE</code> - Update an existing item of the DynamoDB table with new data.
        /// This item's partition key must match the specified hash key. If you specified a range
        /// key, the range key must match the item's sort key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE</code> - Delete an existing item of the DynamoDB table. This item's
        /// partition key must match the specified hash key. If you specified a range key, the
        /// range key must match the item's sort key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify this parameter, AWS IoT Events triggers the <code>INSERT</code>
        /// operation.
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
        /// If you don't specify this parameter, the name of the DynamoDB column is <code>payload</code>.
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
        /// The name of the range key (also called the sort key).
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
        ///  <code>STRING</code> - The range key is a string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NUMBER</code> - The range key is number.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify <code>rangeKeyField</code>, the default value is <code>STRING</code>.
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