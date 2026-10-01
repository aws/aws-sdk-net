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
    /// Container for the parameters to the GetSnapshotBlock operation. Returns the data in
    /// a block in an Amazon Elastic Block Store snapshot. <note> <para> You should always
    /// retry requests that receive server (<c>5xx</c>) error responses, and <c>ThrottlingException</c>
    /// and <c>RequestThrottledException</c> client error responses. For more information
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
    /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. </para> </note>
    /// </summary>
    public partial class GetSnapshotBlockRequest : AmazonEBSRequest
    {
        /// <summary>
        /// Gets and sets the property BlockIndex. 
        /// <para>
        /// The block index of the block in which to read the data. A block index is a logical
        /// index in units of <c>512</c> KiB blocks. To identify the block index, divide the logical
        /// offset of the data in the logical volume by the block size (logical offset of data/<c>524288</c>).
        /// The logical offset of the data must be <c>512</c> KiB aligned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? BlockIndex { get; set; }

        /// <summary>
        /// Checks to see if the BlockIndex property is set.
        /// </summary>
        internal bool IsSetBlockIndex() => this.BlockIndex.HasValue;

        /// <summary>
        /// Gets and sets the property BlockToken. 
        /// <para>
        /// The block token of the block from which to get data. You can obtain the <c>BlockToken</c>
        /// by running the <c>ListChangedBlocks</c> or <c>ListSnapshotBlocks</c> operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string BlockToken { get; set; }

        /// <summary>
        /// Checks to see if the BlockToken property is set.
        /// </summary>
        internal bool IsSetBlockToken() => this.BlockToken != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot containing the block from which to get data.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the specified snapshot is encrypted, you must have permission to use the KMS key
        /// that was used to encrypt the snapshot. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebsapis-using-encryption.html">
        /// Using encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;
    }
}
