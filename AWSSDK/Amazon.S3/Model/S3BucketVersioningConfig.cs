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
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// An S3 bucket versioning configuration.
    /// </summary>
    /// <remarks>
    /// Contains the bucket's versioning status (Off, Enabled, Suspended) and whether an MFADelete 
    /// has been enabled for the bucket.
    /// </remarks>
    [Serializable()]
    public class S3BucketVersioningConfig
    {
        #region Private Members

        // If Versioning has nver been turned on, S3 returns the empty string
        // which means Off.
        private string status = "Off";
        private bool? enableMfaDelete;

        #endregion

        #region Public Members

        /// <summary>
        /// Provides the XML representation of the S3BucketVersioningConfig
        /// </summary>
        /// <returns>A String representation of the S3BucketVersioningConfig Object.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<VersioningConfiguration xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\">");
            sb.Append(String.Concat("<Status>", this.Status, "</Status>"));
            if (IsSetEnableMfaDelete())
            {
                sb.Append(String.Concat("<MfaDelete>", (this.EnableMfaDelete.Value ? "Enabled" : "Disabled"), "</MfaDelete>"));
            }
            sb.Append("</VersioningConfiguration>");
            return sb.ToString();
        }

        #endregion

        #region Status

        /// <summary>
        /// Versioning status for the bucket.
        /// Accepted values: Off, Enabled, Suspended.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.status; }
            set
            {
                if (value.Equals(S3Constants.VersioningEnabled) ||
                    value.Equals(S3Constants.VersioningOff) ||
                    value.Equals(S3Constants.VersioningSuspended))
                {
                    this.status = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Versioning Status!", "value");
                }
            }
        }

        /// <summary>
        /// Sets the versioning status for the bucket.
        /// </summary>
        /// <param name="status">Versioning status; accepted values are: Off, Enabled, Suspended</param>
        /// <returns>The Versioning Configuration object with status modified
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3BucketVersioningConfig WithStatus(string status)
        {
            Status = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        internal bool IsSetStatus()
        {
            return !String.IsNullOrEmpty(this.status);
        }

        #endregion

        #region EnableMfaDelete

        /// <summary>
        /// Specifies whether MFA Delete is enabled on this S3 Bucket.
        /// </summary>
        /// <remarks>
        /// If this property is set, please ensure that the 
        /// SetBucketVersioningRequest's MfaCodes property is set with 
        /// the Serial of and Token on the MFA device.
        /// </remarks>
        [XmlElementAttribute(ElementName = "EnableMfaDelete")]
        public bool? EnableMfaDelete
        {
            get { return this.enableMfaDelete.GetValueOrDefault(); }
            set { this.enableMfaDelete = value; }
        }

        /// <summary>
        /// Specifies whether MFA Delete is enabled on this S3 Bucket.
        /// </summary>
        /// <remarks>
        /// If this property is set, please ensure that the 
        /// SetBucketVersioningRequest's MfaCodes property is set with 
        /// the Serial of and Token on the MFA device.
        /// </remarks>
        /// <param name="fEnabled">True to enable MfaDelete on the S3 Bucket</param>
        /// <returns>The S3 Versioning Configuration object with EnableMfaDelete modified</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3BucketVersioningConfig WithEnableMfaDelete(bool fEnabled)
        {
            enableMfaDelete = fEnabled;
            return this;
        }

        /// <summary>
        /// Checks if EnableMfaDelete property is set.
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetEnableMfaDelete()
        {
            return this.enableMfaDelete.HasValue;
        }

        #endregion
    }
}
