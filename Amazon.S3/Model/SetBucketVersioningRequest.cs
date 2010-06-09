/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;

using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The SetBucketVersioningRequest contains the parameters used for the SetBucketVersioning operation.
    /// <para>Required Parameters: BucketName, VersioningConfig</para>
    /// </summary>
    public class SetBucketVersioningRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private S3BucketVersioningConfig config;

        #endregion

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// The Versioning Status of this S3 Bucket is modified by the request.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>this instance</returns>
        public SetBucketVersioningRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }

        #endregion

        #region VersioningConfig

        /// <summary>
        /// Gets and sets the VersioningConfig property.
        /// Once Versioning has been "Enabled" on a bucket, it can be "Suspended" 
        /// but cannot be switched "Off".
        /// </summary>
        [XmlElementAttribute(ElementName = "VersioningConfig")]
        public S3BucketVersioningConfig VersioningConfig
        {
            get { return this.config; }
            set {
                if (value != null)
                {
                    string status = value.Status;
                    if (status.Equals(S3Constants.VersioningEnabled) ||
                        status.Equals(S3Constants.VersioningSuspended))
                    {
                        this.config = value;
                    }
                    else
                    {
                        throw new ArgumentException(
                            "Invalid Versioning Configuration Status - can either be Enabled or Suspended!"
                            );
                    }
                }
                else
                {
                    // null is an accepted value now.
                    // the client will throw an exception if this is a
                    // required parameter!
                    this.config = value;
                }
            }
        }

        /// <summary>
        /// Sets the VersioningConfig property for this request.
        /// The request modifies the Versioning Status of the S3 Bucket to this value.
        /// </summary>
        /// <param name="config">The value that VersioningConfig is set to</param>
        /// <returns>this instance</returns>
        public SetBucketVersioningRequest WithVersioningConfig(S3BucketVersioningConfig config)
        {
            VersioningConfig = config;
            return this;
        }

        /// <summary>
        /// Checks if VersioningConfig property is set.
        /// </summary>
        /// <returns>true if VersioningConfig property is set.</returns>
        internal bool IsSetVersioningConfig()
        {
            return this.config != null;
        }

        #endregion
    }
}