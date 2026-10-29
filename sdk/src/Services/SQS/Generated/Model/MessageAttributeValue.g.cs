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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// The user-specified message attribute value. For string data types, the <c>Value</c>
    /// attribute has the same restrictions on the content as the message body. For more information,
    /// see <c> <a>SendMessage</a>.</c> 
    /// 
    ///  
    /// <para>
    ///  <c>Name</c>, <c>type</c>, <c>value</c> and the message body must not be empty or
    /// null. All parts of the message attribute, including <c>Name</c>, <c>Type</c>, and
    /// <c>Value</c>, are part of the message size restriction (1 MiB or 1,048,576 bytes).
    /// </para>
    /// </summary>
    public partial class MessageAttributeValue
    {
        /// <summary>
        /// Gets and sets the property BinaryListValues. 
        /// <para>
        /// Not implemented. Reserved for future use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemoryStream> BinaryListValues { get; set; } = AWSConfigs.InitializeCollections ? new List<MemoryStream>() : null;

        /// <summary>
        /// Checks to see if the BinaryListValues property is set.
        /// </summary>
        internal bool IsSetBinaryListValues() => this.BinaryListValues != null && (this.BinaryListValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BinaryValue. 
        /// <para>
        /// Binary type attributes can store any binary data, such as compressed data, encrypted
        /// data, or images.
        /// </para>
        /// </summary>
        public MemoryStream BinaryValue { get; set; }

        /// <summary>
        /// Checks to see if the BinaryValue property is set.
        /// </summary>
        internal bool IsSetBinaryValue() => this.BinaryValue != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Amazon SQS supports the following logical data types: <c>String</c>, <c>Number</c>,
        /// and <c>Binary</c>. For the <c>Number</c> data type, you must use <c>StringValue</c>.
        /// </para>
        ///  
        /// <para>
        /// You can also append custom labels. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-message-metadata.html#sqs-message-attributes">Amazon
        /// SQS Message Attributes</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property StringListValues. 
        /// <para>
        /// Not implemented. Reserved for future use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringListValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StringListValues property is set.
        /// </summary>
        internal bool IsSetStringListValues() => this.StringListValues != null && (this.StringListValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// Strings are Unicode with UTF-8 binary encoding. For a list of code values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">ASCII Printable
        /// Characters</a>.
        /// </para>
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
