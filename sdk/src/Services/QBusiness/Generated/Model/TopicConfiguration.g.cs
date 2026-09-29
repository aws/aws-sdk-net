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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The topic specific controls configured for an Amazon Q Business application.
    /// </summary>
    public partial class TopicConfiguration
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for your topic control configuration. Use this to outline how the large
        /// language model (LLM) should use this topic control configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 350)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExampleChatMessages. 
        /// <para>
        /// A list of example phrases that you expect the end user to use in relation to the topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<string> ExampleChatMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExampleChatMessages property is set.
        /// </summary>
        internal bool IsSetExampleChatMessages() => this.ExampleChatMessages != null && (this.ExampleChatMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for your topic control configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Rules defined for a topic configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public List<Rule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
