/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request removal of the website configuration for a bucket.
    /// </summary>
    /// <remarks>
    /// This operation requires the S3:DeleteBucketWebsite permission. By default, only the bucket owner 
    /// can delete the website configuration attached to a bucket. However, bucket owners can grant other 
    /// users permission to delete the website configuration by writing a bucket policy granting them the 
    /// S3:DeleteBucketWebsite permission.
    /// For more information about hosting websites, go to <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/WebsiteHosting.html"/> 
    /// in the Amazon S3 Developer Guide.
    /// </remarks>
    public class DeleteBucketWebsiteRequest : S3Request
    {
        string _bucketName;

        #region BucketName

        /// <summary>
        /// The name of the bucket on which website configuration is to be removed.
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket on which website configuration is to be removed.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteBucketWebsiteRequest WithBucketName(string bucketName)
        {
            this._bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this._bucketName);
        }

        #endregion    
    }
}
