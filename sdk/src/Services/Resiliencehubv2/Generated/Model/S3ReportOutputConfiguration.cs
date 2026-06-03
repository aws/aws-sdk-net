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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// S3 configuration for report output.
    /// </summary>
    public partial class S3ReportOutputConfiguration
    {
        private string _bucketOwner;
        private string _bucketPath;

        /// <summary>
        /// Gets and sets the property BucketOwner. 
        /// <para>
        /// Account ID of the bucket owner for cross-account access verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// Gets and sets the property BucketPath. 
        /// <para>
        /// S3 bucket path where reports will be written (e.g., my-bucket/ngrh-reports/).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=512)]
        public string BucketPath
        {
            get { return this._bucketPath; }
            set { this._bucketPath = value; }
        }

        // Check to see if BucketPath property is set
        internal bool IsSetBucketPath()
        {
            return this._bucketPath != null;
        }

    }
}