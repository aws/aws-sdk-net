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
using System.Xml.Serialization;

using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to control versioning on a bucket.
    /// </summary>
    /// <remarks>
    /// If you want to enable the use of a multi-factor authentication device
    /// on this bucket, please set the EnableMfaDelete property of VersioningConfig.
    /// If EnableMfaDelete is set to true, the MfaCodes property needs to be set with the
    /// Serial number and Current Token displayed on the MFA device.
    /// </remarks>
    public class SetBucketVersioningRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private S3BucketVersioningConfig config;
        private Tuple<string, string> mfaCodes;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket to be updated.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket to be updated.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The versioning configuration to apply to the bucket.
        /// </summary>
        /// <remarks>
        /// Once Versioning has been "Enabled" on a bucket, it can be "Suspended" 
        /// but cannot be switched "Off". If EnableMfaDelete is set,
        /// the MfaCodes property needs to contain the Serial of and current Token
        /// displayed on the MFA device.
        /// </remarks>
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
        /// Sets the versioning configuration to apply to the bucket.
        /// </summary>
        /// <remarks>
        /// Once Versioning has been "Enabled" on a bucket, it can be "Suspended" 
        /// but cannot be switched "Off". If EnableMfaDelete is set,
        /// the MfaCodes property needs to contain the Serial of and current Token
        /// displayed on the MFA device.
        /// </remarks>
        /// <param name="config">The versioning configuration to apply</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        #region MfaCodes

        /// <summary>
        /// The MfaCodes Tuple associates the Serial Number
        /// and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with
        /// your AWS Account
        /// </summary>
        [XmlIgnore]
        public Tuple<string, string> MfaCodes
        {
            get
            {
                if (this.mfaCodes == null)
                {
                    this.mfaCodes = new Tuple<string, string>("", "");
                }
                return this.mfaCodes;
            }
            set { this.mfaCodes = value; }
        }

        /// <summary>
        /// The MfaCodes Tuple associates the Serial Number
        /// and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with
        /// your AWS Account
        /// </summary>
        /// <param name="serial">Serial number of the authentication device</param>
        /// <param name="token">Token displayed on the authentication device</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetBucketVersioningRequest WithMfaCodes(string serial, string token)
        {
            mfaCodes = new Tuple<string, string>(serial, token);
            return this;
        }

        /// <summary>
        /// Checks if the MfaCodes property is set.
        /// </summary>
        /// <returns>true if the MfaCodes property is set.</returns>
        internal bool IsSetMfaCodes()
        {
            return (this.mfaCodes != null) &&
                (!System.String.IsNullOrEmpty(MfaCodes.First)) &&
                (!System.String.IsNullOrEmpty(MfaCodes.Second));
        }

        #endregion

    }
}
