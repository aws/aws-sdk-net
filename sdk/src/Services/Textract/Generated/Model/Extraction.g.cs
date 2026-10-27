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
    /// Contains information extracted by an analysis operation after using StartLendingAnalysis.
    /// </summary>
    public partial class Extraction
    {
        /// <summary>
        /// Gets and sets the property ExpenseDocument.
        /// </summary>
        public ExpenseDocument ExpenseDocument { get; set; }

        /// <summary>
        /// Checks to see if the ExpenseDocument property is set.
        /// </summary>
        internal bool IsSetExpenseDocument() => this.ExpenseDocument != null;

        /// <summary>
        /// Gets and sets the property IdentityDocument.
        /// </summary>
        public IdentityDocument IdentityDocument { get; set; }

        /// <summary>
        /// Checks to see if the IdentityDocument property is set.
        /// </summary>
        internal bool IsSetIdentityDocument() => this.IdentityDocument != null;

        /// <summary>
        /// Gets and sets the property LendingDocument. 
        /// <para>
        /// Holds the structured data returned by AnalyzeDocument for lending documents.
        /// </para>
        /// </summary>
        public LendingDocument LendingDocument { get; set; }

        /// <summary>
        /// Checks to see if the LendingDocument property is set.
        /// </summary>
        internal bool IsSetLendingDocument() => this.LendingDocument != null;
    }
}
