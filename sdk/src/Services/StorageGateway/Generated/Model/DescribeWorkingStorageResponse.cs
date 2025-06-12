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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// A JSON object containing the following fields:
    /// </summary>
    public partial class DescribeWorkingStorageResponse : AmazonWebServiceResponse
    {
        private List<string> _diskIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _gatewayARN;
        private long? _workingStorageAllocatedInBytes;
        private long? _workingStorageUsedInBytes;

        /// <summary>
        /// Gets and sets the property DiskIds. 
        /// <para>
        /// An array of the gateway's local disk IDs that are configured as working storage. Each
        /// local disk ID is specified as a string (minimum length of 1 and maximum length of
        /// 300). If no local disks are configured as working storage, then the DiskIds array
        /// is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DiskIds
        {
            get { return this._diskIds; }
            set { this._diskIds = value; }
        }

        // Check to see if DiskIds property is set
        internal bool IsSetDiskIds()
        {
            return this._diskIds != null && (this._diskIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property WorkingStorageAllocatedInBytes. 
        /// <para>
        /// The total working storage in bytes allocated for the gateway. If no working storage
        /// is configured for the gateway, this field returns 0.
        /// </para>
        /// </summary>
        public long? WorkingStorageAllocatedInBytes
        {
            get { return this._workingStorageAllocatedInBytes; }
            set { this._workingStorageAllocatedInBytes = value; }
        }

        // Check to see if WorkingStorageAllocatedInBytes property is set
        internal bool IsSetWorkingStorageAllocatedInBytes()
        {
            return this._workingStorageAllocatedInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkingStorageUsedInBytes. 
        /// <para>
        /// The total working storage in bytes in use by the gateway. If no working storage is
        /// configured for the gateway, this field returns 0.
        /// </para>
        /// </summary>
        public long? WorkingStorageUsedInBytes
        {
            get { return this._workingStorageUsedInBytes; }
            set { this._workingStorageUsedInBytes = value; }
        }

        // Check to see if WorkingStorageUsedInBytes property is set
        internal bool IsSetWorkingStorageUsedInBytes()
        {
            return this._workingStorageUsedInBytes.HasValue; 
        }

    }
}