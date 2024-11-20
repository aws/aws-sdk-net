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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies the Amazon S3 bucket where DataSync uploads your <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">task
    /// report</a>.
    /// </summary>
    public partial class ReportDestinationS3
    {
        private string _bucketAccessRoleArn;
        private string _s3BucketArn;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property BucketAccessRoleArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the IAM policy that allows DataSync to
        /// upload a task report to your S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">Allowing
        /// DataSync to upload a task report to an Amazon S3 bucket</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string BucketAccessRoleArn
        {
            get { return this._bucketAccessRoleArn; }
            set { this._bucketAccessRoleArn = value; }
        }

        // Check to see if BucketAccessRoleArn property is set
        internal bool IsSetBucketAccessRoleArn()
        {
            return this._bucketAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// Specifies the ARN of the S3 bucket where DataSync uploads your report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=268)]
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies a bucket prefix for your report.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

    }
}