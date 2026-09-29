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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAgentSpace operation. Updates the information
    /// of an existing AgentSpace.
    /// </summary>
    public partial class UpdateAgentSpaceRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the AgentSpace
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the AgentSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The updated locale for the AgentSpace, which determines the language used in agent
        /// responses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the AgentSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Preferences. 
        /// <para>
        /// The preferences to configure on the agent space. When provided, this replaces the
        /// full set of configured preferences; preferences not included revert to their default
        /// values. When omitted, the current preferences are left unchanged.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 25)]
        public Dictionary<string, bool> Preferences { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;

        /// <summary>
        /// Checks to see if the Preferences property is set.
        /// </summary>
        internal bool IsSetPreferences() => this.Preferences != null && (this.Preferences.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
