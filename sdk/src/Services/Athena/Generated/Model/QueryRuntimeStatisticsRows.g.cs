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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Statistics such as input rows and bytes read by the query, rows and bytes output by
    /// the query, and the number of rows written by the query.
    /// </summary>
    public partial class QueryRuntimeStatisticsRows
    {
        /// <summary>
        /// Gets and sets the property InputBytes. 
        /// <para>
        /// The number of bytes read to execute the query.
        /// </para>
        /// </summary>
        public long? InputBytes { get; set; }

        /// <summary>
        /// Checks to see if the InputBytes property is set.
        /// </summary>
        internal bool IsSetInputBytes() => this.InputBytes.HasValue;

        /// <summary>
        /// Gets and sets the property InputRows. 
        /// <para>
        /// The number of rows read to execute the query.
        /// </para>
        /// </summary>
        public long? InputRows { get; set; }

        /// <summary>
        /// Checks to see if the InputRows property is set.
        /// </summary>
        internal bool IsSetInputRows() => this.InputRows.HasValue;

        /// <summary>
        /// Gets and sets the property OutputBytes. 
        /// <para>
        /// The number of bytes returned by the query.
        /// </para>
        /// </summary>
        public long? OutputBytes { get; set; }

        /// <summary>
        /// Checks to see if the OutputBytes property is set.
        /// </summary>
        internal bool IsSetOutputBytes() => this.OutputBytes.HasValue;

        /// <summary>
        /// Gets and sets the property OutputRows. 
        /// <para>
        /// The number of rows returned by the query.
        /// </para>
        /// </summary>
        public long? OutputRows { get; set; }

        /// <summary>
        /// Checks to see if the OutputRows property is set.
        /// </summary>
        internal bool IsSetOutputRows() => this.OutputRows.HasValue;
    }
}
