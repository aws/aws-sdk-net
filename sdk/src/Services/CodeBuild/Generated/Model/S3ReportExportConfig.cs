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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the S3 bucket where the raw data of a report are exported.
    /// </summary>
    public partial class S3ReportExportConfig
    {
        private string _bucket;
        private string _bucketOwner;
        private bool? _encryptionDisabled;
        private string _encryptionKey;
        private ReportPackagingType _packaging;
        private string _path;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        ///  The name of the S3 bucket where the raw data of a report are exported. 
        /// </para>
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
        /// Gets and sets the property BucketOwner. 
        /// <para>
        /// The Amazon Web Services account identifier of the owner of the Amazon S3 bucket. This
        /// allows report data to be exported to an Amazon S3 bucket that is owned by an account
        /// other than the account running the build.
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
        /// Gets and sets the property EncryptionDisabled. 
        /// <para>
        ///  A boolean value that specifies if the results of a report are encrypted. 
        /// </para>
        /// </summary>
        public bool? EncryptionDisabled
        {
            get { return this._encryptionDisabled; }
            set { this._encryptionDisabled = value; }
        }

        // Check to see if EncryptionDisabled property is set
        internal bool IsSetEncryptionDisabled()
        {
            return this._encryptionDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        ///  The encryption key for the report's encrypted raw data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Packaging. 
        /// <para>
        ///  The type of build output artifact to create. Valid values include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: CodeBuild creates the raw data in the output bucket. This is the default
        /// if packaging is not specified. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZIP</c>: CodeBuild creates a ZIP file with the raw data in the output bucket.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReportPackagingType Packaging
        {
            get { return this._packaging; }
            set { this._packaging = value; }
        }

        // Check to see if Packaging property is set
        internal bool IsSetPackaging()
        {
            return this._packaging != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path to the exported report's raw data results. 
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}