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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// A storage location in an Amazon S3 bucket.
    /// </summary>
    public partial class S3Location
    {
        private string _bucketOwner;
        private string _uri;

        /// <summary>
        /// Gets and sets the property BucketOwner. 
        /// <para>
        /// If the bucket belongs to another AWS account, specify that account's ID.
        /// </para>
        /// </summary>
        public string BucketOwner
        {
            get { return this._bucketOwner; }
            set { this._bucketOwner = value; }
        }

        // Check to see if BucketOwner property is set
        internal bool IsSetBucketOwner()
        {
            return this._bucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// An object URI starting with <c>s3://</c>.
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