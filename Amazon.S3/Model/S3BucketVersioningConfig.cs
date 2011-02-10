/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Represents an S3 Bucket Versioning Configuration.
    /// Contains the buckets VersioningStatus - Off, Enabled, Suspended.
    /// Whether an MFADelete has been enabled for the bucket.
    /// </summary>
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
        /// Gets and sets the Status property.
        /// Accepted Values are Off, Enabled, Suspended
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
        /// Sets the Status property.
        /// </summary>
        /// <param name="status">The value for the Status property</param>
        /// <returns>The Versioning Configuration object with status modified
        /// </returns>
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
        /// Gets and Sets the EnableMfaDelete property. 
        /// Specifies whether MFA Delete is enabled on this S3 Bucket. 
        /// If this property is set, please ensure that the 
        /// SetBucketVersioningRequest's MfaCodes property is set with 
        /// the Serial of and Token on the MFA device.
        /// </summary>
        [XmlElementAttribute(ElementName = "EnableMfaDelete")]
        public bool? EnableMfaDelete
        {
            get { return this.enableMfaDelete.GetValueOrDefault(); }
            set { this.enableMfaDelete = value; }
        }

        /// <summary>
        /// Sets the EnableMfaDelete property. If this property is set, 
        /// please ensure that the SetBucketVersioningRequest's MfaCodes
        /// property is set with the Serial of and Token on the MFA device.
        /// </summary>
        /// <param name="fEnabled">Whether MfaDelete will be enabled on the S3 Bucket</param>
        /// <returns>The S3 Versioning Configuration object with EnableMfaDelete modified
        /// </returns>
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