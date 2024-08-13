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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element to <c>DescribeDBLogFiles</c>.
    /// </summary>
    public partial class DescribeDBLogFilesDetails
    {
        private long? _lastWritten;
        private string _logFileName;
        private long? _size;

        /// <summary>
        /// Gets and sets the property LastWritten. 
        /// <para>
        /// A POSIX timestamp when the last log entry was written.
        /// </para>
        /// </summary>
        public long? LastWritten
        {
            get { return this._lastWritten; }
            set { this._lastWritten = value; }
        }

        // Check to see if LastWritten property is set
        internal bool IsSetLastWritten()
        {
            return this._lastWritten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogFileName. 
        /// <para>
        /// The name of the log file for the specified DB instance.
        /// </para>
        /// </summary>
        public string LogFileName
        {
            get { return this._logFileName; }
            set { this._logFileName = value; }
        }

        // Check to see if LogFileName property is set
        internal bool IsSetLogFileName()
        {
            return this._logFileName != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size, in bytes, of the log file for the specified DB instance.
        /// </para>
        /// </summary>
        public long? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}