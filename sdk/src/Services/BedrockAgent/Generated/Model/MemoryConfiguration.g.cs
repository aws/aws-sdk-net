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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EnabledMemoryTypes. 
        /// <para>
        /// The type of memory that is stored. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> EnabledMemoryTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledMemoryTypes property is set.
        /// </summary>
        internal bool IsSetEnabledMemoryTypes() => this.EnabledMemoryTypes != null && (this.EnabledMemoryTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionSummaryConfiguration. 
        /// <para>
        /// Contains the configuration for SESSION_SUMMARY memory type enabled for the agent.
        /// 
        /// </para>
        /// </summary>
        public SessionSummaryConfiguration SessionSummaryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SessionSummaryConfiguration property is set.
        /// </summary>
        internal bool IsSetSessionSummaryConfiguration() => this.SessionSummaryConfiguration != null;

        /// <summary>
        /// Gets and sets the property StorageDays. 
        /// <para>
        /// The number of days the agent is configured to retain the conversational context.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 365)]
        public int? StorageDays { get; set; }

        /// <summary>
        /// Checks to see if the StorageDays property is set.
        /// </summary>
        internal bool IsSetStorageDays() => this.StorageDays.HasValue;
    }
}
