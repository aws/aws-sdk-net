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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies an encryption configuration.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private CloudWatchEncryption _cloudWatchEncryption;
        private JobBookmarksEncryption _jobBookmarksEncryption;
        private List<S3Encryption> _s3Encryption = new List<S3Encryption>();

        /// <summary>
        /// Gets and sets the property CloudWatchEncryption. 
        /// <para>
        /// The encryption configuration for CloudWatch.
        /// </para>
        /// </summary>
        public CloudWatchEncryption CloudWatchEncryption
        {
            get { return this._cloudWatchEncryption; }
            set { this._cloudWatchEncryption = value; }
        }

        // Check to see if CloudWatchEncryption property is set
        internal bool IsSetCloudWatchEncryption()
        {
            return this._cloudWatchEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property JobBookmarksEncryption. 
        /// <para>
        /// The encryption configuration for Job Bookmarks.
        /// </para>
        /// </summary>
        public JobBookmarksEncryption JobBookmarksEncryption
        {
            get { return this._jobBookmarksEncryption; }
            set { this._jobBookmarksEncryption = value; }
        }

        // Check to see if JobBookmarksEncryption property is set
        internal bool IsSetJobBookmarksEncryption()
        {
            return this._jobBookmarksEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property S3Encryption. 
        /// <para>
        /// The encryption configuration for S3 data.
        /// </para>
        /// </summary>
        public List<S3Encryption> S3Encryption
        {
            get { return this._s3Encryption; }
            set { this._s3Encryption = value; }
        }

        // Check to see if S3Encryption property is set
        internal bool IsSetS3Encryption()
        {
            return this._s3Encryption != null && this._s3Encryption.Count > 0; 
        }

    }
}