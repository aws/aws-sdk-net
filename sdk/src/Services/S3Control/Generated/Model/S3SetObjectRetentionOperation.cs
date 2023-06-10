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
    /// Contains the configuration parameters for the Object Lock retention action for an
    /// S3 Batch Operations job. Batch Operations passes every object to the underlying <code>PutObjectRetention</code>
    /// API operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-retention-date.html">Using
    /// S3 Object Lock retention with S3 Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public partial class S3SetObjectRetentionOperation
    {
        private bool? _bypassGovernanceRetention;
        private S3Retention _retention;

        /// <summary>
        /// Gets and sets the property BypassGovernanceRetention. 
        /// <para>
        /// Indicates if the action should be applied to objects in the Batch Operations job even
        /// if they have Object Lock <code> GOVERNANCE</code> type in place.
        /// </para>
        /// </summary>
        public bool BypassGovernanceRetention
        {
            get { return this._bypassGovernanceRetention.GetValueOrDefault(); }
            set { this._bypassGovernanceRetention = value; }
        }

        // Check to see if BypassGovernanceRetention property is set
        internal bool IsSetBypassGovernanceRetention()
        {
            return this._bypassGovernanceRetention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Retention. 
        /// <para>
        /// Contains the Object Lock retention mode to be applied to all objects in the Batch
        /// Operations job. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-retention-date.html">Using
        /// S3 Object Lock retention with S3 Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Retention Retention
        {
            get { return this._retention; }
            set { this._retention = value; }
        }

        // Check to see if Retention property is set
        internal bool IsSetRetention()
        {
            return this._retention != null;
        }

    }
}