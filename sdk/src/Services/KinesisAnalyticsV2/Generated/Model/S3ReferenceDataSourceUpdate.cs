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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For a SQL-based Kinesis Data Analytics application, describes the Amazon S3 bucket
    /// name and object key name for an in-application reference table.
    /// </summary>
    public partial class S3ReferenceDataSourceUpdate
    {
        private string _bucketARNUpdate;
        private string _fileKeyUpdate;

        /// <summary>
        /// Gets and sets the property BucketARNUpdate. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string BucketARNUpdate
        {
            get { return this._bucketARNUpdate; }
            set { this._bucketARNUpdate = value; }
        }

        // Check to see if BucketARNUpdate property is set
        internal bool IsSetBucketARNUpdate()
        {
            return this._bucketARNUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property FileKeyUpdate. 
        /// <para>
        /// The object key name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FileKeyUpdate
        {
            get { return this._fileKeyUpdate; }
            set { this._fileKeyUpdate = value; }
        }

        // Check to see if FileKeyUpdate property is set
        internal bool IsSetFileKeyUpdate()
        {
            return this._fileKeyUpdate != null;
        }

    }
}