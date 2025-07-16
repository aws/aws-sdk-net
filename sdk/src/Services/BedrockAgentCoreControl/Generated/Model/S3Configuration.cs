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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The Amazon S3 configuration for a gateway. This structure defines how the gateway
    /// accesses files in Amazon S3.
    /// </summary>
    public partial class S3Configuration
    {
        private string _bucketOwnerAccountId;
        private string _uri;

        /// <summary>
        /// Gets and sets the property BucketOwnerAccountId. 
        /// <para>
        /// The account ID of the Amazon S3 bucket owner. This ID is used for cross-account access
        /// to the bucket.
        /// </para>
        /// </summary>
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
        /// The URI of the Amazon S3 object. This URI specifies the location of the object in
        /// Amazon S3.
        /// </para>
        /// </summary>
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