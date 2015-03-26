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
    public class S3BucketVersioningConfig
    {
        #region Private Members

        // If Versioning has nver been turned on, S3 returns the empty string
        // which means Off.
        private VersionStatus status = "Off";
        private bool? enableMfaDelete;

        #endregion

        #region Status

        /// <summary>
        /// Versioning status for the bucket.
        /// Accepted values: Off, Enabled, Suspended.
        /// </summary>
        public VersionStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        internal bool IsSetStatus()
        {
            return this.status != null && this.status != VersionStatus.Off;
        }

        #endregion

        #region EnableMfaDelete

        /// <summary>
        /// Specifies whether MFA Delete is enabled on this S3 Bucket.
        /// </summary>
        /// <remarks>
        /// If this property is set, please ensure that the 
        /// PutBucketVersioningRequest's MfaCodes property is set with 
        /// the Serial of and Token on the MFA device.
        /// </remarks>
        public bool EnableMfaDelete
        {
            get { return this.enableMfaDelete.GetValueOrDefault(); }
            set { this.enableMfaDelete = value; }
        }

        /// <summary>
        /// Checks if EnableMfaDelete property is set.
        /// </summary>
        /// <returns>true if Status property is set</returns>
        internal bool IsSetEnableMfaDelete()
        {
            return this.enableMfaDelete.HasValue;
        }

        #endregion
    }
}
