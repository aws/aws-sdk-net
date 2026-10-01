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
    /// Specifies the type of grid layout.
    /// </summary>
    public partial class GridViewConfiguration
    {
        /// <summary>
        /// Gets and sets the property ActiveSpeakerOnlyConfiguration. 
        /// <para>
        /// The configuration settings for an <c>ActiveSpeakerOnly</c> video tile.
        /// </para>
        /// </summary>
        public ActiveSpeakerOnlyConfiguration ActiveSpeakerOnlyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ActiveSpeakerOnlyConfiguration property is set.
        /// </summary>
        internal bool IsSetActiveSpeakerOnlyConfiguration() => this.ActiveSpeakerOnlyConfiguration != null;

        /// <summary>
        /// Gets and sets the property CanvasOrientation. 
        /// <para>
        /// The orientation setting, horizontal or vertical.
        /// </para>
        /// </summary>
        public CanvasOrientation CanvasOrientation { get; set; }

        /// <summary>
        /// Checks to see if the CanvasOrientation property is set.
        /// </summary>
        internal bool IsSetCanvasOrientation() => this.CanvasOrientation != null;

        /// <summary>
        /// Gets and sets the property ContentShareLayout. 
        /// <para>
        /// Defines the layout of the video tiles when content sharing is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentShareLayoutOption ContentShareLayout { get; set; }

        /// <summary>
        /// Checks to see if the ContentShareLayout property is set.
        /// </summary>
        internal bool IsSetContentShareLayout() => this.ContentShareLayout != null;

        /// <summary>
        /// Gets and sets the property HorizontalLayoutConfiguration. 
        /// <para>
        /// The configuration settings for a horizontal layout.
        /// </para>
        /// </summary>
        public HorizontalLayoutConfiguration HorizontalLayoutConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HorizontalLayoutConfiguration property is set.
        /// </summary>
        internal bool IsSetHorizontalLayoutConfiguration() => this.HorizontalLayoutConfiguration != null;

        /// <summary>
        /// Gets and sets the property PresenterOnlyConfiguration. 
        /// <para>
        /// Defines the configuration options for a presenter only video tile.
        /// </para>
        /// </summary>
        public PresenterOnlyConfiguration PresenterOnlyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PresenterOnlyConfiguration property is set.
        /// </summary>
        internal bool IsSetPresenterOnlyConfiguration() => this.PresenterOnlyConfiguration != null;

        /// <summary>
        /// Gets and sets the property VerticalLayoutConfiguration. 
        /// <para>
        /// The configuration settings for a vertical layout.
        /// </para>
        /// </summary>
        public VerticalLayoutConfiguration VerticalLayoutConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VerticalLayoutConfiguration property is set.
        /// </summary>
        internal bool IsSetVerticalLayoutConfiguration() => this.VerticalLayoutConfiguration != null;

        /// <summary>
        /// Gets and sets the property VideoAttribute. 
        /// <para>
        /// The attribute settings for the video tiles.
        /// </para>
        /// </summary>
        public VideoAttribute VideoAttribute { get; set; }

        /// <summary>
        /// Checks to see if the VideoAttribute property is set.
        /// </summary>
        internal bool IsSetVideoAttribute() => this.VideoAttribute != null;
    }
}
