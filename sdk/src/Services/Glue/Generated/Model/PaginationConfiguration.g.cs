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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Configuration that defines how to handle paginated responses from REST APIs, supporting
    /// different pagination strategies used by various services.
    /// </summary>
    public partial class PaginationConfiguration
    {
        /// <summary>
        /// Gets and sets the property CursorConfiguration. 
        /// <para>
        /// Configuration for cursor-based pagination, where the API provides a cursor or token
        /// to retrieve the next page of results.
        /// </para>
        /// </summary>
        public CursorConfiguration CursorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CursorConfiguration property is set.
        /// </summary>
        internal bool IsSetCursorConfiguration() => this.CursorConfiguration != null;

        /// <summary>
        /// Gets and sets the property OffsetConfiguration. 
        /// <para>
        /// Configuration for offset-based pagination, where the API uses numeric offsets and
        /// limits to control which results are returned.
        /// </para>
        /// </summary>
        public OffsetConfiguration OffsetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OffsetConfiguration property is set.
        /// </summary>
        internal bool IsSetOffsetConfiguration() => this.OffsetConfiguration != null;
    }
}
