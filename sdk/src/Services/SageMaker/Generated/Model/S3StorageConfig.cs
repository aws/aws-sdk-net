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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The Amazon Simple Storage (Amazon S3) location and and security configuration for
    /// <code>OfflineStore</code>.
    /// </summary>
    public partial class S3StorageConfig
    {
        private string _kmsKeyId;
        private string _resolvedOutputS3Uri;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) key ARN of the key used to encrypt
        /// any objects written into the <code>OfflineStore</code> S3 location.
        /// </para>
        ///  
        /// <para>
        /// The IAM <code>roleARN</code> that is passed as a parameter to <code>CreateFeatureGroup</code>
        /// must have below permissions to the <code>KmsKeyId</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>"kms:GenerateDataKey"</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedOutputS3Uri. 
        /// <para>
        /// The S3 path where offline records are written.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ResolvedOutputS3Uri
        {
            get { return this._resolvedOutputS3Uri; }
            set { this._resolvedOutputS3Uri = value; }
        }

        // Check to see if ResolvedOutputS3Uri property is set
        internal bool IsSetResolvedOutputS3Uri()
        {
            return this._resolvedOutputS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The S3 URI, or location in Amazon S3, of <code>OfflineStore</code>.
        /// </para>
        ///  
        /// <para>
        /// S3 URIs have a format similar to the following: <code>s3://example-bucket/prefix/</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}