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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Panorama.Model
{
    /// <summary>
    /// An over-the-air update (OTA) job configuration.
    /// </summary>
    public partial class OTAJobConfig
    {
        private bool? _allowMajorVersionUpdate;
        private string _imageVersion;

        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpdate. 
        /// <para>
        /// Whether to apply the update if it is a major version change.
        /// </para>
        /// </summary>
        public bool AllowMajorVersionUpdate
        {
            get { return this._allowMajorVersionUpdate.GetValueOrDefault(); }
            set { this._allowMajorVersionUpdate = value; }
        }

        // Check to see if AllowMajorVersionUpdate property is set
        internal bool IsSetAllowMajorVersionUpdate()
        {
            return this._allowMajorVersionUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The target version of the device software.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ImageVersion
        {
            get { return this._imageVersion; }
            set { this._imageVersion = value; }
        }

        // Check to see if ImageVersion property is set
        internal bool IsSetImageVersion()
        {
            return this._imageVersion != null;
        }

    }
}