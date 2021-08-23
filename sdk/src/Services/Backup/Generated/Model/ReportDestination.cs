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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains information from your report job about your report destination.
    /// </summary>
    public partial class ReportDestination
    {
        private string _s3BucketName;
        private List<string> _s3Keys = new List<string>();

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The unique name of the Amazon S3 bucket that receives your reports.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3Keys. 
        /// <para>
        /// The object key that uniquely identifies your reports in your S3 bucket.
        /// </para>
        /// </summary>
        public List<string> S3Keys
        {
            get { return this._s3Keys; }
            set { this._s3Keys = value; }
        }

        // Check to see if S3Keys property is set
        internal bool IsSetS3Keys()
        {
            return this._s3Keys != null && this._s3Keys.Count > 0; 
        }

    }
}