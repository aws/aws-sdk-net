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
    /// Container for the parameters to the ListIndexes operation. Returns a list of all the
    /// vector indexes within the specified vector bucket. To specify the bucket, you must
    /// use either the vector bucket name or the vector bucket Amazon Resource Name (ARN).
    /// <dl> <dt>Permissions</dt> <dd> <para> You must have the <c>s3vectors:ListIndexes</c>
    /// permission to use this operation. </para> </dd> </dl>
    /// </summary>
    public partial class ListIndexesRequest : AmazonS3VectorsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to be returned in the response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The previous pagination token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Limits the response to vector indexes that begin with the specified prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property VectorBucketArn. 
        /// <para>
        /// The ARN of the vector bucket that contains the vector indexes.
        /// </para>
        /// </summary>
        public string VectorBucketArn { get; set; }

        /// <summary>
        /// Checks to see if the VectorBucketArn property is set.
        /// </summary>
        internal bool IsSetVectorBucketArn() => this.VectorBucketArn != null;

        /// <summary>
        /// Gets and sets the property VectorBucketName. 
        /// <para>
        /// The name of the vector bucket that contains the vector indexes. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string VectorBucketName { get; set; }

        /// <summary>
        /// Checks to see if the VectorBucketName property is set.
        /// </summary>
        internal bool IsSetVectorBucketName() => this.VectorBucketName != null;
    }
}
