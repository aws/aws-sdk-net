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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Hls Cdn Settings
    /// </summary>
    public partial class HlsCdnSettings
    {
        private HlsAkamaiSettings _hlsAkamaiSettings;
        private HlsBasicPutSettings _hlsBasicPutSettings;
        private HlsMediaStoreSettings _hlsMediaStoreSettings;
        private HlsS3Settings _hlsS3Settings;
        private HlsWebdavSettings _hlsWebdavSettings;

        /// <summary>
        /// Gets and sets the property HlsAkamaiSettings.
        /// </summary>
        public HlsAkamaiSettings HlsAkamaiSettings
        {
            get { return this._hlsAkamaiSettings; }
            set { this._hlsAkamaiSettings = value; }
        }

        // Check to see if HlsAkamaiSettings property is set
        internal bool IsSetHlsAkamaiSettings()
        {
            return this._hlsAkamaiSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsBasicPutSettings.
        /// </summary>
        public HlsBasicPutSettings HlsBasicPutSettings
        {
            get { return this._hlsBasicPutSettings; }
            set { this._hlsBasicPutSettings = value; }
        }

        // Check to see if HlsBasicPutSettings property is set
        internal bool IsSetHlsBasicPutSettings()
        {
            return this._hlsBasicPutSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsMediaStoreSettings.
        /// </summary>
        public HlsMediaStoreSettings HlsMediaStoreSettings
        {
            get { return this._hlsMediaStoreSettings; }
            set { this._hlsMediaStoreSettings = value; }
        }

        // Check to see if HlsMediaStoreSettings property is set
        internal bool IsSetHlsMediaStoreSettings()
        {
            return this._hlsMediaStoreSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsS3Settings.
        /// </summary>
        public HlsS3Settings HlsS3Settings
        {
            get { return this._hlsS3Settings; }
            set { this._hlsS3Settings = value; }
        }

        // Check to see if HlsS3Settings property is set
        internal bool IsSetHlsS3Settings()
        {
            return this._hlsS3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsWebdavSettings.
        /// </summary>
        public HlsWebdavSettings HlsWebdavSettings
        {
            get { return this._hlsWebdavSettings; }
            set { this._hlsWebdavSettings = value; }
        }

        // Check to see if HlsWebdavSettings property is set
        internal bool IsSetHlsWebdavSettings()
        {
            return this._hlsWebdavSettings != null;
        }

    }
}