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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Specifies the configuration for compositing video artifacts.
    /// </summary>
    public partial class CompositedVideoArtifactsConfiguration
    {
        /// <summary>
        /// Gets and sets the property GridViewConfiguration. 
        /// <para>
        /// The <c>GridView</c> configuration setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GridViewConfiguration GridViewConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GridViewConfiguration property is set.
        /// </summary>
        internal bool IsSetGridViewConfiguration() => this.GridViewConfiguration != null;

        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// The layout setting, such as <c>GridView</c> in the configuration object.
        /// </para>
        /// </summary>
        public LayoutOption Layout { get; set; }

        /// <summary>
        /// Checks to see if the Layout property is set.
        /// </summary>
        internal bool IsSetLayout() => this.Layout != null;

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// The video resolution setting in the configuration object. Default: HD at 1280 x 720.
        /// FHD resolution: 1920 x 1080.
        /// </para>
        /// </summary>
        public ResolutionOption Resolution { get; set; }

        /// <summary>
        /// Checks to see if the Resolution property is set.
        /// </summary>
        internal bool IsSetResolution() => this.Resolution != null;
    }
}
