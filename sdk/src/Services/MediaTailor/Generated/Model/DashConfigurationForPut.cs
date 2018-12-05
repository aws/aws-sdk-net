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
    /// The configuration object for DASH content.
    /// </summary>
    public partial class DashConfigurationForPut
    {
        private string _mpdLocation;

        /// <summary>
        /// Gets and sets the property MpdLocation. 
        /// <para>
        /// The setting that controls whether MediaTailor includes the Location tag in DASH Manifests.
        /// MediaTailor populates the Location tag with the URL for manifest update requests,
        /// to be used by players that don't support sticky redirects. Disable this if you have
        /// CDN routing rules set up for accessing MediaTailor manifests and you are either using
        /// client-side reporting or your players support sticky HTTP redirects. Valid values
        /// are DISABLED and EMT_DEFAULT. The EMT_DEFAULT setting enables the inclusion of the
        /// tag and is the default value.
        /// </para>
        /// </summary>
        public string MpdLocation
        {
            get { return this._mpdLocation; }
            set { this._mpdLocation = value; }
        }

        // Check to see if MpdLocation property is set
        internal bool IsSetMpdLocation()
        {
            return this._mpdLocation != null;
        }

    }
}