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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A semantic property for a column.
    /// </summary>
    public partial class ColumnSemanticProperty
    {
        private AdditionalNotes _additionalNotes;
        private ColumnDescription _description;
        private ColumnSemanticType _semanticType;

        /// <summary>
        /// Gets and sets the property AdditionalNotes. 
        /// <para>
        /// Additional notes for the column.
        /// </para>
        /// </summary>
        public AdditionalNotes AdditionalNotes
        {
            get { return this._additionalNotes; }
            set { this._additionalNotes = value; }
        }

        // Check to see if AdditionalNotes property is set
        internal bool IsSetAdditionalNotes()
        {
            return this._additionalNotes != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the column.
        /// </para>
        /// </summary>
        public ColumnDescription Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property SemanticType. 
        /// <para>
        /// The semantic type of the column.
        /// </para>
        /// </summary>
        public ColumnSemanticType SemanticType
        {
            get { return this._semanticType; }
            set { this._semanticType = value; }
        }

        // Check to see if SemanticType property is set
        internal bool IsSetSemanticType()
        {
            return this._semanticType != null;
        }

    }
}