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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Custom volume configuration for the root volumes that are attached to streaming sessions.
    /// 
    ///  
    /// <para>
    /// This parameter is only allowed when <code>sessionPersistenceMode</code> is <code>ACTIVATED</code>.
    /// </para>
    /// </summary>
    public partial class VolumeConfiguration
    {
        private int? _iops;
        private int? _size;
        private int? _throughput;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second for the root volume that is attached to streaming
        /// session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3000, Max=16000)]
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the root volume that is attached to the streaming session. The root volume
        /// size is measured in GiBs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=16000)]
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to provision for the root volume that is attached to the streaming
        /// session. The throughput is measured in MiB/s.
        /// </para>
        /// </summary>
        [AWSProperty(Min=125, Max=1000)]
        public int Throughput
        {
            get { return this._throughput.GetValueOrDefault(); }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

    }
}