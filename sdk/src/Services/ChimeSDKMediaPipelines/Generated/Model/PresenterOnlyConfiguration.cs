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
    /// Defines the configuration for a presenter-only video tile.
    /// </summary>
    public partial class PresenterOnlyConfiguration
    {
        private PresenterPosition _presenterPosition;

        /// <summary>
        /// Gets and sets the property PresenterPosition. 
        /// <para>
        /// Defines the position of the presenter video tile. Default: <c>TopRight</c>.
        /// </para>
        /// </summary>
        public PresenterPosition PresenterPosition
        {
            get { return this._presenterPosition; }
            set { this._presenterPosition = value; }
        }

        // Check to see if PresenterPosition property is set
        internal bool IsSetPresenterPosition()
        {
            return this._presenterPosition != null;
        }

    }
}