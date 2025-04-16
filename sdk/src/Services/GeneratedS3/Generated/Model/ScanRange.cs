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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the byte range of the object to get the records from. A record is processed
    /// when its first byte is contained by the range. This parameter is optional, but when
    /// specified, it must not be empty. See RFC 2616, Section 14.35.1 about how to specify
    /// the start and end of the range.
    /// </summary>
    public partial class ScanRange
    {
        private long? _end;
        private long? _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// Specifies the end of the byte range. This parameter is optional. Valid values: non-negative
        /// integers. The default value is one less than the size of the object being queried.
        /// If only the End parameter is supplied, it is interpreted to mean scan the last N bytes
        /// of the file. For example, <c>&lt;scanrange&gt;&lt;end&gt;50&lt;/end&gt;&lt;/scanrange&gt;</c>
        /// means scan the last 50 bytes.
        /// </para>
        /// </summary>
        public long? End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// Specifies the start of the byte range. This parameter is optional. Valid values: non-negative
        /// integers. The default value is 0. If only <c>start</c> is supplied, it means scan
        /// from that point to the end of the file. For example, <c>&lt;scanrange&gt;&lt;start&gt;50&lt;/start&gt;&lt;/scanrange&gt;</c>
        /// means scan from byte 50 until the end of the file.
        /// </para>
        /// </summary>
        public long? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}