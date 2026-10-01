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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the storage configuration of the knowledge base for S3 vectors.
    /// </summary>
    public partial class S3VectorsConfiguration
    {
        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vector index used for the knowledge base. This
        /// ARN identifies the specific vector index resource within Amazon Bedrock.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string IndexArn { get; set; }

        /// <summary>
        /// Checks to see if the IndexArn property is set.
        /// </summary>
        internal bool IsSetIndexArn() => this.IndexArn != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index used for the knowledge base. This name identifies the
        /// vector index within the Amazon Bedrock service.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 63)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property VectorBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket where vector embeddings are stored.
        /// This bucket contains the vector data used by the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string VectorBucketArn { get; set; }

        /// <summary>
        /// Checks to see if the VectorBucketArn property is set.
        /// </summary>
        internal bool IsSetVectorBucketArn() => this.VectorBucketArn != null;
    }
}
