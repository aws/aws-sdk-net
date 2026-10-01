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

namespace Amazon.EBS.Model
{
    /// <summary>
    /// This is the response object from the ListSnapshotBlocks operation.
    /// </summary>
    public partial class ListSnapshotBlocksResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BlockSize. 
        /// <para>
        /// The size of the blocks in the snapshot, in bytes.
        /// </para>
        /// </summary>
        public int? BlockSize { get; set; }

        /// <summary>
        /// Checks to see if the BlockSize property is set.
        /// </summary>
        internal bool IsSetBlockSize() => this.BlockSize.HasValue;

        /// <summary>
        /// Gets and sets the property Blocks. 
        /// <para>
        /// An array of objects containing information about the blocks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<Block> Blocks { get; set; } = AWSConfigs.InitializeCollections ? new List<Block>() : null;

        /// <summary>
        /// Checks to see if the Blocks property is set.
        /// </summary>
        internal bool IsSetBlocks() => this.Blocks != null && (this.Blocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// The time when the <c>BlockToken</c> expires.
        /// </para>
        /// </summary>
        public DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTime property is set.
        /// </summary>
        internal bool IsSetExpiryTime() => this.ExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is null when there
        /// are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume in GB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? VolumeSize { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSize property is set.
        /// </summary>
        internal bool IsSetVolumeSize() => this.VolumeSize.HasValue;
    }
}
