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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
        private long? _inputBytes;
        private long? _inputRows;
        private long? _outputBytes;
        private long? _outputRows;

        /// <summary>
        /// Gets and sets the property InputBytes. 
        /// <para>
        /// The number of bytes read to execute the query.
        /// </para>
        /// </summary>
        public long? InputBytes
        {
            get { return this._inputBytes; }
            set { this._inputBytes = value; }
        }

        // Check to see if InputBytes property is set
        internal bool IsSetInputBytes()
        {
            return this._inputBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputRows. 
        /// <para>
        /// The number of rows read to execute the query.
        /// </para>
        /// </summary>
        public long? InputRows
        {
            get { return this._inputRows; }
            set { this._inputRows = value; }
        }

        // Check to see if InputRows property is set
        internal bool IsSetInputRows()
        {
            return this._inputRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputBytes. 
        /// <para>
        /// The number of bytes returned by the query.
        /// </para>
        /// </summary>
        public long? OutputBytes
        {
            get { return this._outputBytes; }
            set { this._outputBytes = value; }
        }

        // Check to see if OutputBytes property is set
        internal bool IsSetOutputBytes()
        {
            return this._outputBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputRows. 
        /// <para>
        /// The number of rows returned by the query.
        /// </para>
        /// </summary>
        public long? OutputRows
        {
            get { return this._outputRows; }
            set { this._outputRows = value; }
        }

        // Check to see if OutputRows property is set
        internal bool IsSetOutputRows()
        {
            return this._outputRows.HasValue; 
        }

    }
}