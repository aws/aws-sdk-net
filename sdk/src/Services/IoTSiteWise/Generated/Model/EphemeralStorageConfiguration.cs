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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Configuration for ephemeral storage attached to the container task.
    /// </summary>
    public partial class EphemeralStorageConfiguration
    {
        private StorageClass _storageClass;
        private int? _storageSizeInGiB;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Storage type that determines I/O performance family and level.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

        /// <summary>
        /// Gets and sets the property StorageSizeInGiB. 
        /// <para>
        /// Storage volume size in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16384)]
        public int? StorageSizeInGiB
        {
            get { return this._storageSizeInGiB; }
            set { this._storageSizeInGiB = value; }
        }

        // Check to see if StorageSizeInGiB property is set
        internal bool IsSetStorageSizeInGiB()
        {
            return this._storageSizeInGiB.HasValue; 
        }

    }
}