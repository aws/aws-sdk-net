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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The ABAC status of the general purpose bucket. When ABAC is enabled for the general
    /// purpose bucket, you can use tags to manage access to the general purpose buckets as
    /// well as for cost tracking purposes. When ABAC is disabled for the general purpose
    /// buckets, you can only use tags for cost tracking purposes. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/buckets-tagging.html">Using
    /// tags with S3 general purpose buckets</a>.
    /// </summary>
    public partial class AbacStatus
    {
        private BucketAbacStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The ABAC status of the general purpose bucket. 
        /// </para>
        /// </summary>
        public BucketAbacStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}