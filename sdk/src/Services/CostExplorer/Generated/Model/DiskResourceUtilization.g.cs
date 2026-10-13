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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The field that contains a list of disk (local storage) metrics that are associated
    /// with the current instance.
    /// </summary>
    public partial class DiskResourceUtilization
    {
        /// <summary>
        /// Gets and sets the property DiskReadBytesPerSecond. 
        /// <para>
        /// The maximum read throughput operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DiskReadBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the DiskReadBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetDiskReadBytesPerSecond() => this.DiskReadBytesPerSecond != null;

        /// <summary>
        /// Gets and sets the property DiskReadOpsPerSecond. 
        /// <para>
        /// The maximum number of read operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DiskReadOpsPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the DiskReadOpsPerSecond property is set.
        /// </summary>
        internal bool IsSetDiskReadOpsPerSecond() => this.DiskReadOpsPerSecond != null;

        /// <summary>
        /// Gets and sets the property DiskWriteBytesPerSecond. 
        /// <para>
        /// The maximum write throughput operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DiskWriteBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the DiskWriteBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetDiskWriteBytesPerSecond() => this.DiskWriteBytesPerSecond != null;

        /// <summary>
        /// Gets and sets the property DiskWriteOpsPerSecond. 
        /// <para>
        /// The maximum number of write operations per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DiskWriteOpsPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the DiskWriteOpsPerSecond property is set.
        /// </summary>
        internal bool IsSetDiskWriteOpsPerSecond() => this.DiskWriteOpsPerSecond != null;
    }
}
