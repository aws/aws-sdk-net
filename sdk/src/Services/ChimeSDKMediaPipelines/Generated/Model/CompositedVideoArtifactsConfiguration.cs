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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Specifies the configuration for compositing video artifacts.
    /// </summary>
    public partial class CompositedVideoArtifactsConfiguration
    {
        private GridViewConfiguration _gridViewConfiguration;
        private LayoutOption _layout;
        private ResolutionOption _resolution;

        /// <summary>
        /// Gets and sets the property GridViewConfiguration. 
        /// <para>
        /// The <code>GridView</code> configuration setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GridViewConfiguration GridViewConfiguration
        {
            get { return this._gridViewConfiguration; }
            set { this._gridViewConfiguration = value; }
        }

        // Check to see if GridViewConfiguration property is set
        internal bool IsSetGridViewConfiguration()
        {
            return this._gridViewConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// The layout setting, such as <code>GridView</code> in the configuration object.
        /// </para>
        /// </summary>
        public LayoutOption Layout
        {
            get { return this._layout; }
            set { this._layout = value; }
        }

        // Check to see if Layout property is set
        internal bool IsSetLayout()
        {
            return this._layout != null;
        }

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// The video resolution setting in the configuration object. Default: HD at 1280 x 720.
        /// FHD resolution: 1920 x 1080.
        /// </para>
        /// </summary>
        public ResolutionOption Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

    }
}