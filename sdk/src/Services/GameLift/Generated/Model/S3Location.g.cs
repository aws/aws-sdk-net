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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// The location in Amazon S3 where build or script files are stored for access by Amazon
    /// GameLift Servers.
    /// </summary>
    public partial class S3Location
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// An Amazon S3 bucket identifier. The name of the S3 bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon GameLift Servers doesn't support uploading from Amazon S3 buckets with names
        /// that contain a dot (.).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the zip file that contains the build files or script files. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property ObjectVersion. 
        /// <para>
        /// The version of the file, if object versioning is turned on for the bucket. Amazon
        /// GameLift Servers uses this information when retrieving files from an S3 bucket that
        /// you own. Use this parameter to specify a specific version of the file. If not set,
        /// the latest version of the file is retrieved. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ObjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the ObjectVersion property is set.
        /// </summary>
        internal bool IsSetObjectVersion() => this.ObjectVersion != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// for an IAM role that allows Amazon GameLift Servers to access the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
