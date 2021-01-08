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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Output Group settings, including type
    /// </summary>
    public partial class OutputGroupSettings
    {
        private CmafGroupSettings _cmafGroupSettings;
        private DashIsoGroupSettings _dashIsoGroupSettings;
        private FileGroupSettings _fileGroupSettings;
        private HlsGroupSettings _hlsGroupSettings;
        private MsSmoothGroupSettings _msSmoothGroupSettings;
        private OutputGroupType _type;

        /// <summary>
        /// Gets and sets the property CmafGroupSettings. Required when you set (Type) under (OutputGroups)>(OutputGroupSettings)
        /// to CMAF_GROUP_SETTINGS. Each output in a CMAF Output Group may only contain a single
        /// video, audio, or caption output.
        /// </summary>
        public CmafGroupSettings CmafGroupSettings
        {
            get { return this._cmafGroupSettings; }
            set { this._cmafGroupSettings = value; }
        }

        // Check to see if CmafGroupSettings property is set
        internal bool IsSetCmafGroupSettings()
        {
            return this._cmafGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DashIsoGroupSettings. Required when you set (Type) under
        /// (OutputGroups)>(OutputGroupSettings) to DASH_ISO_GROUP_SETTINGS.
        /// </summary>
        public DashIsoGroupSettings DashIsoGroupSettings
        {
            get { return this._dashIsoGroupSettings; }
            set { this._dashIsoGroupSettings = value; }
        }

        // Check to see if DashIsoGroupSettings property is set
        internal bool IsSetDashIsoGroupSettings()
        {
            return this._dashIsoGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FileGroupSettings. Required when you set (Type) under (OutputGroups)>(OutputGroupSettings)
        /// to FILE_GROUP_SETTINGS.
        /// </summary>
        public FileGroupSettings FileGroupSettings
        {
            get { return this._fileGroupSettings; }
            set { this._fileGroupSettings = value; }
        }

        // Check to see if FileGroupSettings property is set
        internal bool IsSetFileGroupSettings()
        {
            return this._fileGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsGroupSettings. Required when you set (Type) under (OutputGroups)>(OutputGroupSettings)
        /// to HLS_GROUP_SETTINGS.
        /// </summary>
        public HlsGroupSettings HlsGroupSettings
        {
            get { return this._hlsGroupSettings; }
            set { this._hlsGroupSettings = value; }
        }

        // Check to see if HlsGroupSettings property is set
        internal bool IsSetHlsGroupSettings()
        {
            return this._hlsGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MsSmoothGroupSettings. Required when you set (Type) under
        /// (OutputGroups)>(OutputGroupSettings) to MS_SMOOTH_GROUP_SETTINGS.
        /// </summary>
        public MsSmoothGroupSettings MsSmoothGroupSettings
        {
            get { return this._msSmoothGroupSettings; }
            set { this._msSmoothGroupSettings = value; }
        }

        // Check to see if MsSmoothGroupSettings property is set
        internal bool IsSetMsSmoothGroupSettings()
        {
            return this._msSmoothGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Type. Type of output group (File group, Apple HLS, DASH
        /// ISO, Microsoft Smooth Streaming, CMAF)
        /// </summary>
        public OutputGroupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}