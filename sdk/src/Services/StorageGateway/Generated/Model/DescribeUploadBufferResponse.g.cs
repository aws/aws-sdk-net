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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the DescribeUploadBuffer operation.
    /// </summary>
    public partial class DescribeUploadBufferResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DiskIds. 
        /// <para>
        /// An array of the gateway's local disk IDs that are configured as working storage. Each
        /// local disk ID is specified as a string (minimum length of 1 and maximum length of
        /// 300). If no local disks are configured as working storage, then the DiskIds array
        /// is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DiskIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DiskIds property is set.
        /// </summary>
        internal bool IsSetDiskIds() => this.DiskIds != null && (this.DiskIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;

        /// <summary>
        /// Gets and sets the property UploadBufferAllocatedInBytes. 
        /// <para>
        /// The total number of bytes allocated in the gateway's as upload buffer.
        /// </para>
        /// </summary>
        public long? UploadBufferAllocatedInBytes { get; set; }

        /// <summary>
        /// Checks to see if the UploadBufferAllocatedInBytes property is set.
        /// </summary>
        internal bool IsSetUploadBufferAllocatedInBytes() => this.UploadBufferAllocatedInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property UploadBufferUsedInBytes. 
        /// <para>
        /// The total number of bytes being used in the gateway's upload buffer.
        /// </para>
        /// </summary>
        public long? UploadBufferUsedInBytes { get; set; }

        /// <summary>
        /// Checks to see if the UploadBufferUsedInBytes property is set.
        /// </summary>
        internal bool IsSetUploadBufferUsedInBytes() => this.UploadBufferUsedInBytes.HasValue;
    }
}
