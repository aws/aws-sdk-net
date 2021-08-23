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
    /// Contains information from your report plan about where to deliver your reports, specifically
    /// your Amazon S3 bucket name, S3 key prefix, and the formats of your reports.
    /// </summary>
    public partial class ReportDeliveryChannel
    {
        private List<string> _formats = new List<string>();
        private string _s3BucketName;
        private string _s3KeyPrefix;

        /// <summary>
        /// Gets and sets the property Formats. 
        /// <para>
        /// A list of the format of your reports: <code>CSV</code>, <code>JSON</code>, or both.
        /// If not specified, the default format is <code>CSV</code>.
        /// </para>
        /// </summary>
        public List<string> Formats
        {
            get { return this._formats; }
            set { this._formats = value; }
        }

        // Check to see if Formats property is set
        internal bool IsSetFormats()
        {
            return this._formats != null && this._formats.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The unique name of the S3 bucket that receives your reports.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The prefix for where Backup Audit Manager delivers your reports to Amazon S3. The
        /// prefix is this part of the following path: s3://your-bucket-name/<code>prefix</code>/Backup/us-west-2/year/month/day/report-name.
        /// If not specified, there is no prefix.
        /// </para>
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

    }
}