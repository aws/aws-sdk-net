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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container specific settings.
    /// </summary>
    public partial class ContainerSettings
    {
        private ContainerType _container;
        private F4vSettings _f4vSettings;
        private M2tsSettings _m2tsSettings;
        private M3u8Settings _m3u8Settings;
        private MovSettings _movSettings;
        private Mp4Settings _mp4Settings;

        /// <summary>
        /// Gets and sets the property Container.
        /// </summary>
        public ContainerType Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property F4vSettings.
        /// </summary>
        public F4vSettings F4vSettings
        {
            get { return this._f4vSettings; }
            set { this._f4vSettings = value; }
        }

        // Check to see if F4vSettings property is set
        internal bool IsSetF4vSettings()
        {
            return this._f4vSettings != null;
        }

        /// <summary>
        /// Gets and sets the property M2tsSettings.
        /// </summary>
        public M2tsSettings M2tsSettings
        {
            get { return this._m2tsSettings; }
            set { this._m2tsSettings = value; }
        }

        // Check to see if M2tsSettings property is set
        internal bool IsSetM2tsSettings()
        {
            return this._m2tsSettings != null;
        }

        /// <summary>
        /// Gets and sets the property M3u8Settings.
        /// </summary>
        public M3u8Settings M3u8Settings
        {
            get { return this._m3u8Settings; }
            set { this._m3u8Settings = value; }
        }

        // Check to see if M3u8Settings property is set
        internal bool IsSetM3u8Settings()
        {
            return this._m3u8Settings != null;
        }

        /// <summary>
        /// Gets and sets the property MovSettings.
        /// </summary>
        public MovSettings MovSettings
        {
            get { return this._movSettings; }
            set { this._movSettings = value; }
        }

        // Check to see if MovSettings property is set
        internal bool IsSetMovSettings()
        {
            return this._movSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Mp4Settings.
        /// </summary>
        public Mp4Settings Mp4Settings
        {
            get { return this._mp4Settings; }
            set { this._mp4Settings = value; }
        }

        // Check to see if Mp4Settings property is set
        internal bool IsSetMp4Settings()
        {
            return this._mp4Settings != null;
        }

    }
}