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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains information about the parameters used for a select.
    /// </summary>
    public partial class SelectParameters
    {
        private string _expression;
        private ExpressionType _expressionType;
        private InputSerialization _inputSerialization;
        private OutputSerialization _outputSerialization;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression that is used to select the object.
        /// </para>
        /// </summary>
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property ExpressionType. 
        /// <para>
        /// The type of the provided expression, for example <c>SQL</c>.
        /// </para>
        /// </summary>
        public ExpressionType ExpressionType
        {
            get { return this._expressionType; }
            set { this._expressionType = value; }
        }

        // Check to see if ExpressionType property is set
        internal bool IsSetExpressionType()
        {
            return this._expressionType != null;
        }

        /// <summary>
        /// Gets and sets the property InputSerialization. 
        /// <para>
        /// Describes the serialization format of the object.
        /// </para>
        /// </summary>
        public InputSerialization InputSerialization
        {
            get { return this._inputSerialization; }
            set { this._inputSerialization = value; }
        }

        // Check to see if InputSerialization property is set
        internal bool IsSetInputSerialization()
        {
            return this._inputSerialization != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSerialization. 
        /// <para>
        /// Describes how the results of the select job are serialized.
        /// </para>
        /// </summary>
        public OutputSerialization OutputSerialization
        {
            get { return this._outputSerialization; }
            set { this._outputSerialization = value; }
        }

        // Check to see if OutputSerialization property is set
        internal bool IsSetOutputSerialization()
        {
            return this._outputSerialization != null;
        }

    }
}