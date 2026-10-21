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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Specifies a character-level location within a document, providing precise positioning
    /// information for cited content using start and end character indices.
    /// </summary>
    public partial class DocumentCharLocation
    {
        /// <summary>
        /// Gets and sets the property DocumentIndex. 
        /// <para>
        /// The index of the document within the array of documents provided in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DocumentIndex { get; set; }

        /// <summary>
        /// Checks to see if the DocumentIndex property is set.
        /// </summary>
        internal bool IsSetDocumentIndex() => this.DocumentIndex.HasValue;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The ending character position of the cited content within the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End.HasValue;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The starting character position of the cited content within the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start.HasValue;
    }
}
