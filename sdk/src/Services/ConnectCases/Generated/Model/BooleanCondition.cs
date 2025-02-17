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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Boolean condition for a rule. In the Amazon Connect admin website, case rules are
    /// known as <i>case field conditions</i>. For more information about case field conditions,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
    /// case field conditions to a case template</a>.
    /// </summary>
    public partial class BooleanCondition
    {
        private BooleanOperands _equalTo;
        private BooleanOperands _notEqualTo;

        /// <summary>
        /// Gets and sets the property EqualTo. 
        /// <para>
        /// Tests that operandOne is equal to operandTwo.
        /// </para>
        /// </summary>
        public BooleanOperands EqualTo
        {
            get { return this._equalTo; }
            set { this._equalTo = value; }
        }

        // Check to see if EqualTo property is set
        internal bool IsSetEqualTo()
        {
            return this._equalTo != null;
        }

        /// <summary>
        /// Gets and sets the property NotEqualTo. 
        /// <para>
        /// Tests that operandOne is not equal to operandTwo.
        /// </para>
        /// </summary>
        public BooleanOperands NotEqualTo
        {
            get { return this._notEqualTo; }
            set { this._notEqualTo = value; }
        }

        // Check to see if NotEqualTo property is set
        internal bool IsSetNotEqualTo()
        {
            return this._notEqualTo != null;
        }

    }
}