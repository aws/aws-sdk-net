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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configuration for deletion protection.
    /// </summary>
    public partial class DeletionProtectionConfiguration
    {
        private EnabledOrDisabledState _deletionProtectionStatus;
        private int? _deletionProtectionThreshold;

        /// <summary>
        /// Gets and sets the property DeletionProtectionStatus. 
        /// <para>
        /// Enable or disable deletion protection for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnabledOrDisabledState DeletionProtectionStatus
        {
            get { return this._deletionProtectionStatus; }
            set { this._deletionProtectionStatus = value; }
        }

        // Check to see if DeletionProtectionStatus property is set
        internal bool IsSetDeletionProtectionStatus()
        {
            return this._deletionProtectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionThreshold. 
        /// <para>
        /// The threshold is the maximum percentage of documents that a sync job can delete from
        /// your index. If a sync would delete more than this percentage, the sync skips its delete
        /// phase, leaving your indexed documents in place. Not supported for the Custom connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? DeletionProtectionThreshold
        {
            get { return this._deletionProtectionThreshold; }
            set { this._deletionProtectionThreshold = value; }
        }

        // Check to see if DeletionProtectionThreshold property is set
        internal bool IsSetDeletionProtectionThreshold()
        {
            return this._deletionProtectionThreshold.HasValue; 
        }

    }
}