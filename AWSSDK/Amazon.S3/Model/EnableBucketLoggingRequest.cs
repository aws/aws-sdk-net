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

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request logging be enabled on a bucket.
    /// </summary>
    public class EnableBucketLoggingRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private S3BucketLoggingConfig loggingConfig;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket on which logging is to be configured.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket on which logging is to be configured.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableBucketLoggingRequest WithBucketName(string bucketName)
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

        #region LoggingConfig

        /// <summary>
        /// The logging configuration to apply to the bucket.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoggingConfig")]
        public S3BucketLoggingConfig LoggingConfig
        {
            get
            {
                if (this.loggingConfig == null)
                {
                    this.loggingConfig = new S3BucketLoggingConfig();
                }
                return this.loggingConfig;
            }
            set { this.loggingConfig = value; }
        }

        /// <summary>
        /// Sets the logging configuration to apply to the bucket.
        /// </summary>
        /// <param name="loggingConfig">Logging configuration settings</param>
        /// <returns>the request with the LoggingConfig set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableBucketLoggingRequest WithLoggingConfig(S3BucketLoggingConfig loggingConfig)
        {
            this.loggingConfig = loggingConfig;
            return this;
        }

        /// <summary>
        /// Checks if LoggingConfig property is set.
        /// </summary>
        /// <returns>true if LoggingConfig property is set.</returns>
        internal bool IsSetLoggingConfig()
        {
            return this.loggingConfig != null;
        }

        #endregion
    }
}
