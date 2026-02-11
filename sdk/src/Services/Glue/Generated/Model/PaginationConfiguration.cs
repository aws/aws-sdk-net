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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private CursorConfiguration _cursorConfiguration;
        private OffsetConfiguration _offsetConfiguration;

        /// <summary>
        /// Gets and sets the property CursorConfiguration. 
        /// <para>
        /// Configuration for cursor-based pagination, where the API provides a cursor or token
        /// to retrieve the next page of results.
        /// </para>
        /// </summary>
        public CursorConfiguration CursorConfiguration
        {
            get { return this._cursorConfiguration; }
            set { this._cursorConfiguration = value; }
        }

        // Check to see if CursorConfiguration property is set
        internal bool IsSetCursorConfiguration()
        {
            return this._cursorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OffsetConfiguration. 
        /// <para>
        /// Configuration for offset-based pagination, where the API uses numeric offsets and
        /// limits to control which results are returned.
        /// </para>
        /// </summary>
        public OffsetConfiguration OffsetConfiguration
        {
            get { return this._offsetConfiguration; }
            set { this._offsetConfiguration = value; }
        }

        // Check to see if OffsetConfiguration property is set
        internal bool IsSetOffsetConfiguration()
        {
            return this._offsetConfiguration != null;
        }

    }
}