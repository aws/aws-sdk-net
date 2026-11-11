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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains information about the parameters used for a select.
    /// </summary>
    public partial class SelectParameters
    {
        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression that is used to select the object.
        /// </para>
        /// </summary>
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property ExpressionType. 
        /// <para>
        /// The type of the provided expression, for example <c>SQL</c>.
        /// </para>
        /// </summary>
        public ExpressionType ExpressionType { get; set; }

        /// <summary>
        /// Checks to see if the ExpressionType property is set.
        /// </summary>
        internal bool IsSetExpressionType() => this.ExpressionType != null;

        /// <summary>
        /// Gets and sets the property InputSerialization. 
        /// <para>
        /// Describes the serialization format of the object.
        /// </para>
        /// </summary>
        public InputSerialization InputSerialization { get; set; }

        /// <summary>
        /// Checks to see if the InputSerialization property is set.
        /// </summary>
        internal bool IsSetInputSerialization() => this.InputSerialization != null;

        /// <summary>
        /// Gets and sets the property OutputSerialization. 
        /// <para>
        /// Describes how the results of the select job are serialized.
        /// </para>
        /// </summary>
        public OutputSerialization OutputSerialization { get; set; }

        /// <summary>
        /// Checks to see if the OutputSerialization property is set.
        /// </summary>
        internal bool IsSetOutputSerialization() => this.OutputSerialization != null;
    }
}
