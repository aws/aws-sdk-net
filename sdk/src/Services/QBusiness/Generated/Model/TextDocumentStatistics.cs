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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
        private long? _indexedTextBytes;
        private int? _indexedTextDocumentCount;

        /// <summary>
        /// Gets and sets the property IndexedTextBytes. 
        /// <para>
        /// The total size, in bytes, of the indexed documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property IndexedTextDocumentCount. 
        /// <para>
        /// The number of text documents indexed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? IndexedTextDocumentCount
        {
            get { return this._indexedTextDocumentCount; }
            set { this._indexedTextDocumentCount = value; }
        }

        // Check to see if IndexedTextDocumentCount property is set
        internal bool IsSetIndexedTextDocumentCount()
        {
            return this._indexedTextDocumentCount.HasValue; 
        }

    }
}