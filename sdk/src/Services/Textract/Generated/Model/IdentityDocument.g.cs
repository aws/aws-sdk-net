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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// The structure that lists each document processed in an AnalyzeID operation.
    /// </summary>
    public partial class IdentityDocument
    {
        /// <summary>
        /// Gets and sets the property Blocks. 
        /// <para>
        /// Individual word recognition, as returned by document detection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Block> Blocks { get; set; } = AWSConfigs.InitializeCollections ? new List<Block>() : null;

        /// <summary>
        /// Checks to see if the Blocks property is set.
        /// </summary>
        internal bool IsSetBlocks() => this.Blocks != null && (this.Blocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DocumentIndex. 
        /// <para>
        /// Denotes the placement of a document in the IdentityDocument list. The first document
        /// is marked 1, the second 2 and so on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DocumentIndex { get; set; }

        /// <summary>
        /// Checks to see if the DocumentIndex property is set.
        /// </summary>
        internal bool IsSetDocumentIndex() => this.DocumentIndex.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityDocumentFields. 
        /// <para>
        /// The structure used to record information extracted from identity documents. Contains
        /// both normalized field and value of the extracted text.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IdentityDocumentField> IdentityDocumentFields { get; set; } = AWSConfigs.InitializeCollections ? new List<IdentityDocumentField>() : null;

        /// <summary>
        /// Checks to see if the IdentityDocumentFields property is set.
        /// </summary>
        internal bool IsSetIdentityDocumentFields() => this.IdentityDocumentFields != null && (this.IdentityDocumentFields.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
