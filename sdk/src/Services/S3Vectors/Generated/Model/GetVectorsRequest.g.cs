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
    /// Container for the parameters to the GetVectors operation. Returns vector attributes.
    /// To specify the vector index, you can either use both the vector bucket name and the
    /// vector index name, or use the vector index Amazon Resource Name (ARN). <dl> <dt>Permissions</dt>
    /// <dd> <para> You must have the <c>s3vectors:GetVectors</c> permission to use this operation.
    /// </para> </dd> </dl>
    /// </summary>
    public partial class GetVectorsRequest : AmazonS3VectorsRequest
    {
        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The ARN of the vector index.
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
        /// The name of the vector index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// The names of the vectors you want to return attributes for. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> Keys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Keys property is set.
        /// </summary>
        internal bool IsSetKeys() => this.Keys != null && (this.Keys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReturnData. 
        /// <para>
        /// Indicates whether to include the vector data in the response. The default value is
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnData { get; set; }

        /// <summary>
        /// Checks to see if the ReturnData property is set.
        /// </summary>
        internal bool IsSetReturnData() => this.ReturnData.HasValue;

        /// <summary>
        /// Gets and sets the property ReturnMetadata. 
        /// <para>
        /// Indicates whether to include metadata in the response. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReturnMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ReturnMetadata property is set.
        /// </summary>
        internal bool IsSetReturnMetadata() => this.ReturnMetadata.HasValue;

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
