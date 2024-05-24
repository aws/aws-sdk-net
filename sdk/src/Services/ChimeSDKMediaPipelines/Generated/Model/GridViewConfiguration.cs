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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Specifies the type of grid layout.
    /// </summary>
    public partial class GridViewConfiguration
    {
        private ActiveSpeakerOnlyConfiguration _activeSpeakerOnlyConfiguration;
        private CanvasOrientation _canvasOrientation;
        private ContentShareLayoutOption _contentShareLayout;
        private HorizontalLayoutConfiguration _horizontalLayoutConfiguration;
        private PresenterOnlyConfiguration _presenterOnlyConfiguration;
        private VerticalLayoutConfiguration _verticalLayoutConfiguration;
        private VideoAttribute _videoAttribute;

        /// <summary>
        /// Gets and sets the property ActiveSpeakerOnlyConfiguration. 
        /// <para>
        /// The configuration settings for an <c>ActiveSpeakerOnly</c> video tile.
        /// </para>
        /// </summary>
        public ActiveSpeakerOnlyConfiguration ActiveSpeakerOnlyConfiguration
        {
            get { return this._activeSpeakerOnlyConfiguration; }
            set { this._activeSpeakerOnlyConfiguration = value; }
        }

        // Check to see if ActiveSpeakerOnlyConfiguration property is set
        internal bool IsSetActiveSpeakerOnlyConfiguration()
        {
            return this._activeSpeakerOnlyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CanvasOrientation. 
        /// <para>
        /// The orientation setting, horizontal or vertical.
        /// </para>
        /// </summary>
        public CanvasOrientation CanvasOrientation
        {
            get { return this._canvasOrientation; }
            set { this._canvasOrientation = value; }
        }

        // Check to see if CanvasOrientation property is set
        internal bool IsSetCanvasOrientation()
        {
            return this._canvasOrientation != null;
        }

        /// <summary>
        /// Gets and sets the property ContentShareLayout. 
        /// <para>
        /// Defines the layout of the video tiles when content sharing is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentShareLayoutOption ContentShareLayout
        {
            get { return this._contentShareLayout; }
            set { this._contentShareLayout = value; }
        }

        // Check to see if ContentShareLayout property is set
        internal bool IsSetContentShareLayout()
        {
            return this._contentShareLayout != null;
        }

        /// <summary>
        /// Gets and sets the property HorizontalLayoutConfiguration. 
        /// <para>
        /// The configuration settings for a horizontal layout.
        /// </para>
        /// </summary>
        public HorizontalLayoutConfiguration HorizontalLayoutConfiguration
        {
            get { return this._horizontalLayoutConfiguration; }
            set { this._horizontalLayoutConfiguration = value; }
        }

        // Check to see if HorizontalLayoutConfiguration property is set
        internal bool IsSetHorizontalLayoutConfiguration()
        {
            return this._horizontalLayoutConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PresenterOnlyConfiguration. 
        /// <para>
        /// Defines the configuration options for a presenter only video tile.
        /// </para>
        /// </summary>
        public PresenterOnlyConfiguration PresenterOnlyConfiguration
        {
            get { return this._presenterOnlyConfiguration; }
            set { this._presenterOnlyConfiguration = value; }
        }

        // Check to see if PresenterOnlyConfiguration property is set
        internal bool IsSetPresenterOnlyConfiguration()
        {
            return this._presenterOnlyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VerticalLayoutConfiguration. 
        /// <para>
        /// The configuration settings for a vertical layout.
        /// </para>
        /// </summary>
        public VerticalLayoutConfiguration VerticalLayoutConfiguration
        {
            get { return this._verticalLayoutConfiguration; }
            set { this._verticalLayoutConfiguration = value; }
        }

        // Check to see if VerticalLayoutConfiguration property is set
        internal bool IsSetVerticalLayoutConfiguration()
        {
            return this._verticalLayoutConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VideoAttribute. 
        /// <para>
        /// The attribute settings for the video tiles.
        /// </para>
        /// </summary>
        public VideoAttribute VideoAttribute
        {
            get { return this._videoAttribute; }
            set { this._videoAttribute = value; }
        }

        // Check to see if VideoAttribute property is set
        internal bool IsSetVideoAttribute()
        {
            return this._videoAttribute != null;
        }

    }
}