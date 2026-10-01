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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Defines tag propagation configuration for resources created within a domain. Tags
    /// specified here will be automatically applied to resources being created for the specified
    /// resource type.
    /// </summary>
    public partial class TagPropagationConfiguration
    {
        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Supported resource types for tag propagation. Determines which resources will receive
        /// automatically propagated tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TagPropagationResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property TagMap. 
        /// <para>
        /// The tags that will be applied to the created resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public Dictionary<string, string> TagMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TagMap property is set.
        /// </summary>
        internal bool IsSetTagMap() => this.TagMap != null && (this.TagMap.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
