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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
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
namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// Contains I/O usage metrics for a command that was invoked.
    /// </summary>
    public partial class IOUsage
    {
        private long? _readIOs;
        private long? _writeIOs;

        /// <summary>
        /// Gets and sets the property ReadIOs. 
        /// <para>
        /// The number of read I/O requests that the command made.
        /// </para>
        /// </summary>
        public long? ReadIOs
        {
            get { return this._readIOs; }
            set { this._readIOs = value; }
        }

        // Check to see if ReadIOs property is set
        internal bool IsSetReadIOs()
        {
            return this._readIOs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WriteIOs. 
        /// <para>
        /// The number of write I/O requests that the command made.
        /// </para>
        /// </summary>
        public long? WriteIOs
        {
            get { return this._writeIOs; }
            set { this._writeIOs = value; }
        }

        // Check to see if WriteIOs property is set
        internal bool IsSetWriteIOs()
        {
            return this._writeIOs.HasValue; 
        }

    }
}