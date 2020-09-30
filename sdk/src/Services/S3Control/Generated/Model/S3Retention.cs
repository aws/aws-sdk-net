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
    /// Contains the S3 Object Lock retention mode to be applied to all objects in the S3
    /// Batch Operations job. If you don't provide <code>Mode</code> and <code>RetainUntilDate</code>
    /// data types in your operation, you will remove the retention from your objects. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-retention-date.html">Using
    /// S3 Object Lock retention with S3 Batch Operations</a> in the <i>Amazon Simple Storage
    /// Service Developer Guide</i>.
    /// </summary>
    public partial class S3Retention
    {
        private S3ObjectLockRetentionMode _mode;
        private DateTime? _retainUntilDate;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The Object Lock retention mode to be applied to all objects in the Batch Operations
        /// job.
        /// </para>
        /// </summary>
        public S3ObjectLockRetentionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property RetainUntilDate. 
        /// <para>
        /// The date when the applied Object Lock retention will expire on all objects set by
        /// the Batch Operations job.
        /// </para>
        /// </summary>
        public DateTime RetainUntilDate
        {
            get { return this._retainUntilDate.GetValueOrDefault(); }
            set { this._retainUntilDate = value; }
        }

        // Check to see if RetainUntilDate property is set
        internal bool IsSetRetainUntilDate()
        {
            return this._retainUntilDate.HasValue; 
        }

    }
}