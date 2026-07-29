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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for managed memory creation.
    /// </summary>
    public partial class HarnessManagedMemoryConfiguration
    {
        private string _arn;
        private string _encryptionKeyArn;
        private int? _eventExpiryDuration;
        private List<string> _strategies = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the managed AgentCore Memory resource. Read-only on Get, ignored on Create/Update
        /// input.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// Customer-managed KMS key. Defaults to AWS-owned key. Not updatable after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventExpiryDuration. 
        /// <para>
        /// Event retention in days. Defaults to 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=365)]
        public int? EventExpiryDuration
        {
            get { return this._eventExpiryDuration; }
            set { this._eventExpiryDuration = value; }
        }

        // Check to see if EventExpiryDuration property is set
        internal bool IsSetEventExpiryDuration()
        {
            return this._eventExpiryDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strategies. 
        /// <para>
        /// Strategy types to enable. Defaults to [SEMANTIC, SUMMARIZATION].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> Strategies
        {
            get { return this._strategies; }
            set { this._strategies = value; }
        }

        // Check to see if Strategies property is set
        internal bool IsSetStrategies()
        {
            return this._strategies != null && (this._strategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}