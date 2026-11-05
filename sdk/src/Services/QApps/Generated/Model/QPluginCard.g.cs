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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// A card in an Q App that integrates with a third-party plugin or service.
    /// </summary>
    public partial class QPluginCard
    {
        /// <summary>
        /// Gets and sets the property ActionIdentifier. 
        /// <para>
        /// The action identifier of the action to be performed by the plugin card.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ActionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ActionIdentifier property is set.
        /// </summary>
        internal bool IsSetActionIdentifier() => this.ActionIdentifier != null;

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// Any dependencies or requirements for the plugin card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Dependencies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Dependencies property is set.
        /// </summary>
        internal bool IsSetDependencies() => this.Dependencies != null && (this.Dependencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the plugin card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The unique identifier of the plugin used by the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PluginId { get; set; }

        /// <summary>
        /// Checks to see if the PluginId property is set.
        /// </summary>
        internal bool IsSetPluginId() => this.PluginId != null;

        /// <summary>
        /// Gets and sets the property PluginType. 
        /// <para>
        /// The type or category of the plugin used by the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PluginType PluginType { get; set; }

        /// <summary>
        /// Checks to see if the PluginType property is set.
        /// </summary>
        internal bool IsSetPluginType() => this.PluginType != null;

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// The prompt or instructions displayed for the plugin card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 50000)]
        public string Prompt { get; set; }

        /// <summary>
        /// Checks to see if the Prompt property is set.
        /// </summary>
        internal bool IsSetPrompt() => this.Prompt != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title or label of the plugin card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CardType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
