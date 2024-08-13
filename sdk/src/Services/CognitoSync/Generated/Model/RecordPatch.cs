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
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
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
    /// An update operation for a record.
    /// </summary>
    public partial class RecordPatch
    {
        private DateTime? _deviceLastModifiedDate;
        private string _key;
        private Operation _op;
        private long? _syncCount;
        private string _value;

        /// <summary>
        /// Gets and sets the property DeviceLastModifiedDate. The last modified date of the client
        /// device.
        /// </summary>
        public DateTime? DeviceLastModifiedDate
        {
            get { return this._deviceLastModifiedDate; }
            set { this._deviceLastModifiedDate = value; }
        }

        // Check to see if DeviceLastModifiedDate property is set
        internal bool IsSetDeviceLastModifiedDate()
        {
            return this._deviceLastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. The key associated with the record patch.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Op. An operation, either replace or remove.
        /// </summary>
        [AWSProperty(Required=true)]
        public Operation Op
        {
            get { return this._op; }
            set { this._op = value; }
        }

        // Check to see if Op property is set
        internal bool IsSetOp()
        {
            return this._op != null;
        }

        /// <summary>
        /// Gets and sets the property SyncCount. Last known server sync count for this record.
        /// Set to 0 if unknown.
        /// </summary>
        [AWSProperty(Required=true)]
        public long? SyncCount
        {
            get { return this._syncCount; }
            set { this._syncCount = value; }
        }

        // Check to see if SyncCount property is set
        internal bool IsSetSyncCount()
        {
            return this._syncCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. The value associated with the record patch.
        /// </summary>
        [AWSProperty(Max=1048575)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}