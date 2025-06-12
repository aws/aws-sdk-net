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
    /// Details of the memory configuration.
    /// </summary>
    public partial class MemoryConfiguration
    {
        private List<string> _enabledMemoryTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SessionSummaryConfiguration _sessionSummaryConfiguration;
        private int? _storageDays;

        /// <summary>
        /// Gets and sets the property EnabledMemoryTypes. 
        /// <para>
        /// The type of memory that is stored. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> EnabledMemoryTypes
        {
            get { return this._enabledMemoryTypes; }
            set { this._enabledMemoryTypes = value; }
        }

        // Check to see if EnabledMemoryTypes property is set
        internal bool IsSetEnabledMemoryTypes()
        {
            return this._enabledMemoryTypes != null && (this._enabledMemoryTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionSummaryConfiguration. 
        /// <para>
        /// Contains the configuration for SESSION_SUMMARY memory type enabled for the agent.
        /// 
        /// </para>
        /// </summary>
        public SessionSummaryConfiguration SessionSummaryConfiguration
        {
            get { return this._sessionSummaryConfiguration; }
            set { this._sessionSummaryConfiguration = value; }
        }

        // Check to see if SessionSummaryConfiguration property is set
        internal bool IsSetSessionSummaryConfiguration()
        {
            return this._sessionSummaryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StorageDays. 
        /// <para>
        /// The number of days the agent is configured to retain the conversational context.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=365)]
        public int? StorageDays
        {
            get { return this._storageDays; }
            set { this._storageDays = value; }
        }

        // Check to see if StorageDays property is set
        internal bool IsSetStorageDays()
        {
            return this._storageDays.HasValue; 
        }

    }
}