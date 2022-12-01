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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// The location in Amazon S3 where build or script files are stored for access by Amazon
    /// GameLift.
    /// </summary>
    public partial class S3Location
    {
        private string _bucket;
        private string _key;
        private string _objectVersion;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// An Amazon S3 bucket identifier. Thename of the S3 bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// GameLift doesn't support uploading from Amazon S3 buckets with names that contain
        /// a dot (.).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the zip file that contains the build files or script files. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectVersion. 
        /// <para>
        /// The version of the file, if object versioning is turned on for the bucket. Amazon
        /// GameLift uses this information when retrieving files from an S3 bucket that you own.
        /// Use this parameter to specify a specific version of the file. If not set, the latest
        /// version of the file is retrieved. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ObjectVersion
        {
            get { return this._objectVersion; }
            set { this._objectVersion = value; }
        }

        // Check to see if ObjectVersion property is set
        internal bool IsSetObjectVersion()
        {
            return this._objectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// for an IAM role that allows Amazon GameLift to access the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}