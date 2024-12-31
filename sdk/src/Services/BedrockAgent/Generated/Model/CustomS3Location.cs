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
    /// Contains information about the Amazon S3 location of the file containing the content
    /// to ingest into a knowledge base connected to a custom data source.
    /// </summary>
    public partial class CustomS3Location
    {
        private string _bucketOwnerAccountId;
        private string _uri;

        /// <summary>
        /// Gets and sets the property BucketOwnerAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that owns the S3 bucket containing
        /// the content to ingest.
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
        /// Gets and sets the property Uri. 
        /// <para>
        /// The S3 URI of the file containing the content to ingest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}