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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Describes the versioning state of an S3 bucket.
    /// </summary>
    public partial class AwsS3BucketBucketVersioningConfiguration
    {
        private bool? _isMfaDeleteEnabled;
        private string _status;

        /// <summary>
        /// Gets and sets the property IsMfaDeleteEnabled. 
        /// <para>
        /// Specifies whether MFA delete is currently enabled in the S3 bucket versioning configuration.
        /// If the S3 bucket was never configured with MFA delete, then this attribute is not
        /// included.
        /// </para>
        /// </summary>
        public bool? IsMfaDeleteEnabled
        {
            get { return this._isMfaDeleteEnabled; }
            set { this._isMfaDeleteEnabled = value; }
        }

        // Check to see if IsMfaDeleteEnabled property is set
        internal bool IsSetIsMfaDeleteEnabled()
        {
            return this._isMfaDeleteEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The versioning status of the S3 bucket. Valid values are <c>Enabled</c> or <c>Suspended</c>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}