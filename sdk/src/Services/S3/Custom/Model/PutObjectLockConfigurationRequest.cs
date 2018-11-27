/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutObjectLockConfiguration operation.
    /// Places an Object Lock configuration on the specified bucket. The rule specified in
    /// the Object Lock configuration will be applied by default to every new object placed
    /// in the specified bucket.
    /// </summary>
    public partial class PutObjectLockConfigurationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _contentMD5;
        private ObjectLockConfiguration _objectLockConfiguration;
        private RequestPayer _requestPayer;
        private string _token;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket whose Object Lock configuration you want to create or replace.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return !string.IsNullOrEmpty(this._bucketName);
        }

        /// <summary>
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The MD5 signature for the configuration included in your request.
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return !string.IsNullOrEmpty(this._contentMD5);
        }

        /// <summary>
        /// Gets and sets the property ObjectLockConfiguration. 
        /// <para>
        /// The Object Lock configuration that you want to apply to the specified bucket.
        /// </para>
        /// </summary>
        public ObjectLockConfiguration ObjectLockConfiguration
        {
            get { return this._objectLockConfiguration; }
            set { this._objectLockConfiguration = value; }
        }

        // Check to see if ObjectLockConfiguration property is set
        internal bool IsSetObjectLockConfiguration()
        {
            return this._objectLockConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property Token.
        /// </summary>
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return !string.IsNullOrEmpty(this._token);
        }

    }
}