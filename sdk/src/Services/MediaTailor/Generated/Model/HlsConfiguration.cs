/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for HLS content.
    /// </summary>
    public partial class HlsConfiguration
    {
        private string _manifestEndpointPrefix;

        /// <summary>
        /// Gets and sets the property ManifestEndpointPrefix. 
        /// <para>
        /// The URL that is used to initiate a playback session for devices that support Apple
        /// HLS. The session uses server-side reporting.
        /// </para>
        /// </summary>
        public string ManifestEndpointPrefix
        {
            get { return this._manifestEndpointPrefix; }
            set { this._manifestEndpointPrefix = value; }
        }

        // Check to see if ManifestEndpointPrefix property is set
        internal bool IsSetManifestEndpointPrefix()
        {
            return this._manifestEndpointPrefix != null;
        }

    }
}