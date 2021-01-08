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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for OutputDestination
    /// </summary>
    public partial class OutputDestination
    {
        private string _id;
        private List<MediaPackageOutputDestinationSettings> _mediaPackageSettings = new List<MediaPackageOutputDestinationSettings>();
        private MultiplexProgramChannelDestinationSettings _multiplexSettings;
        private List<OutputDestinationSettings> _settings = new List<OutputDestinationSettings>();

        /// <summary>
        /// Gets and sets the property Id. User-specified id. This is used in an output group
        /// or an output.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MediaPackageSettings. Destination settings for a MediaPackage
        /// output; one destination for both encoders.
        /// </summary>
        public List<MediaPackageOutputDestinationSettings> MediaPackageSettings
        {
            get { return this._mediaPackageSettings; }
            set { this._mediaPackageSettings = value; }
        }

        // Check to see if MediaPackageSettings property is set
        internal bool IsSetMediaPackageSettings()
        {
            return this._mediaPackageSettings != null && this._mediaPackageSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MultiplexSettings. Destination settings for a Multiplex
        /// output; one destination for both encoders.
        /// </summary>
        public MultiplexProgramChannelDestinationSettings MultiplexSettings
        {
            get { return this._multiplexSettings; }
            set { this._multiplexSettings = value; }
        }

        // Check to see if MultiplexSettings property is set
        internal bool IsSetMultiplexSettings()
        {
            return this._multiplexSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. Destination settings for a standard output; one
        /// destination for each redundant encoder.
        /// </summary>
        public List<OutputDestinationSettings> Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null && this._settings.Count > 0; 
        }

    }
}