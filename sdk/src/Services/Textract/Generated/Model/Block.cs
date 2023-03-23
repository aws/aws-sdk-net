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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// A <code>Block</code> represents items that are recognized in a document within a group
    /// of pixels close to each other. The information returned in a <code>Block</code> object
    /// depends on the type of operation. In text detection for documents (for example <a>DetectDocumentText</a>),
    /// you get information about the detected words and lines of text. In text analysis (for
    /// example <a>AnalyzeDocument</a>), you can also get information about the fields, tables,
    /// and selection elements that are detected in the document.
    /// 
    ///  
    /// <para>
    /// An array of <code>Block</code> objects is returned by both synchronous and asynchronous
    /// operations. In synchronous operations, such as <a>DetectDocumentText</a>, the array
    /// of <code>Block</code> objects is the entire set of results. In asynchronous operations,
    /// such as <a>GetDocumentAnalysis</a>, the array is returned over one or more responses.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works.html">How
    /// Amazon Textract Works</a>.
    /// </para>
    /// </summary>
    public partial class Block
    {
        private BlockType _blockType;
        private int? _columnIndex;
        private int? _columnSpan;
        private float? _confidence;
        private List<string> _entityTypes = new List<string>();
        private Geometry _geometry;
        private string _id;
        private int? _page;
        private Query _query;
        private List<Relationship> _relationships = new List<Relationship>();
        private int? _rowIndex;
        private int? _rowSpan;
        private SelectionStatus _selectionStatus;
        private string _text;
        private TextType _textType;

        /// <summary>
        /// Gets and sets the property BlockType. 
        /// <para>
        /// The type of text item that's recognized. In operations for text detection, the following
        /// types are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>PAGE</i> - Contains a list of the LINE <code>Block</code> objects that are detected
        /// on a document page.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>WORD</i> - A word detected on a document page. A word is one or more ISO basic
        /// Latin script characters that aren't separated by spaces.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>LINE</i> - A string of tab-delimited, contiguous words that are detected on a
        /// document page.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In text analysis operations, the following types are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>PAGE</i> - Contains a list of child <code>Block</code> objects that are detected
        /// on a document page.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>KEY_VALUE_SET</i> - Stores the KEY and VALUE <code>Block</code> objects for linked
        /// text that's detected on a document page. Use the <code>EntityType</code> field to
        /// determine if a KEY_VALUE_SET object is a KEY <code>Block</code> object or a VALUE
        /// <code>Block</code> object. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>WORD</i> - A word that's detected on a document page. A word is one or more ISO
        /// basic Latin script characters that aren't separated by spaces.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>LINE</i> - A string of tab-delimited, contiguous words that are detected on a
        /// document page.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE</i> - A table that's detected on a document page. A table is grid-based
        /// information with two or more rows or columns, with a cell span of one row and one
        /// column each. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE_TITLE</i> - The title of a table. A title is typically a line of text above
        /// or below a table, or embedded as the first row of a table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE_FOOTER</i> - The footer associated with a table. A footer is typically a
        /// line or lines of text below a table or embedded as the last row of a table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>CELL</i> - A cell within a detected table. The cell is the parent of the block
        /// that contains the text in the cell.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>MERGED_CELL</i> - A cell in a table whose content spans more than one row or column.
        /// The <code>Relationships</code> array for this cell contain data from individual cells.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SELECTION_ELEMENT</i> - A selection element such as an option button (radio button)
        /// or a check box that's detected on a document page. Use the value of <code>SelectionStatus</code>
        /// to determine the status of the selection element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SIGNATURE</i> - The location and confidene score of a signature detected on a
        /// document page. Can be returned as part of a Key-Value pair or a detected cell.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>QUERY</i> - A question asked during the call of AnalyzeDocument. Contains an alias
        /// and an ID that attaches it to its answer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>QUERY_RESULT</i> - A response to a question asked during the call of analyze document.
        /// Comes with an alias and ID for ease of locating in a response. Also contains location
        /// and confidence score.
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
        /// Gets and sets the property ColumnIndex. 
        /// <para>
        /// The column in which a table cell appears. The first column position is 1. <code>ColumnIndex</code>
        /// isn't returned by <code>DetectDocumentText</code> and <code>GetDocumentTextDetection</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ColumnIndex
        {
            get { return this._columnIndex.GetValueOrDefault(); }
            set { this._columnIndex = value; }
        }

        // Check to see if ColumnIndex property is set
        internal bool IsSetColumnIndex()
        {
            return this._columnIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnSpan. 
        /// <para>
        /// The number of columns that a table cell spans. <code>ColumnSpan</code> isn't returned
        /// by <code>DetectDocumentText</code> and <code>GetDocumentTextDetection</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ColumnSpan
        {
            get { return this._columnSpan.GetValueOrDefault(); }
            set { this._columnSpan = value; }
        }

        // Check to see if ColumnSpan property is set
        internal bool IsSetColumnSpan()
        {
            return this._columnSpan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence score that Amazon Textract has in the accuracy of the recognized text
        /// and the accuracy of the geometry points around the recognized text.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EntityTypes. 
        /// <para>
        /// The type of entity. 
        /// </para>
        ///  
        /// <para>
        /// The following entity types can be returned by FORMS analysis:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>KEY</i> - An identifier for a field on the document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>VALUE</i> - The field text.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following entity types can be returned by TABLES analysis:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>COLUMN_HEADER</i> - Identifies a cell that is a header of a column. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE_TITLE</i> - Identifies a cell that is a title within the table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE_SECTION_TITLE</i> - Identifies a cell that is a title of a section within
        /// a table. A section title is a cell that typically spans an entire row above a section.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE_FOOTER</i> - Identifies a cell that is a footer of a table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>TABLE_SUMMARY</i> - Identifies a summary cell of a table. A summary cell can be
        /// a row of a table or an additional, smaller table that contains summary information
        /// for another table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>STRUCTURED_TABLE </i> - Identifies a table with column headers where the content
        /// of each row corresponds to the headers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SEMI_STRUCTURED_TABLE</i> - Identifies a non-structured table. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>EntityTypes</code> isn't returned by <code>DetectDocumentText</code> and <code>GetDocumentTextDetection</code>.
        /// </para>
        /// </summary>
        public List<string> EntityTypes
        {
            get { return this._entityTypes; }
            set { this._entityTypes = value; }
        }

        // Check to see if EntityTypes property is set
        internal bool IsSetEntityTypes()
        {
            return this._entityTypes != null && this._entityTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// The location of the recognized text on the image. It includes an axis-aligned, coarse
        /// bounding box that surrounds the text, and a finer-grain polygon for more accurate
        /// spatial information. 
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
        /// The identifier for the recognized text. The identifier is only unique for a single
        /// operation. 
        /// </para>
        /// </summary>
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
        /// The page on which a block was detected. <code>Page</code> is returned by synchronous
        /// and asynchronous operations. Page values greater than 1 are only returned for multipage
        /// documents that are in PDF or TIFF format. A scanned image (JPEG/PNG) provided to an
        /// asynchronous operation, even if it contains multiple document pages, is considered
        /// a single-page document. This means that for scanned images the value of <code>Page</code>
        /// is always 1. Synchronous operations will also return a <code>Page</code> value of
        /// 1 because every input document is considered to be a single-page document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property Query.
        /// </summary>
        public Query Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property Relationships. 
        /// <para>
        /// A list of relationship objects that describe how blocks are related to each other.
        /// For example, a LINE block object contains a CHILD relationship type with the WORD
        /// blocks that make up the line of text. There aren't Relationship objects in the list
        /// for relationships that don't exist, such as when the current block has no child blocks.
        /// </para>
        /// </summary>
        public List<Relationship> Relationships
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
        /// Gets and sets the property RowIndex. 
        /// <para>
        /// The row in which a table cell is located. The first row position is 1. <code>RowIndex</code>
        /// isn't returned by <code>DetectDocumentText</code> and <code>GetDocumentTextDetection</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int RowIndex
        {
            get { return this._rowIndex.GetValueOrDefault(); }
            set { this._rowIndex = value; }
        }

        // Check to see if RowIndex property is set
        internal bool IsSetRowIndex()
        {
            return this._rowIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RowSpan. 
        /// <para>
        /// The number of rows that a table cell spans. <code>RowSpan</code> isn't returned by
        /// <code>DetectDocumentText</code> and <code>GetDocumentTextDetection</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int RowSpan
        {
            get { return this._rowSpan.GetValueOrDefault(); }
            set { this._rowSpan = value; }
        }

        // Check to see if RowSpan property is set
        internal bool IsSetRowSpan()
        {
            return this._rowSpan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectionStatus. 
        /// <para>
        /// The selection status of a selection element, such as an option button or check box.
        /// 
        /// </para>
        /// </summary>
        public SelectionStatus SelectionStatus
        {
            get { return this._selectionStatus; }
            set { this._selectionStatus = value; }
        }

        // Check to see if SelectionStatus property is set
        internal bool IsSetSelectionStatus()
        {
            return this._selectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The word or line of text that's recognized by Amazon Textract. 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TextType. 
        /// <para>
        /// The kind of text that Amazon Textract has detected. Can check for handwritten text
        /// and printed text.
        /// </para>
        /// </summary>
        public TextType TextType
        {
            get { return this._textType; }
            set { this._textType = value; }
        }

        // Check to see if TextType property is set
        internal bool IsSetTextType()
        {
            return this._textType != null;
        }

    }
}