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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The S3 log configuration.
    /// </summary>
    public partial class S3LogConfiguration
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The S3 bucket name where logs are delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property BucketOwner. 
        /// <para>
        /// The expected bucket owner of the target S3 bucket. The caller must have permissions
        /// to write to the target bucket.
        /// </para>
        /// </summary>
        public string BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the BucketOwner property is set.
        /// </summary>
        internal bool IsSetBucketOwner() => this.BucketOwner != null;

        /// <summary>
        /// Gets and sets the property FolderStructure. 
        /// <para>
        /// The folder structure that defines the organizational structure for log files in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FolderStructure FolderStructure { get; set; }

        /// <summary>
        /// Checks to see if the FolderStructure property is set.
        /// </summary>
        internal bool IsSetFolderStructure() => this.FolderStructure != null;

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// The S3 path prefix that determines where log files are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the KeyPrefix property is set.
        /// </summary>
        internal bool IsSetKeyPrefix() => this.KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property LogFileFormat. 
        /// <para>
        /// The format of the LogFile that is written to S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogFileFormat LogFileFormat { get; set; }

        /// <summary>
        /// Checks to see if the LogFileFormat property is set.
        /// </summary>
        internal bool IsSetLogFileFormat() => this.LogFileFormat != null;
    }
}
