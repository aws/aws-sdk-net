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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The S3 log configuration.
    /// </summary>
    public partial class S3LogConfiguration
    {
        private string _bucket;
        private string _bucketOwner;
        private FolderStructure _folderStructure;
        private string _keyPrefix;
        private LogFileFormat _logFileFormat;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The S3 bucket name where logs are delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property BucketOwner. 
        /// <para>
        /// The expected bucket owner of the target S3 bucket. The caller must have permissions
        /// to write to the target bucket.
        /// </para>
        /// </summary>
        public string BucketOwner
        {
            get { return this._bucketOwner; }
            set { this._bucketOwner = value; }
        }

        // Check to see if BucketOwner property is set
        internal bool IsSetBucketOwner()
        {
            return this._bucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property FolderStructure. 
        /// <para>
        /// The folder structure that defines the organizational structure for log files in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FolderStructure FolderStructure
        {
            get { return this._folderStructure; }
            set { this._folderStructure = value; }
        }

        // Check to see if FolderStructure property is set
        internal bool IsSetFolderStructure()
        {
            return this._folderStructure != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// The S3 path prefix that determines where log files are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string KeyPrefix
        {
            get { return this._keyPrefix; }
            set { this._keyPrefix = value; }
        }

        // Check to see if KeyPrefix property is set
        internal bool IsSetKeyPrefix()
        {
            return this._keyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property LogFileFormat. 
        /// <para>
        /// The format of the LogFile that is written to S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogFileFormat LogFileFormat
        {
            get { return this._logFileFormat; }
            set { this._logFileFormat = value; }
        }

        // Check to see if LogFileFormat property is set
        internal bool IsSetLogFileFormat()
        {
            return this._logFileFormat != null;
        }

    }
}