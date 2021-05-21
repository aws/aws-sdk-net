/* 
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;


namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for AnalyticsS3BucketDestination
    /// </summary>
    public class AnalyticsS3BucketDestination
    {
        private AnalyticsS3ExportFileFormat analyticsS3ExportFileFormat;
        private string accountId;
        private string bucketName;
        private string prefix;

        /// <summary>
        /// The account ID that owns the destination bucket. If no account ID is provided, the owner will not be validated prior to exporting data.
        /// </summary>
        public string BucketAccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }
        }

        // Check to see if BucketAccountId property is set
        internal bool IsSetBucketAccountId()
        {
            return !(string.IsNullOrEmpty(this.accountId));
        }

        /// <summary>
        /// The Amazon resource name (ARN) of the bucket to which data is exported.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }

        /// <summary>
        /// The file format used when exporting data to Amazon S3.
        /// </summary>
        public string Format
        {
            get { return this.analyticsS3ExportFileFormat; }
            set { this.analyticsS3ExportFileFormat = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this.analyticsS3ExportFileFormat != null;
        }

        /// <summary>
        /// The prefix to use when exporting data. The exported data begins with this prefix.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetPrefix()
        {
            return !(string.IsNullOrEmpty(this.prefix));
        }
    }
}
