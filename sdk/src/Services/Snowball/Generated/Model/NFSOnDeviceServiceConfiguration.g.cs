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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// An object that represents the metadata and configuration settings for the NFS (Network
    /// File System) service on an Amazon Web Services Snow Family device.
    /// </summary>
    public partial class NFSOnDeviceServiceConfiguration
    {
        /// <summary>
        /// Gets and sets the property StorageLimit. 
        /// <para>
        /// The maximum NFS storage for one Snow Family device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? StorageLimit { get; set; }

        /// <summary>
        /// Checks to see if the StorageLimit property is set.
        /// </summary>
        internal bool IsSetStorageLimit() => this.StorageLimit.HasValue;

        /// <summary>
        /// Gets and sets the property StorageUnit. 
        /// <para>
        /// The scale unit of the NFS storage on the device.
        /// </para>
        ///  
        /// <para>
        /// Valid values: TB.
        /// </para>
        /// </summary>
        public StorageUnit StorageUnit { get; set; }

        /// <summary>
        /// Checks to see if the StorageUnit property is set.
        /// </summary>
        internal bool IsSetStorageUnit() => this.StorageUnit != null;
    }
}
