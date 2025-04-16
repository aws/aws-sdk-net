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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// The container for the records event.
    /// </summary>
    public partial class RecordsEvent
        : IEventStreamEvent
    {
        private MemoryStream _payload;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The byte array of partial, one or more result records. S3 Select doesn't guarantee
        /// that a record will be self-contained in one record frame. To ensure continuous streaming
        /// of data, S3 Select might split the same record across multiple record frames instead
        /// of aggregating the results in memory. Some S3 clients (for example, the SDKforJava)
        /// handle this behavior by creating a <c>ByteStream</c> out of the response by default.
        /// Other clients might not handle this behavior by default. In those cases, you must
        /// aggregate the results on the client side and parse the response.
        /// </para>
        /// </summary>
        public MemoryStream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

    }
}