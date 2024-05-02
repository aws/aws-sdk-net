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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for a Lustre MDT (Metadata Target) storage volume. The metadata
    /// on Amazon File Cache is managed by a Lustre Metadata Server (MDS) while the actual
    /// metadata is persisted on an MDT.
    /// </summary>
    public partial class FileCacheLustreMetadataConfiguration
    {
        private int? _storageCapacity;

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The storage capacity of the Lustre MDT (Metadata Target) storage volume in gibibytes
        /// (GiB). The only supported value is <c>2400</c> GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? StorageCapacity
        {
            get { return this._storageCapacity; }
            set { this._storageCapacity = value; }
        }

        // Check to see if StorageCapacity property is set
        internal bool IsSetStorageCapacity()
        {
            return this._storageCapacity.HasValue; 
        }

    }
}