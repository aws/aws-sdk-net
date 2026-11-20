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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Associates blueprints with a project to produce custom structured output. A fallback
    /// blueprint can be supplied for documents that do not match a primary blueprint.
    /// </summary>
    public partial class CustomConfiguration
    {
        /// <summary>
        /// Gets and sets the property Blueprints. 
        /// <para>
        /// The blueprints used to extract custom structured output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public List<BlueprintItem> Blueprints { get; set; } = AWSConfigs.InitializeCollections ? new List<BlueprintItem>() : null;

        /// <summary>
        /// Checks to see if the Blueprints property is set.
        /// </summary>
        internal bool IsSetBlueprints() => this.Blueprints != null && (this.Blueprints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FallbackBlueprints. 
        /// <para>
        /// The blueprint used when a document does not match any of the primary blueprints. Requires
        /// at least one blueprint in <c>Blueprints</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<BlueprintItem> FallbackBlueprints { get; set; } = AWSConfigs.InitializeCollections ? new List<BlueprintItem>() : null;

        /// <summary>
        /// Checks to see if the FallbackBlueprints property is set.
        /// </summary>
        internal bool IsSetFallbackBlueprints() => this.FallbackBlueprints != null && (this.FallbackBlueprints.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
