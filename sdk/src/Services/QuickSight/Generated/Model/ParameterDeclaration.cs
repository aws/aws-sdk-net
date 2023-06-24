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
    /// The declaration definition of a parameter.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/parameters-in-quicksight.html">Parameters
    /// in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class ParameterDeclaration
    {
        private DateTimeParameterDeclaration _dateTimeParameterDeclaration;
        private DecimalParameterDeclaration _decimalParameterDeclaration;
        private IntegerParameterDeclaration _integerParameterDeclaration;
        private StringParameterDeclaration _stringParameterDeclaration;

        /// <summary>
        /// Gets and sets the property DateTimeParameterDeclaration. 
        /// <para>
        /// A parameter declaration for the <code>DateTime</code> data type.
        /// </para>
        /// </summary>
        public DateTimeParameterDeclaration DateTimeParameterDeclaration
        {
            get { return this._dateTimeParameterDeclaration; }
            set { this._dateTimeParameterDeclaration = value; }
        }

        // Check to see if DateTimeParameterDeclaration property is set
        internal bool IsSetDateTimeParameterDeclaration()
        {
            return this._dateTimeParameterDeclaration != null;
        }

        /// <summary>
        /// Gets and sets the property DecimalParameterDeclaration. 
        /// <para>
        /// A parameter declaration for the <code>Decimal</code> data type.
        /// </para>
        /// </summary>
        public DecimalParameterDeclaration DecimalParameterDeclaration
        {
            get { return this._decimalParameterDeclaration; }
            set { this._decimalParameterDeclaration = value; }
        }

        // Check to see if DecimalParameterDeclaration property is set
        internal bool IsSetDecimalParameterDeclaration()
        {
            return this._decimalParameterDeclaration != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerParameterDeclaration. 
        /// <para>
        /// A parameter declaration for the <code>Integer</code> data type.
        /// </para>
        /// </summary>
        public IntegerParameterDeclaration IntegerParameterDeclaration
        {
            get { return this._integerParameterDeclaration; }
            set { this._integerParameterDeclaration = value; }
        }

        // Check to see if IntegerParameterDeclaration property is set
        internal bool IsSetIntegerParameterDeclaration()
        {
            return this._integerParameterDeclaration != null;
        }

        /// <summary>
        /// Gets and sets the property StringParameterDeclaration. 
        /// <para>
        /// A parameter declaration for the <code>String</code> data type.
        /// </para>
        /// </summary>
        public StringParameterDeclaration StringParameterDeclaration
        {
            get { return this._stringParameterDeclaration; }
            set { this._stringParameterDeclaration = value; }
        }

        // Check to see if StringParameterDeclaration property is set
        internal bool IsSetStringParameterDeclaration()
        {
            return this._stringParameterDeclaration != null;
        }

    }
}