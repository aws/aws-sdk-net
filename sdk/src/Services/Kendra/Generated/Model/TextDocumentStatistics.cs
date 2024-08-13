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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about text documents indexed in an index.
    /// </summary>
    public partial class TextDocumentStatistics
    {
        private long? _indexedTextBytes;
        private int? _indexedTextDocumentsCount;

        /// <summary>
        /// Gets and sets the property IndexedTextBytes. 
        /// <para>
        /// The total size, in bytes, of the indexed documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? IndexedTextBytes
        {
            get { return this._indexedTextBytes; }
            set { this._indexedTextBytes = value; }
        }

        // Check to see if IndexedTextBytes property is set
        internal bool IsSetIndexedTextBytes()
        {
            return this._indexedTextBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IndexedTextDocumentsCount. 
        /// <para>
        /// The number of text documents indexed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? IndexedTextDocumentsCount
        {
            get { return this._indexedTextDocumentsCount; }
            set { this._indexedTextDocumentsCount = value; }
        }

        // Check to see if IndexedTextDocumentsCount property is set
        internal bool IsSetIndexedTextDocumentsCount()
        {
            return this._indexedTextDocumentsCount.HasValue; 
        }

    }
}