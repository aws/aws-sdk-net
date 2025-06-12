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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Textract.Model
{
    /// <summary>
    /// The structure holding all the information returned by AnalyzeExpense
    /// </summary>
    public partial class ExpenseDocument
    {
        private List<Block> _blocks = AWSConfigs.InitializeCollections ? new List<Block>() : null;
        private int? _expenseIndex;
        private List<LineItemGroup> _lineItemGroups = AWSConfigs.InitializeCollections ? new List<LineItemGroup>() : null;
        private List<ExpenseField> _summaryFields = AWSConfigs.InitializeCollections ? new List<ExpenseField>() : null;

        /// <summary>
        /// Gets and sets the property Blocks. 
        /// <para>
        /// This is a block object, the same as reported when DetectDocumentText is run on a document.
        /// It provides word level recognition of text.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Block> Blocks
        {
            get { return this._blocks; }
            set { this._blocks = value; }
        }

        // Check to see if Blocks property is set
        internal bool IsSetBlocks()
        {
            return this._blocks != null && (this._blocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpenseIndex. 
        /// <para>
        /// Denotes which invoice or receipt in the document the information is coming from. First
        /// document will be 1, the second 2, and so on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ExpenseIndex
        {
            get { return this._expenseIndex; }
            set { this._expenseIndex = value; }
        }

        // Check to see if ExpenseIndex property is set
        internal bool IsSetExpenseIndex()
        {
            return this._expenseIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineItemGroups. 
        /// <para>
        /// Information detected on each table of a document, seperated into <c>LineItems</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LineItemGroup> LineItemGroups
        {
            get { return this._lineItemGroups; }
            set { this._lineItemGroups = value; }
        }

        // Check to see if LineItemGroups property is set
        internal bool IsSetLineItemGroups()
        {
            return this._lineItemGroups != null && (this._lineItemGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SummaryFields. 
        /// <para>
        /// Any information found outside of a table by Amazon Textract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpenseField> SummaryFields
        {
            get { return this._summaryFields; }
            set { this._summaryFields = value; }
        }

        // Check to see if SummaryFields property is set
        internal bool IsSetSummaryFields()
        {
            return this._summaryFields != null && (this._summaryFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}