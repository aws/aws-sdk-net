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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// A custom SQS message attribute (data type plus string or binary value).
    /// </summary>
    public partial class SqsMessageAttributeValue
    {
        private string _binaryValue;
        private string _dataType;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property BinaryValue. 
        /// <para>
        /// Base64-encoded literal binary attribute value.
        /// </para>
        /// </summary>
        public string BinaryValue
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
        /// Attribute data type. Requiredness, the accepted vocabulary, and any custom label belong
        /// to SQS, which rejects an attribute without a data type on delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property StringValue. 
        /// <para>
        /// String attribute value. A JSONata expression resolves once per delivered event.
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