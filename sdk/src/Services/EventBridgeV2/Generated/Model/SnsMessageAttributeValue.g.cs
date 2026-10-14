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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// A custom SNS message attribute (data type plus string or binary value).
    /// </summary>
    public partial class SnsMessageAttributeValue
    {
        /// <summary>
        /// Gets and sets the property BinaryValue. Base64-encoded literal binary attribute value.
        /// </summary>
        public string BinaryValue { get; set; }

        /// <summary>
        /// Checks to see if the BinaryValue property is set.
        /// </summary>
        internal bool IsSetBinaryValue() => this.BinaryValue != null;

        /// <summary>
        /// Gets and sets the property DataType. Attribute data type. Requiredness and the accepted
        /// vocabulary belong to SNS, which rejects an attribute without a data type on delivery.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property StringValue. String attribute value. A JSONata expression
        /// resolves once per delivered event.
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
