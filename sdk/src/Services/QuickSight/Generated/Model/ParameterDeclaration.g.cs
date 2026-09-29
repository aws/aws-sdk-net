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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The declaration definition of a parameter.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/parameters-in-quicksight.html">Parameters
    /// in Amazon Quick Sight</a> in the <i>Amazon Quick Suite User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class ParameterDeclaration
    {
        /// <summary>
        /// Gets and sets the property DateTimeParameterDeclaration. 
        /// <para>
        /// A parameter declaration for the <c>DateTime</c> data type.
        /// </para>
        /// </summary>
        public DateTimeParameterDeclaration DateTimeParameterDeclaration { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeParameterDeclaration property is set.
        /// </summary>
        internal bool IsSetDateTimeParameterDeclaration() => this.DateTimeParameterDeclaration != null;

        /// <summary>
        /// Gets and sets the property DecimalParameterDeclaration. 
        /// <para>
        /// A parameter declaration for the <c>Decimal</c> data type.
        /// </para>
        /// </summary>
        public DecimalParameterDeclaration DecimalParameterDeclaration { get; set; }

        /// <summary>
        /// Checks to see if the DecimalParameterDeclaration property is set.
        /// </summary>
        internal bool IsSetDecimalParameterDeclaration() => this.DecimalParameterDeclaration != null;

        /// <summary>
        /// Gets and sets the property IntegerParameterDeclaration. 
        /// <para>
        /// A parameter declaration for the <c>Integer</c> data type.
        /// </para>
        /// </summary>
        public IntegerParameterDeclaration IntegerParameterDeclaration { get; set; }

        /// <summary>
        /// Checks to see if the IntegerParameterDeclaration property is set.
        /// </summary>
        internal bool IsSetIntegerParameterDeclaration() => this.IntegerParameterDeclaration != null;

        /// <summary>
        /// Gets and sets the property StringParameterDeclaration. 
        /// <para>
        /// A parameter declaration for the <c>String</c> data type.
        /// </para>
        /// </summary>
        public StringParameterDeclaration StringParameterDeclaration { get; set; }

        /// <summary>
        /// Checks to see if the StringParameterDeclaration property is set.
        /// </summary>
        internal bool IsSetStringParameterDeclaration() => this.StringParameterDeclaration != null;
    }
}
