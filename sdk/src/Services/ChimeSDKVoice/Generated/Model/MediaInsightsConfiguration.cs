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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The configuration for a call analytics task.
    /// </summary>
    public partial class MediaInsightsConfiguration
    {
        private string _configurationArn;
        private bool? _disabled;

        /// <summary>
        /// Gets and sets the property ConfigurationArn. 
        /// <para>
        /// The configuration's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string ConfigurationArn
        {
            get { return this._configurationArn; }
            set { this._configurationArn = value; }
        }

        // Check to see if ConfigurationArn property is set
        internal bool IsSetConfigurationArn()
        {
            return this._configurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Denotes the configration as enabled or disabled.
        /// </para>
        /// </summary>
        public bool Disabled
        {
            get { return this._disabled.GetValueOrDefault(); }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

    }
}