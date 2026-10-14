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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the S3 bucket where the raw data of a report are exported.
    /// </summary>
    public partial class S3ReportExportConfig
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        ///  The name of the S3 bucket where the raw data of a report are exported. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property BucketOwner. 
        /// <para>
        /// The Amazon Web Services account identifier of the owner of the Amazon S3 bucket. This
        /// allows report data to be exported to an Amazon S3 bucket that is owned by an account
        /// other than the account running the build.
        /// </para>
        /// </summary>
        public string BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the BucketOwner property is set.
        /// </summary>
        internal bool IsSetBucketOwner() => this.BucketOwner != null;

        /// <summary>
        /// Gets and sets the property EncryptionDisabled. 
        /// <para>
        ///  A boolean value that specifies if the results of a report are encrypted. 
        /// </para>
        /// </summary>
        public bool? EncryptionDisabled { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionDisabled property is set.
        /// </summary>
        internal bool IsSetEncryptionDisabled() => this.EncryptionDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        ///  The encryption key for the report's encrypted raw data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

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
        public ReportPackagingType Packaging { get; set; }

        /// <summary>
        /// Checks to see if the Packaging property is set.
        /// </summary>
        internal bool IsSetPackaging() => this.Packaging != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path to the exported report's raw data results. 
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;
    }
}
