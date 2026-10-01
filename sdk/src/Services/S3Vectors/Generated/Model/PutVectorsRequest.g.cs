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
    /// Container for the parameters to the PutVectors operation. Adds one or more vectors
    /// to a vector index. To specify the vector index, you can either use both the vector
    /// bucket name and the vector index name, or use the vector index Amazon Resource Name
    /// (ARN). <para> For more information about limits, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-vectors-limitations.html">Limitations
    /// and restrictions</a> in the <i>Amazon S3 User Guide</i>. </para> <note> <para> When
    /// inserting vector data into your vector index, you must provide the vector data as
    /// <c>float32</c> (32-bit floating point) values. If you pass higher-precision values
    /// to an Amazon Web Services SDK, S3 Vectors converts the values to 32-bit floating point
    /// before storing them, and <c>GetVectors</c>, <c>ListVectors</c>, and <c>QueryVectors</c>
    /// operations return the float32 values. Different Amazon Web Services SDKs may have
    /// different default numeric types, so ensure your vectors are properly formatted as
    /// <c>float32</c> values regardless of which SDK you're using. For example, in Python,
    /// use <c>numpy.float32</c> or explicitly cast your values. </para> </note> <dl> <dt>Permissions</dt>
    /// <dd> <para> You must have the <c>s3vectors:PutVectors</c> permission to use this operation.
    /// </para> </dd> </dl>
    /// </summary>
    public partial class PutVectorsRequest : AmazonS3VectorsRequest
    {
        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The ARN of the vector index where you want to write vectors.
        /// </para>
        /// </summary>
        public string IndexArn { get; set; }

        /// <summary>
        /// Checks to see if the IndexArn property is set.
        /// </summary>
        internal bool IsSetIndexArn() => this.IndexArn != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index where you want to write vectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property VectorBucketName. 
        /// <para>
        /// The name of the vector bucket that contains the vector index. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string VectorBucketName { get; set; }

        /// <summary>
        /// Checks to see if the VectorBucketName property is set.
        /// </summary>
        internal bool IsSetVectorBucketName() => this.VectorBucketName != null;

        /// <summary>
        /// Gets and sets the property Vectors. 
        /// <para>
        /// The vectors to add to a vector index. The number of vectors in a single request must
        /// not exceed the resource capacity, otherwise the request will be rejected with the
        /// error <c>ServiceUnavailableException</c> with the error message "Currently unable
        /// to handle the request".
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public List<PutInputVector> Vectors { get; set; } = AWSConfigs.InitializeCollections ? new List<PutInputVector>() : null;

        /// <summary>
        /// Checks to see if the Vectors property is set.
        /// </summary>
        internal bool IsSetVectors() => this.Vectors != null && (this.Vectors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
