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
    /// The configuration information to connect to Amazon S3 as your data source.
    /// </summary>
    public partial class S3DataSourceConfiguration
    {
        private string _bucketArn;
        private string _bucketOwnerAccountId;
        private List<string> _inclusionPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket that contains your data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property BucketOwnerAccountId. 
        /// <para>
        /// The account ID for the owner of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string BucketOwnerAccountId
        {
            get { return this._bucketOwnerAccountId; }
            set { this._bucketOwnerAccountId = value; }
        }

        // Check to see if BucketOwnerAccountId property is set
        internal bool IsSetBucketOwnerAccountId()
        {
            return this._bucketOwnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property InclusionPrefixes. 
        /// <para>
        /// A list of S3 prefixes to include certain files or content. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-prefixes.html">Organizing
        /// objects using prefixes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> InclusionPrefixes
        {
            get { return this._inclusionPrefixes; }
            set { this._inclusionPrefixes = value; }
        }

        // Check to see if InclusionPrefixes property is set
        internal bool IsSetInclusionPrefixes()
        {
            return this._inclusionPrefixes != null && (this._inclusionPrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}