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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// The user-specified message system attribute value. For string data types, the <code>Value</code>
    /// attribute has the same restrictions on the content as the message body. For more information,
    /// see <code> <a>SendMessage</a>.</code> 
    /// 
    ///  
    /// <para>
    ///  <code>Name</code>, <code>type</code>, <code>value</code> and the message body must
    /// not be empty or null.
    /// </para>
    /// </summary>
    public partial class MessageSystemAttributeValue
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
        /// Binary type attributes can store any binary data, such as compressed data, encrypted
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
        /// Amazon SQS supports the following logical data types: <code>String</code>, <code>Number</code>,
        /// and <code>Binary</code>. For the <code>Number</code> data type, you must use <code>StringValue</code>.
        /// </para>
        ///  
        /// <para>
        /// You can also append custom labels. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-message-metadata.html#sqs-message-attributes">Amazon
        /// SQS Message Attributes</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Strings are Unicode with UTF-8 binary encoding. For a list of code values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">ASCII Printable
        /// Characters</a>.
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