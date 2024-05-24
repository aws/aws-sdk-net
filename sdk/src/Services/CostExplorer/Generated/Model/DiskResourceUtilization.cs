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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The field that contains a list of disk (local storage) metrics that are associated
    /// with the current instance.
    /// </summary>
    public partial class DiskResourceUtilization
    {
        private string _diskReadBytesPerSecond;
        private string _diskReadOpsPerSecond;
        private string _diskWriteBytesPerSecond;
        private string _diskWriteOpsPerSecond;

        /// <summary>
        /// Gets and sets the property DiskReadBytesPerSecond. 
        /// <para>
        /// The maximum read throughput operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DiskReadBytesPerSecond
        {
            get { return this._diskReadBytesPerSecond; }
            set { this._diskReadBytesPerSecond = value; }
        }

        // Check to see if DiskReadBytesPerSecond property is set
        internal bool IsSetDiskReadBytesPerSecond()
        {
            return this._diskReadBytesPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property DiskReadOpsPerSecond. 
        /// <para>
        /// The maximum number of read operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DiskReadOpsPerSecond
        {
            get { return this._diskReadOpsPerSecond; }
            set { this._diskReadOpsPerSecond = value; }
        }

        // Check to see if DiskReadOpsPerSecond property is set
        internal bool IsSetDiskReadOpsPerSecond()
        {
            return this._diskReadOpsPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property DiskWriteBytesPerSecond. 
        /// <para>
        /// The maximum write throughput operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DiskWriteBytesPerSecond
        {
            get { return this._diskWriteBytesPerSecond; }
            set { this._diskWriteBytesPerSecond = value; }
        }

        // Check to see if DiskWriteBytesPerSecond property is set
        internal bool IsSetDiskWriteBytesPerSecond()
        {
            return this._diskWriteBytesPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property DiskWriteOpsPerSecond. 
        /// <para>
        /// The maximum number of write operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DiskWriteOpsPerSecond
        {
            get { return this._diskWriteOpsPerSecond; }
            set { this._diskWriteOpsPerSecond = value; }
        }

        // Check to see if DiskWriteOpsPerSecond property is set
        internal bool IsSetDiskWriteOpsPerSecond()
        {
            return this._diskWriteOpsPerSecond != null;
        }

    }
}