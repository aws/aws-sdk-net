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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Contains dictionary storage metrics for the Neptune database, including total dictionary
    /// size and entry count, and the size and count for blob (large value) entries.
    /// </summary>
    public partial class DictionariesInfo
    {
        /// <summary>
        /// Gets and sets the property Blobs. 
        /// <para>
        /// The size and entry count for the blob (large value) dictionary entries.
        /// </para>
        /// </summary>
        public StorageMetrics Blobs { get; set; }

        /// <summary>
        /// Checks to see if the Blobs property is set.
        /// </summary>
        internal bool IsSetBlobs() => this.Blobs != null;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total size and entry count across all dictionary entries.
        /// </para>
        /// </summary>
        public StorageMetrics Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total != null;
    }
}
