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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Specifies the format of records read from the source stream.
    /// </summary>
    public partial class RecordConfiguration
    {
        private string _gsrSchemaARN;
        private RecordFormatType _recordFormatType;

        /// <summary>
        /// Gets and sets the property GSRSchemaARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Glue Schema Registry schema
        /// used to validate records. Required when the channel destination is a streaming table
        /// (Amazon S3 Tables), for both the <c>JSON</c> and <c>GSR_JSON</c> record formats.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string GSRSchemaARN
        {
            get { return this._gsrSchemaARN; }
            set { this._gsrSchemaARN = value; }
        }

        // Check to see if GSRSchemaARN property is set
        internal bool IsSetGSRSchemaARN()
        {
            return this._gsrSchemaARN != null;
        }

        /// <summary>
        /// Gets and sets the property RecordFormatType. 
        /// <para>
        /// The format of records on the source stream. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GSR_JSON</c> - Supported only for streaming table (Amazon S3 Tables) destinations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JSON</c> - Supported for both general purpose Amazon S3 and streaming table destinations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STRING</c> - Supported only for general purpose Amazon S3 destinations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BYTE_ARRAY</c> - Supported only for general purpose Amazon S3 destinations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordFormatType RecordFormatType
        {
            get { return this._recordFormatType; }
            set { this._recordFormatType = value; }
        }

        // Check to see if RecordFormatType property is set
        internal bool IsSetRecordFormatType()
        {
            return this._recordFormatType != null;
        }

    }
}