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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Hls Cdn Settings
    /// </summary>
    public partial class HlsCdnSettings
    {
        /// <summary>
        /// Gets and sets the property HlsAkamaiSettings.
        /// </summary>
        public HlsAkamaiSettings HlsAkamaiSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsAkamaiSettings property is set.
        /// </summary>
        internal bool IsSetHlsAkamaiSettings() => this.HlsAkamaiSettings != null;

        /// <summary>
        /// Gets and sets the property HlsBasicPutSettings.
        /// </summary>
        public HlsBasicPutSettings HlsBasicPutSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsBasicPutSettings property is set.
        /// </summary>
        internal bool IsSetHlsBasicPutSettings() => this.HlsBasicPutSettings != null;

        /// <summary>
        /// Gets and sets the property HlsMediaStoreSettings.
        /// </summary>
        public HlsMediaStoreSettings HlsMediaStoreSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsMediaStoreSettings property is set.
        /// </summary>
        internal bool IsSetHlsMediaStoreSettings() => this.HlsMediaStoreSettings != null;

        /// <summary>
        /// Gets and sets the property HlsS3Settings.
        /// </summary>
        public HlsS3Settings HlsS3Settings { get; set; }

        /// <summary>
        /// Checks to see if the HlsS3Settings property is set.
        /// </summary>
        internal bool IsSetHlsS3Settings() => this.HlsS3Settings != null;

        /// <summary>
        /// Gets and sets the property HlsWebdavSettings.
        /// </summary>
        public HlsWebdavSettings HlsWebdavSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsWebdavSettings property is set.
        /// </summary>
        internal bool IsSetHlsWebdavSettings() => this.HlsWebdavSettings != null;
    }
}
