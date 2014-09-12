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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// The user-specified message attribute value. For string data types, the value attribute
    /// has the same restrictions on the content as the message body. For more information,
    /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_SendMessage.html">SendMessage</a>.
    /// 
    ///         
    /// <para>
    /// Name, type, and value must not be empty or null. In addition, the message body should
    /// not be empty or null. All parts of the message attribute, including name, type, and
    /// value, are included in the message size restriction, which is currently 256 KB (262,144
    /// bytes).
    /// </para>
    /// </summary>
    public partial class MessageAttributeValue
    {
        private List<MemoryStream> _binaryListValues = new List<MemoryStream>();
        private MemoryStream _binaryValue;
        private string _dataType;
        private List<string> _stringListValues = new List<string>();
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property BinaryListValues. 
        /// <para>
        /// Not implemented. Reserved for future use.
        /// </para>
        /// </summary>
        public List<MemoryStream> BinaryListValues
        {
            get { return this._binaryListValues; }
            set { this._binaryListValues = value; }
        }

        // Check to see if BinaryListValues property is set
        internal bool IsSetBinaryListValues()
        {
            return this._binaryListValues != null && this._binaryListValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BinaryValue. 
        /// <para>
        /// Binary type attributes can store any binary data, for example, compressed data, encrypted
        /// data, or images.
        /// </para>
        /// </summary>
        public MemoryStream BinaryValue
        {
            get { return this._binaryValue; }
            set { this._binaryValue = value; }
        }

        // Check to see if BinaryValue property is set
        internal bool IsSetBinaryValue()
        {
            return this._binaryValue != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Amazon SQS supports the following logical data types: String, Number, and Binary.
        /// In addition, you can append your own custom labels. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSMessageAttributes.html#SQSMessageAttributes.DataTypes">Message
        /// Attribute Data Types</a>.
        /// </para>
        /// </summary>
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property StringListValues. 
        /// <para>
        /// Not implemented. Reserved for future use.
        /// </para>
        /// </summary>
        public List<string> StringListValues
        {
            get { return this._stringListValues; }
            set { this._stringListValues = value; }
        }

        // Check to see if StringListValues property is set
        internal bool IsSetStringListValues()
        {
            return this._stringListValues != null && this._stringListValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// Strings are Unicode with UTF8 binary encoding. For a list of code values, see <a href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
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