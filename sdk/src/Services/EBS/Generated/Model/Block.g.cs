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
    /// A block of data in an Amazon Elastic Block Store snapshot.
    /// </summary>
    public partial class Block
    {
        /// <summary>
        /// Gets and sets the property BlockIndex. 
        /// <para>
        /// The block index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? BlockIndex { get; set; }

        /// <summary>
        /// Checks to see if the BlockIndex property is set.
        /// </summary>
        internal bool IsSetBlockIndex() => this.BlockIndex.HasValue;

        /// <summary>
        /// Gets and sets the property BlockToken. 
        /// <para>
        /// The block token for the block index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string BlockToken { get; set; }

        /// <summary>
        /// Checks to see if the BlockToken property is set.
        /// </summary>
        internal bool IsSetBlockToken() => this.BlockToken != null;
    }
}
