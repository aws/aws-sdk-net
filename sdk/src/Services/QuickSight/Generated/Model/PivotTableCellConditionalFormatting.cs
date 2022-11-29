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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The cell conditional formatting option for a pivot table.
    /// </summary>
    public partial class PivotTableCellConditionalFormatting
    {
        private string _fieldId;
        private PivotTableConditionalFormattingScope _scope;
        private TextConditionalFormat _textFormat;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID of the cell for conditional formatting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the cell for conditional formatting.
        /// </para>
        /// </summary>
        public PivotTableConditionalFormattingScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property TextFormat. 
        /// <para>
        /// The text format of the cell for conditional formatting.
        /// </para>
        /// </summary>
        public TextConditionalFormat TextFormat
        {
            get { return this._textFormat; }
            set { this._textFormat = value; }
        }

        // Check to see if TextFormat property is set
        internal bool IsSetTextFormat()
        {
            return this._textFormat != null;
        }

    }
}