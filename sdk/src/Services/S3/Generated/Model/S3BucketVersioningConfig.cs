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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes the versioning state of an Amazon S3 bucket. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTVersioningStatus.html">PUT
    /// Bucket versioning</a> in the <i>Amazon S3 API Reference</i>.
    /// </summary>
    public partial class S3BucketVersioningConfig
    {
        private bool? _enableMfaDelete;
        private VersionStatus _status = "Off";

        /// <summary>
        /// Gets and sets the property EnableMfaDelete. 
        /// <para>
        /// Specifies whether MFA delete is enabled in the bucket versioning configuration. This
        /// element is only returned if the bucket has been configured with MFA delete. If the
        /// bucket has never been so configured, this element is not returned.
        /// </para>
        /// </summary>
        public bool? EnableMfaDelete
        {
            get { return this._enableMfaDelete; }
            set { this._enableMfaDelete = value; }
        }

        // Check to see if EnableMfaDelete property is set
        internal bool IsSetEnableMfaDelete()
        {
            return this._enableMfaDelete.HasValue;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The versioning state of the bucket.
        /// </para>
        /// </summary>
        public VersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
             return this._status != null && this._status != VersionStatus.Off;
        }

    }
}