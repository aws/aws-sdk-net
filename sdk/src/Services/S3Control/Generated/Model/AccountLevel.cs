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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for the account level Amazon S3 Storage Lens configuration.
    /// </summary>
    public partial class AccountLevel
    {
        private ActivityMetrics _activityMetrics;
        private BucketLevel _bucketLevel;

        /// <summary>
        /// Gets and sets the property ActivityMetrics. 
        /// <para>
        /// A container for the S3 Storage Lens activity metrics.
        /// </para>
        /// </summary>
        public ActivityMetrics ActivityMetrics
        {
            get { return this._activityMetrics; }
            set { this._activityMetrics = value; }
        }

        // Check to see if ActivityMetrics property is set
        internal bool IsSetActivityMetrics()
        {
            return this._activityMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property BucketLevel. 
        /// <para>
        /// A container for the S3 Storage Lens bucket-level configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BucketLevel BucketLevel
        {
            get { return this._bucketLevel; }
            set { this._bucketLevel = value; }
        }

        // Check to see if BucketLevel property is set
        internal bool IsSetBucketLevel()
        {
            return this._bucketLevel != null;
        }

    }
}