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
    /// Configures the settings for SRT inputs. Provide either srtCallerSources (for SRT_CALLER
    /// type) OR srtListenerSettings (for SRT_LISTENER type), not both.
    /// </summary>
    public partial class SrtSettingsRequest
    {
        private List<SrtCallerSourceRequest> _srtCallerSources = AWSConfigs.InitializeCollections ? new List<SrtCallerSourceRequest>() : null;
        private SrtListenerSettingsRequest _srtListenerSettings;

        /// <summary>
        /// Gets and sets the property SrtCallerSources.
        /// </summary>
        public List<SrtCallerSourceRequest> SrtCallerSources
        {
            get { return this._srtCallerSources; }
            set { this._srtCallerSources = value; }
        }

        // Check to see if SrtCallerSources property is set
        internal bool IsSetSrtCallerSources()
        {
            return this._srtCallerSources != null && (this._srtCallerSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SrtListenerSettings.
        /// </summary>
        public SrtListenerSettingsRequest SrtListenerSettings
        {
            get { return this._srtListenerSettings; }
            set { this._srtListenerSettings = value; }
        }

        // Check to see if SrtListenerSettings property is set
        internal bool IsSetSrtListenerSettings()
        {
            return this._srtListenerSettings != null;
        }

    }
}