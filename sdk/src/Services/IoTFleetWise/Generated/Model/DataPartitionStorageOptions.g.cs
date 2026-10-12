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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Size, time, and location options for the data partition.
    /// </summary>
    public partial class DataPartitionStorageOptions
    {
        /// <summary>
        /// Gets and sets the property MaximumSize. 
        /// <para>
        /// The maximum storage size of the data stored in the data partition.
        /// </para>
        ///  <note> 
        /// <para>
        /// Newer data overwrites older data when the partition reaches the maximum size.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageMaximumSize MaximumSize { get; set; }

        /// <summary>
        /// Checks to see if the MaximumSize property is set.
        /// </summary>
        internal bool IsSetMaximumSize() => this.MaximumSize != null;

        /// <summary>
        /// Gets and sets the property MinimumTimeToLive. 
        /// <para>
        /// The amount of time that data in this partition will be kept on disk.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After the designated amount of time passes, the data can be removed, but it's not
        /// guaranteed to be removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Before the time expires, data in this partition can still be deleted if the partition
        /// reaches its configured maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Newer data will overwrite older data when the partition reaches the maximum size.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageMinimumTimeToLive MinimumTimeToLive { get; set; }

        /// <summary>
        /// Checks to see if the MinimumTimeToLive property is set.
        /// </summary>
        internal bool IsSetMinimumTimeToLive() => this.MinimumTimeToLive != null;

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// The folder name for the data partition under the campaign storage folder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4096)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// Checks to see if the StorageLocation property is set.
        /// </summary>
        internal bool IsSetStorageLocation() => this.StorageLocation != null;
    }
}
