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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Information about each word or line of text in the input document.
    /// 
    ///  
    /// <para>
    /// For additional information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/API_Block.html">Block</a>
    /// in the Amazon Textract API reference.
    /// </para>
    /// </summary>
    public partial class Block
    {
        /// <summary>
        /// Gets and sets the property BlockType. 
        /// <para>
        /// The block represents a line of text or one word of text.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// WORD - A word that's detected on a document page. A word is one or more ISO basic
        /// Latin script characters that aren't separated by spaces.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LINE - A string of tab-delimited, contiguous words that are detected on a document
        /// page
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BlockType BlockType { get; set; }

        /// <summary>
        /// Checks to see if the BlockType property is set.
        /// </summary>
        internal bool IsSetBlockType() => this.BlockType != null;

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Co-ordinates of the rectangle or polygon that contains the text.
        /// </para>
        /// </summary>
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier for the block.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// Page number where the block appears.
        /// </para>
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// Checks to see if the Page property is set.
        /// </summary>
        internal bool IsSetPage() => this.Page.HasValue;

        /// <summary>
        /// Gets and sets the property Relationships. 
        /// <para>
        /// A list of child blocks of the current block. For example, a LINE object has child
        /// blocks for each WORD block that's part of the line of text. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelationshipsListItem> Relationships { get; set; } = AWSConfigs.InitializeCollections ? new List<RelationshipsListItem>() : null;

        /// <summary>
        /// Checks to see if the Relationships property is set.
        /// </summary>
        internal bool IsSetRelationships() => this.Relationships != null && (this.Relationships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The word or line of text extracted from the block.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
