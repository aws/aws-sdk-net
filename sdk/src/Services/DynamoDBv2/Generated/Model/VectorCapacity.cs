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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// The consumed capacity for vector index operations, including vector search request
    /// bytes and vector write request bytes.
    /// </summary>
    public partial class VectorCapacity
    {
        private double? _vectorSearchRequestBytes;
        private double? _vectorWriteRequestBytes;

        /// <summary>
        /// Gets and sets the property VectorSearchRequestBytes. 
        /// <para>
        /// The number of vector search request bytes consumed by a <c>SearchVectors</c> operation.
        /// </para>
        /// </summary>
        public double? VectorSearchRequestBytes
        {
            get { return this._vectorSearchRequestBytes; }
            set { this._vectorSearchRequestBytes = value; }
        }

        // Check to see if VectorSearchRequestBytes property is set
        internal bool IsSetVectorSearchRequestBytes()
        {
            return this._vectorSearchRequestBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VectorWriteRequestBytes. 
        /// <para>
        /// The number of vector write request bytes consumed when writing to a vector index.
        /// Reported for write operations that modify attributes indexed by a vector index.
        /// </para>
        /// </summary>
        public double? VectorWriteRequestBytes
        {
            get { return this._vectorWriteRequestBytes; }
            set { this._vectorWriteRequestBytes = value; }
        }

        // Check to see if VectorWriteRequestBytes property is set
        internal bool IsSetVectorWriteRequestBytes()
        {
            return this._vectorWriteRequestBytes.HasValue; 
        }

    }
}