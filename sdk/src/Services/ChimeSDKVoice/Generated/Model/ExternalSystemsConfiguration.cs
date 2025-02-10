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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Contains information about an external systems configuration for a Voice Connector.
    /// </summary>
    public partial class ExternalSystemsConfiguration
    {
        private List<string> _contactCenterSystemTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sessionBorderControllerTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ContactCenterSystemTypes. 
        /// <para>
        /// The contact center system.
        /// </para>
        /// </summary>
        public List<string> ContactCenterSystemTypes
        {
            get { return this._contactCenterSystemTypes; }
            set { this._contactCenterSystemTypes = value; }
        }

        // Check to see if ContactCenterSystemTypes property is set
        internal bool IsSetContactCenterSystemTypes()
        {
            return this._contactCenterSystemTypes != null && (this._contactCenterSystemTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionBorderControllerTypes. 
        /// <para>
        /// The session border controllers.
        /// </para>
        /// </summary>
        public List<string> SessionBorderControllerTypes
        {
            get { return this._sessionBorderControllerTypes; }
            set { this._sessionBorderControllerTypes = value; }
        }

        // Check to see if SessionBorderControllerTypes property is set
        internal bool IsSetSessionBorderControllerTypes()
        {
            return this._sessionBorderControllerTypes != null && (this._sessionBorderControllerTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}