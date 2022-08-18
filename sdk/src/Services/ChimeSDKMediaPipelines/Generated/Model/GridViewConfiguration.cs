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
    /// Specifies the type of grid layout.
    /// </summary>
    public partial class GridViewConfiguration
    {
        private ContentShareLayoutOption _contentShareLayout;
        private PresenterOnlyConfiguration _presenterOnlyConfiguration;

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

    }
}