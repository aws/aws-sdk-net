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
    /// Contains information extracted by an analysis operation after using StartLendingAnalysis.
    /// </summary>
    public partial class Extraction
    {
        private ExpenseDocument _expenseDocument;
        private IdentityDocument _identityDocument;
        private LendingDocument _lendingDocument;

        /// <summary>
        /// Gets and sets the property ExpenseDocument.
        /// </summary>
        public ExpenseDocument ExpenseDocument
        {
            get { return this._expenseDocument; }
            set { this._expenseDocument = value; }
        }

        // Check to see if ExpenseDocument property is set
        internal bool IsSetExpenseDocument()
        {
            return this._expenseDocument != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityDocument.
        /// </summary>
        public IdentityDocument IdentityDocument
        {
            get { return this._identityDocument; }
            set { this._identityDocument = value; }
        }

        // Check to see if IdentityDocument property is set
        internal bool IsSetIdentityDocument()
        {
            return this._identityDocument != null;
        }

        /// <summary>
        /// Gets and sets the property LendingDocument. 
        /// <para>
        /// Holds the structured data returned by AnalyzeDocument for lending documents.
        /// </para>
        /// </summary>
        public LendingDocument LendingDocument
        {
            get { return this._lendingDocument; }
            set { this._lendingDocument = value; }
        }

        // Check to see if LendingDocument property is set
        internal bool IsSetLendingDocument()
        {
            return this._lendingDocument != null;
        }

    }
}