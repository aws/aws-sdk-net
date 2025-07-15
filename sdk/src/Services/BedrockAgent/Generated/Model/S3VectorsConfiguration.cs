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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
        private string _indexArn;
        private string _indexName;
        private string _vectorBucketArn;

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vector index used for the knowledge base. This
        /// ARN identifies the specific vector index resource within Amazon Bedrock.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string IndexArn
        {
            get { return this._indexArn; }
            set { this._indexArn = value; }
        }

        // Check to see if IndexArn property is set
        internal bool IsSetIndexArn()
        {
            return this._indexArn != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the vector index used for the knowledge base. This name identifies the
        /// vector index within the Amazon Bedrock service.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=63)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property VectorBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket where vector embeddings are stored.
        /// This bucket contains the vector data used by the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string VectorBucketArn
        {
            get { return this._vectorBucketArn; }
            set { this._vectorBucketArn = value; }
        }

        // Check to see if VectorBucketArn property is set
        internal bool IsSetVectorBucketArn()
        {
            return this._vectorBucketArn != null;
        }

    }
}