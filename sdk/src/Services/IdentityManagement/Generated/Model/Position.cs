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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the row and column of a location of a <c>Statement</c> element in a policy
    /// document.
    /// 
    ///  
    /// <para>
    /// This data type is used as a member of the <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_Statement.html">Statement</a>
    /// </c> type.
    /// </para>
    /// </summary>
    public partial class Position
    {
        private int? _column;
        private int? _line;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column in the line containing the specified position in the document.
        /// </para>
        /// </summary>
        public int? Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Line. 
        /// <para>
        /// The line containing the specified position in the document.
        /// </para>
        /// </summary>
        public int? Line
        {
            get { return this._line; }
            set { this._line = value; }
        }

        // Check to see if Line property is set
        internal bool IsSetLine()
        {
            return this._line.HasValue; 
        }

    }
}