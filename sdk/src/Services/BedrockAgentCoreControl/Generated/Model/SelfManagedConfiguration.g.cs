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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A configuration for a self-managed memory strategy.
    /// </summary>
    public partial class SelfManagedConfiguration
    {
        /// <summary>
        /// Gets and sets the property HistoricalContextWindowSize. 
        /// <para>
        /// The number of historical messages to include in processing context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? HistoricalContextWindowSize { get; set; }

        /// <summary>
        /// Checks to see if the HistoricalContextWindowSize property is set.
        /// </summary>
        internal bool IsSetHistoricalContextWindowSize() => this.HistoricalContextWindowSize.HasValue;

        /// <summary>
        /// Gets and sets the property InvocationConfiguration. 
        /// <para>
        /// The configuration to use when invoking memory processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvocationConfiguration InvocationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InvocationConfiguration property is set.
        /// </summary>
        internal bool IsSetInvocationConfiguration() => this.InvocationConfiguration != null;

        /// <summary>
        /// Gets and sets the property TriggerConditions. 
        /// <para>
        /// A list of conditions that trigger memory processing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<TriggerCondition> TriggerConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<TriggerCondition>() : null;

        /// <summary>
        /// Checks to see if the TriggerConditions property is set.
        /// </summary>
        internal bool IsSetTriggerConditions() => this.TriggerConditions != null && (this.TriggerConditions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
