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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An optional structure that contains the Amazon S3 bucket configuration that the generated
    /// snapshots are stored in. If you don't provide this information, generated snapshots
    /// are stored in the default QuickSight bucket.
    /// </summary>
    public partial class S3BucketConfiguration
    {
        private string _bucketName;
        private string _bucketPrefix;
        private string _bucketRegion;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of an existing Amazon S3 bucket where the generated snapshot artifacts are
        /// sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        /// The prefix of the Amazon S3 bucket that the generated snapshots are stored in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketPrefix
        {
            get { return this._bucketPrefix; }
            set { this._bucketPrefix = value; }
        }

        // Check to see if BucketPrefix property is set
        internal bool IsSetBucketPrefix()
        {
            return this._bucketPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property BucketRegion. 
        /// <para>
        /// The region that the Amazon S3 bucket is located in. The bucket must be located in
        /// the same region that the <c>StartDashboardSnapshotJob</c> API call is made.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketRegion
        {
            get { return this._bucketRegion; }
            set { this._bucketRegion = value; }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this._bucketRegion != null;
        }

    }
}