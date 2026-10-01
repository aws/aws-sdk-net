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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information about text documents in an index.
    /// </summary>
    public partial class TextDocumentStatistics
    {
        /// <summary>
        /// Gets and sets the property IndexedTextBytes. 
        /// <para>
        /// The total size, in bytes, of the indexed documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? IndexedTextBytes { get; set; }

        /// <summary>
        /// Checks to see if the IndexedTextBytes property is set.
        /// </summary>
        internal bool IsSetIndexedTextBytes() => this.IndexedTextBytes.HasValue;

        /// <summary>
        /// Gets and sets the property IndexedTextDocumentCount. 
        /// <para>
        /// The number of text documents indexed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? IndexedTextDocumentCount { get; set; }

        /// <summary>
        /// Checks to see if the IndexedTextDocumentCount property is set.
        /// </summary>
        internal bool IsSetIndexedTextDocumentCount() => this.IndexedTextDocumentCount.HasValue;
    }
}
