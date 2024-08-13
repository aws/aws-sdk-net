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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The FPorts for the position information.
    /// </summary>
    public partial class Positioning
    {
        private int? _clockSync;
        private int? _gnss;
        private int? _stream;

        /// <summary>
        /// Gets and sets the property ClockSync.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int? ClockSync
        {
            get { return this._clockSync; }
            set { this._clockSync = value; }
        }

        // Check to see if ClockSync property is set
        internal bool IsSetClockSync()
        {
            return this._clockSync.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gnss.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int? Gnss
        {
            get { return this._gnss; }
            set { this._gnss = value; }
        }

        // Check to see if Gnss property is set
        internal bool IsSetGnss()
        {
            return this._gnss.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stream.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int? Stream
        {
            get { return this._stream; }
            set { this._stream = value; }
        }

        // Check to see if Stream property is set
        internal bool IsSetStream()
        {
            return this._stream.HasValue; 
        }

    }
}