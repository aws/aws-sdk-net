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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutStorageTierPolicy operation.
    /// Sets the storage tier policy for your account. When you set the storage tier to <c>INTELLIGENT_TIERING</c>,
    /// CloudWatch Logs automatically moves your log data between storage tiers based on access
    /// patterns to optimize costs.
    /// </summary>
    public partial class PutStorageTierPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private StorageTier _storageTier;

        /// <summary>
        /// Gets and sets the property StorageTier. 
        /// <para>
        /// The storage tier to set for the account. Valid values are <c>STANDARD</c> and <c>INTELLIGENT_TIERING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageTier StorageTier
        {
            get { return this._storageTier; }
            set { this._storageTier = value; }
        }

        // Check to see if StorageTier property is set
        internal bool IsSetStorageTier()
        {
            return this._storageTier != null;
        }

    }
}