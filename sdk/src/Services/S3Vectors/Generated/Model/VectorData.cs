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
 * Do not modify this file. This file is generated from the s3vectors-2025-07-15.normal.json service model.
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
    /// <note> 
    /// <para>
    /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// The vector data in different formats.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class VectorData
    {
        private List<float> _float32 = AWSConfigs.InitializeCollections ? new List<float>() : null;

        /// <summary>
        /// Gets and sets the property Float32. 
        /// <para>
        /// The vector data as 32-bit floating point numbers. The number of elements in this array
        /// must exactly match the dimension of the vector index where the operation is being
        /// performed.
        /// </para>
        /// </summary>
        public List<float> Float32
        {
            get { return this._float32; }
            set { this._float32 = value; }
        }

        // Check to see if Float32 property is set
        internal bool IsSetFloat32()
        {
            return this._float32 != null && (this._float32.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}