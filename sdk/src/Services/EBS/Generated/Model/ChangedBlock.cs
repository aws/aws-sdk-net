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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
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
    /// A block of data in an Amazon Elastic Block Store snapshot that is different from another
    /// snapshot of the same volume/snapshot lineage.
    /// </summary>
    public partial class ChangedBlock
    {
        private int? _blockIndex;
        private string _firstBlockToken;
        private string _secondBlockToken;

        /// <summary>
        /// Gets and sets the property BlockIndex. 
        /// <para>
        /// The block index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? BlockIndex
        {
            get { return this._blockIndex; }
            set { this._blockIndex = value; }
        }

        // Check to see if BlockIndex property is set
        internal bool IsSetBlockIndex()
        {
            return this._blockIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstBlockToken. 
        /// <para>
        /// The block token for the block index of the <c>FirstSnapshotId</c> specified in the
        /// <c>ListChangedBlocks</c> operation. This value is absent if the first snapshot does
        /// not have the changed block that is on the second snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FirstBlockToken
        {
            get { return this._firstBlockToken; }
            set { this._firstBlockToken = value; }
        }

        // Check to see if FirstBlockToken property is set
        internal bool IsSetFirstBlockToken()
        {
            return this._firstBlockToken != null;
        }

        /// <summary>
        /// Gets and sets the property SecondBlockToken. 
        /// <para>
        /// The block token for the block index of the <c>SecondSnapshotId</c> specified in the
        /// <c>ListChangedBlocks</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SecondBlockToken
        {
            get { return this._secondBlockToken; }
            set { this._secondBlockToken = value; }
        }

        // Check to see if SecondBlockToken property is set
        internal bool IsSetSecondBlockToken()
        {
            return this._secondBlockToken != null;
        }

    }
}