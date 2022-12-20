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
    /// Container for the parameters to the GetLaunchProfileInitialization operation.
    /// Get a launch profile initialization.
    /// </summary>
    public partial class GetLaunchProfileInitializationRequest : AmazonNimbleStudioRequest
    {
        private string _launchProfileId;
        private List<string> _launchProfileProtocolVersions = new List<string>();
        private string _launchPurpose;
        private string _platform;
        private string _studioId;

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
        /// The launch profile protocol versions supported by the client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LaunchPurpose. 
        /// <para>
        /// The launch purpose.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LaunchPurpose
        {
            get { return this._launchPurpose; }
            set { this._launchPurpose = value; }
        }

        // Check to see if LaunchPurpose property is set
        internal bool IsSetLaunchPurpose()
        {
            return this._launchPurpose != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform where this Launch Profile will be used, either Windows or Linux.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
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