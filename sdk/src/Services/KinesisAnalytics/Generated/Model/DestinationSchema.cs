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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes the data format when records are written to the destination. For more information,
    /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-output.html">Configuring
    /// Application Output</a>.
    /// </summary>
    public partial class DestinationSchema
    {
        private RecordFormatType _recordFormatType;

        /// <summary>
        /// Gets and sets the property RecordFormatType. 
        /// <para>
        /// Specifies the format of the records on the output stream.
        /// </para>
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