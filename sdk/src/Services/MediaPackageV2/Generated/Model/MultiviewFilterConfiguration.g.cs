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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The multiview combination for a pinned manifest. MediaPackage serves the manifest
    /// with this layout and these sources, so players request it without an <c>aws.multiview</c>
    /// query parameter.
    /// 
    ///  
    /// <para>
    /// If a request for a pinned manifest also includes an <c>aws.multiview</c> query parameter,
    /// MediaPackage rejects the request, even when that parameter requests the same combination.
    /// </para>
    /// </summary>
    public partial class MultiviewFilterConfiguration
    {
        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// The layout that MediaPackage uses to composite the tiles into a single output. This
        /// layout must be one of the <c>AvailableLayouts</c> of the channel that this origin
        /// endpoint is on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MultiviewLayoutType Layout { get; set; }

        /// <summary>
        /// Checks to see if the Layout property is set.
        /// </summary>
        internal bool IsSetLayout() => this.Layout != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The source channels to composite, in tile order. Each channel must be one of the <c>AvailableSources</c>
        /// of the channel that this origin endpoint is on, and the number of channels must equal
        /// the number of tiles in <c>Layout</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
