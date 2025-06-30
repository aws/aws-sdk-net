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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Specifies a page-level location within a document, providing positioning information
    /// for cited content using page numbers.
    /// </summary>
    public partial class DocumentPageLocation
    {
        private int? _documentIndex;
        private int? _end;
        private int? _start;

        /// <summary>
        /// Gets and sets the property DocumentIndex. 
        /// <para>
        /// The index of the document within the array of documents provided in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? DocumentIndex
        {
            get { return this._documentIndex; }
            set { this._documentIndex = value; }
        }

        // Check to see if DocumentIndex property is set
        internal bool IsSetDocumentIndex()
        {
            return this._documentIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The ending page number of the cited content within the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The starting page number of the cited content within the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}