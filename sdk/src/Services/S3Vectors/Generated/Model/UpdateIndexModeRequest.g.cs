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
    /// Container for the parameters to the UpdateIndexMode operation. Updates the mode for
    /// an existing vector index. You can set the mode to <c>ENHANCED</c> for any vector index.
    /// You can set the mode to <c>CLASSIC</c> only for a vector index in a vector bucket
    /// created before September 30, 2026. This operation doesn't change the default index
    /// mode of the vector bucket or the mode of other vector indexes. Specify the vector
    /// index by using its Amazon Resource Name (ARN) or both the vector bucket name and vector
    /// index name. <dl> <dt>Permissions</dt> <dd> <para> You must have the <c>s3vectors:UpdateIndexMode</c>
    /// permission to use this operation. </para> </dd> </dl>
    /// </summary>
    public partial class UpdateIndexModeRequest : AmazonS3VectorsRequest
    {
        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vector index to update.
        /// </para>
        /// </summary>
        public string IndexArn { get; set; }

        /// <summary>
        /// Checks to see if the IndexArn property is set.
        /// </summary>
        internal bool IsSetIndexArn() => this.IndexArn != null;

        /// <summary>
        /// Gets and sets the property IndexMode. 
        /// <para>
        /// The new mode for the vector index.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLASSIC</c> - Applies metadata filters during the vector search. You can specify
        /// <c>CLASSIC</c> only for a vector index in a vector bucket created before September
        /// 30, 2026.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENHANCED</c> - Applies metadata filters before the vector search.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public IndexMode IndexMode { get; set; }

        /// <summary>
        /// Checks to see if the IndexMode property is set.
        /// </summary>
        internal bool IsSetIndexMode() => this.IndexMode != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index to update.
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
    }
}
