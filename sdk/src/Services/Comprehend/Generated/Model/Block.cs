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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private BlockType _blockType;
        private Geometry _geometry;
        private string _id;
        private int? _page;
        private List<RelationshipsListItem> _relationships = new List<RelationshipsListItem>();
        private string _text;

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
        public BlockType BlockType
        {
            get { return this._blockType; }
            set { this._blockType = value; }
        }

        // Check to see if BlockType property is set
        internal bool IsSetBlockType()
        {
            return this._blockType != null;
        }

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Co-ordinates of the rectangle or polygon that contains the text.
        /// </para>
        /// </summary>
        public Geometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier for the block.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// Page number where the block appears.
        /// </para>
        /// </summary>
        public int Page
        {
            get { return this._page.GetValueOrDefault(); }
            set { this._page = value; }
        }

        // Check to see if Page property is set
        internal bool IsSetPage()
        {
            return this._page.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Relationships. 
        /// <para>
        /// A list of child blocks of the current block. For example, a LINE object has child
        /// blocks for each WORD block that's part of the line of text. 
        /// </para>
        /// </summary>
        public List<RelationshipsListItem> Relationships
        {
            get { return this._relationships; }
            set { this._relationships = value; }
        }

        // Check to see if Relationships property is set
        internal bool IsSetRelationships()
        {
            return this._relationships != null && this._relationships.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The word or line of text extracted from the block.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}