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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Identifies a code location to instrument, including the programming language, code
    /// unit, class, method, file path, and optional line number.
    /// </summary>
    public partial class CodeLocation
    {
        private string _className;
        private string _codeUnit;
        private string _filePath;
        private ProgrammingLanguage _language;
        private int? _lineNumber;
        private string _methodName;

        /// <summary>
        /// Gets and sets the property ClassName. 
        /// <para>
        /// The class or type name that contains the method. This is required for Java and optional
        /// for Python module-level functions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        // Check to see if ClassName property is set
        internal bool IsSetClassName()
        {
            return this._className != null;
        }

        /// <summary>
        /// Gets and sets the property CodeUnit. 
        /// <para>
        /// The package, module, or namespace that contains the target code, for example <c>com.amazon.payment</c>
        /// or <c>payment_service</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string CodeUnit
        {
            get { return this._codeUnit; }
            set { this._codeUnit = value; }
        }

        // Check to see if CodeUnit property is set
        internal bool IsSetCodeUnit()
        {
            return this._codeUnit != null;
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The source file path relative to the project or source root, such as <c>src/payment/PaymentProcessor.java</c>
        /// or <c>src/payment/PaymentProcessor.py</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The programming language for this instrumentation point, such as Java, Python, or
        /// JavaScript.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProgrammingLanguage Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property LineNumber. 
        /// <para>
        /// The line number to instrument. Provide this to disambiguate overloaded methods and
        /// to target a specific line when needed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? LineNumber
        {
            get { return this._lineNumber; }
            set { this._lineNumber = value; }
        }

        // Check to see if LineNumber property is set
        internal bool IsSetLineNumber()
        {
            return this._lineNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MethodName. 
        /// <para>
        /// The method or function name to instrument, such as <c>validateCreditCard</c> or <c>__init__</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string MethodName
        {
            get { return this._methodName; }
            set { this._methodName = value; }
        }

        // Check to see if MethodName property is set
        internal bool IsSetMethodName()
        {
            return this._methodName != null;
        }

    }
}