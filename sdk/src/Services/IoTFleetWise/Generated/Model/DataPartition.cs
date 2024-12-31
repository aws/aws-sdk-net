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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
    /// The configuration for signal data storage and upload options. You can only specify
    /// these options when the campaign's spooling mode is <c>TO_DISK</c>.
    /// 
    ///  <important> 
    /// <para>
    /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
    /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
    /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
    /// FleetWise Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DataPartition
    {
        private string _id;
        private DataPartitionStorageOptions _storageOptions;
        private DataPartitionUploadOptions _uploadOptions;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the data partition. The data partition ID must be unique within a campaign.
        /// You can establish a data partition as the default partition for a campaign by using
        /// <c>default</c> as the ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property StorageOptions. 
        /// <para>
        /// The storage options for a data partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataPartitionStorageOptions StorageOptions
        {
            get { return this._storageOptions; }
            set { this._storageOptions = value; }
        }

        // Check to see if StorageOptions property is set
        internal bool IsSetStorageOptions()
        {
            return this._storageOptions != null;
        }

        /// <summary>
        /// Gets and sets the property UploadOptions. 
        /// <para>
        /// The upload options for the data partition.
        /// </para>
        /// </summary>
        public DataPartitionUploadOptions UploadOptions
        {
            get { return this._uploadOptions; }
            set { this._uploadOptions = value; }
        }

        // Check to see if UploadOptions property is set
        internal bool IsSetUploadOptions()
        {
            return this._uploadOptions != null;
        }

    }
}