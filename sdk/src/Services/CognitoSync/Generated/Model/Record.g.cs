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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// The basic data structure of a dataset.
    /// </summary>
    public partial class Record
    {
        /// <summary>
        /// Gets and sets the property DeviceLastModifiedDate. The last modified date of the client
        /// device.
        /// </summary>
        public DateTime? DeviceLastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the DeviceLastModifiedDate property is set.
        /// </summary>
        internal bool IsSetDeviceLastModifiedDate() => this.DeviceLastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Key. The key for the record.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. The user/device that made the last change
        /// to this record.
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. The date on which the record was last
        /// modified.
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property SyncCount. The server sync count for this record.
        /// </summary>
        public long? SyncCount { get; set; }

        /// <summary>
        /// Checks to see if the SyncCount property is set.
        /// </summary>
        internal bool IsSetSyncCount() => this.SyncCount.HasValue;

        /// <summary>
        /// Gets and sets the property Value. The value for the record.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1048575)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
