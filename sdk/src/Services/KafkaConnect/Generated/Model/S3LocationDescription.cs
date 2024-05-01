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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// The description of the location of an object in Amazon S3.
    /// </summary>
    public partial class S3LocationDescription
    {
        private string _bucketArn;
        private string _fileKey;
        private string _objectVersion;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an S3 bucket.
        /// </para>
        /// </summary>
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property FileKey. 
        /// <para>
        /// The file key for an object in an S3 bucket.
        /// </para>
        /// </summary>
        public string FileKey
        {
            get { return this._fileKey; }
            set { this._fileKey = value; }
        }

        // Check to see if FileKey property is set
        internal bool IsSetFileKey()
        {
            return this._fileKey != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectVersion. 
        /// <para>
        /// The version of an object in an S3 bucket.
        /// </para>
        /// </summary>
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

    }
}