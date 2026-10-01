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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Neptune logs are converted to SPARQL quads in the graph using the Resource Description
    /// Framework (RDF) <a href="https://www.w3.org/TR/n-quads/">N-QUADS</a> language defined
    /// in the W3C RDF 1.1 N-Quads specification
    /// </summary>
    public partial class SparqlData
    {
        /// <summary>
        /// Gets and sets the property Stmt. 
        /// <para>
        /// Holds an <a href="https://www.w3.org/TR/n-quads/">N-QUADS</a> statement expressing
        /// the changed quad.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Stmt { get; set; }

        /// <summary>
        /// Checks to see if the Stmt property is set.
        /// </summary>
        internal bool IsSetStmt() => this.Stmt != null;
    }
}
