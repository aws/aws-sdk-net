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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLaunchProfile operation.
    /// Update a launch profile.
    /// </summary>
    public partial class UpdateLaunchProfileRequest : AmazonNimbleStudioRequest
    {
        private string _clientToken;
        private string _description;
        private string _launchProfileId;
        private List<string> _launchProfileProtocolVersions = new List<string>();
        private string _name;
        private StreamConfigurationCreate _streamConfiguration;
        private List<string> _studioComponentIds = new List<string>();
        private string _studioId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If you don’t specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileId. 
        /// <para>
        /// The ID of the launch profile used to control access from the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LaunchProfileId
        {
            get { return this._launchProfileId; }
            set { this._launchProfileId = value; }
        }

        // Check to see if LaunchProfileId property is set
        internal bool IsSetLaunchProfileId()
        {
            return this._launchProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileProtocolVersions. 
        /// <para>
        /// The version number of the protocol that is used by the launch profile. The only valid
        /// version is "2021-03-31".
        /// </para>
        /// </summary>
        public List<string> LaunchProfileProtocolVersions
        {
            get { return this._launchProfileProtocolVersions; }
            set { this._launchProfileProtocolVersions = value; }
        }

        // Check to see if LaunchProfileProtocolVersions property is set
        internal bool IsSetLaunchProfileProtocolVersions()
        {
            return this._launchProfileProtocolVersions != null && this._launchProfileProtocolVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StreamConfiguration. 
        /// <para>
        /// A configuration for a streaming session.
        /// </para>
        /// </summary>
        public StreamConfigurationCreate StreamConfiguration
        {
            get { return this._streamConfiguration; }
            set { this._streamConfiguration = value; }
        }

        // Check to see if StreamConfiguration property is set
        internal bool IsSetStreamConfiguration()
        {
            return this._streamConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StudioComponentIds. 
        /// <para>
        /// Unique identifiers for a collection of studio components that can be used with this
        /// launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> StudioComponentIds
        {
            get { return this._studioComponentIds; }
            set { this._studioComponentIds = value; }
        }

        // Check to see if StudioComponentIds property is set
        internal bool IsSetStudioComponentIds()
        {
            return this._studioComponentIds != null && this._studioComponentIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The studio ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

    }
}