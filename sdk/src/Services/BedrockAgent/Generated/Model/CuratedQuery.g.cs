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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains configurations for a query, each of which defines information about example
    /// queries to help the query engine generate appropriate SQL queries.
    /// </summary>
    public partial class CuratedQuery
    {
        /// <summary>
        /// Gets and sets the property NaturalLanguage. 
        /// <para>
        /// An example natural language query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string NaturalLanguage { get; set; }

        /// <summary>
        /// Checks to see if the NaturalLanguage property is set.
        /// </summary>
        internal bool IsSetNaturalLanguage() => this.NaturalLanguage != null;

        /// <summary>
        /// Gets and sets the property Sql. 
        /// <para>
        /// The SQL equivalent of the natural language query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Sql { get; set; }

        /// <summary>
        /// Checks to see if the Sql property is set.
        /// </summary>
        internal bool IsSetSql() => this.Sql != null;
    }
}
