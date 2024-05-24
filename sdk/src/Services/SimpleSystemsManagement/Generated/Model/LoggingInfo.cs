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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about an Amazon Simple Storage Service (Amazon S3) bucket to write managed
    /// node-level logs to.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>LoggingInfo</c> has been deprecated. To specify an Amazon Simple Storage Service
    /// (Amazon S3) bucket to contain logs, instead use the <c>OutputS3BucketName</c> and
    /// <c>OutputS3KeyPrefix</c> options in the <c>TaskInvocationParameters</c> structure.
    /// For information about how Amazon Web Services Systems Manager handles these options
    /// for the supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LoggingInfo
    {
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _s3Region;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of an S3 bucket where execution logs are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// (Optional) The S3 bucket subfolder. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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

        /// <summary>
        /// Gets and sets the property S3Region. 
        /// <para>
        /// The Amazon Web Services Region where the S3 bucket is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=20)]
        public string S3Region
        {
            get { return this._s3Region; }
            set { this._s3Region = value; }
        }

        // Check to see if S3Region property is set
        internal bool IsSetS3Region()
        {
            return this._s3Region != null;
        }

    }
}