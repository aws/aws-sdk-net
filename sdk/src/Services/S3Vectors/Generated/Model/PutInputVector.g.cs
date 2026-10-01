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

namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// The attributes of a vector to add to a vector index.
    /// </summary>
    public partial class PutInputVector
    {
        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The vector data of the vector. 
        /// </para>
        ///  
        /// <para>
        /// Vector dimensions must match the dimension count that's configured for the vector
        /// index.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>cosine</c> distance metric, zero vectors (vectors containing all zeros)
        /// aren't allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For both <c>cosine</c> and <c>euclidean</c> distance metrics, vector data must contain
        /// only valid floating-point values. Invalid values such as NaN (Not a Number) or Infinity
        /// aren't allowed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public VectorData Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the vector. The key uniquely identifies the vector in a vector index.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the vector. All metadata entries undergo validation to ensure they
        /// meet the format requirements for size and data types.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => !this.Metadata.IsNull();
    }
}
