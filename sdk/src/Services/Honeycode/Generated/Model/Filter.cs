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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// An object that represents a filter formula along with the id of the context row under
    /// which the filter function needs to evaluate.
    /// </summary>
    public partial class Filter
    {
        private string _contextRowId;
        private string _formula;

        /// <summary>
        /// Gets and sets the property ContextRowId. 
        /// <para>
        ///  The optional contextRowId attribute can be used to specify the row id of the context
        /// row if the filter formula contains unqualified references to table columns and needs
        /// a context row to evaluate them successfully. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=77, Max=77)]
        public string ContextRowId
        {
            get { return this._contextRowId; }
            set { this._contextRowId = value; }
        }

        // Check to see if ContextRowId property is set
        internal bool IsSetContextRowId()
        {
            return this._contextRowId != null;
        }

        /// <summary>
        /// Gets and sets the property Formula. 
        /// <para>
        ///  A formula representing a filter function that returns zero or more matching rows
        /// from a table. Valid formulas in this field return a list of rows from a table. The
        /// most common ways of writing a formula to return a list of rows are to use the FindRow()
        /// or Filter() functions. Any other formula that returns zero or more rows is also acceptable.
        /// For example, you can use a formula that points to a cell that contains a filter function.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=8192)]
        public string Formula
        {
            get { return this._formula; }
            set { this._formula = value; }
        }

        // Check to see if Formula property is set
        internal bool IsSetFormula()
        {
            return this._formula != null;
        }

    }
}