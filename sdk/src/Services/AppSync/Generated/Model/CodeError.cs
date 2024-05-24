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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes an AppSync error.
    /// </summary>
    public partial class CodeError
    {
        private string _errorType;
        private CodeErrorLocation _location;
        private string _value;

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// The type of code error. 
        /// </para>
        ///  
        /// <para>
        /// Examples include, but aren't limited to: <c>LINT_ERROR</c>, <c>PARSER_ERROR</c>.
        /// </para>
        /// </summary>
        public string ErrorType
        {
            get { return this._errorType; }
            set { this._errorType = value; }
        }

        // Check to see if ErrorType property is set
        internal bool IsSetErrorType()
        {
            return this._errorType != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The line, column, and span location of the error in the code.
        /// </para>
        /// </summary>
        public CodeErrorLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A user presentable error.
        /// </para>
        ///  
        /// <para>
        /// Examples include, but aren't limited to: <c>Parsing error: Unterminated string literal</c>.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}