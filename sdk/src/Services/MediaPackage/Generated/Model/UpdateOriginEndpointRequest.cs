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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOriginEndpoint operation.
    /// Updates an existing OriginEndpoint.
    /// </summary>
    public partial class UpdateOriginEndpointRequest : AmazonMediaPackageRequest
    {
        private Authorization _authorization;
        private CmafPackageCreateOrUpdateParameters _cmafPackage;
        private DashPackage _dashPackage;
        private string _description;
        private HlsPackage _hlsPackage;
        private string _id;
        private string _manifestName;
        private MssPackage _mssPackage;
        private Origination _origination;
        private int? _startoverWindowSeconds;
        private int? _timeDelaySeconds;
        private List<string> _whitelist = new List<string>();

        /// <summary>
        /// Gets and sets the property Authorization.
        /// </summary>
        public Authorization Authorization
        {
            get { return this._authorization; }
            set { this._authorization = value; }
        }

        // Check to see if Authorization property is set
        internal bool IsSetAuthorization()
        {
            return this._authorization != null;
        }

        /// <summary>
        /// Gets and sets the property CmafPackage.
        /// </summary>
        public CmafPackageCreateOrUpdateParameters CmafPackage
        {
            get { return this._cmafPackage; }
            set { this._cmafPackage = value; }
        }

        // Check to see if CmafPackage property is set
        internal bool IsSetCmafPackage()
        {
            return this._cmafPackage != null;
        }

        /// <summary>
        /// Gets and sets the property DashPackage.
        /// </summary>
        public DashPackage DashPackage
        {
            get { return this._dashPackage; }
            set { this._dashPackage = value; }
        }

        // Check to see if DashPackage property is set
        internal bool IsSetDashPackage()
        {
            return this._dashPackage != null;
        }

        /// <summary>
        /// Gets and sets the property Description. A short text description of the OriginEndpoint.
        /// </summary>
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
        /// Gets and sets the property HlsPackage.
        /// </summary>
        public HlsPackage HlsPackage
        {
            get { return this._hlsPackage; }
            set { this._hlsPackage = value; }
        }

        // Check to see if HlsPackage property is set
        internal bool IsSetHlsPackage()
        {
            return this._hlsPackage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the OriginEndpoint to update.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ManifestName. A short string that will be appended to the
        /// end of the Endpoint URL.
        /// </summary>
        public string ManifestName
        {
            get { return this._manifestName; }
            set { this._manifestName = value; }
        }

        // Check to see if ManifestName property is set
        internal bool IsSetManifestName()
        {
            return this._manifestName != null;
        }

        /// <summary>
        /// Gets and sets the property MssPackage.
        /// </summary>
        public MssPackage MssPackage
        {
            get { return this._mssPackage; }
            set { this._mssPackage = value; }
        }

        // Check to see if MssPackage property is set
        internal bool IsSetMssPackage()
        {
            return this._mssPackage != null;
        }

        /// <summary>
        /// Gets and sets the property Origination. Control whether origination of video is allowed
        /// for this OriginEndpoint. If set to ALLOW, the OriginEndpointmay by requested, pursuant
        /// to any other form of access control. If set to DENY, the OriginEndpoint may not berequested.
        /// This can be helpful for Live to VOD harvesting, or for temporarily disabling origination
        /// </summary>
        public Origination Origination
        {
            get { return this._origination; }
            set { this._origination = value; }
        }

        // Check to see if Origination property is set
        internal bool IsSetOrigination()
        {
            return this._origination != null;
        }

        /// <summary>
        /// Gets and sets the property StartoverWindowSeconds. Maximum duration (in seconds) of
        /// content to retain for startover playback.If not specified, startover playback will
        /// be disabled for the OriginEndpoint.
        /// </summary>
        public int StartoverWindowSeconds
        {
            get { return this._startoverWindowSeconds.GetValueOrDefault(); }
            set { this._startoverWindowSeconds = value; }
        }

        // Check to see if StartoverWindowSeconds property is set
        internal bool IsSetStartoverWindowSeconds()
        {
            return this._startoverWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeDelaySeconds. Amount of delay (in seconds) to enforce
        /// on the playback of live content.If not specified, there will be no time delay in effect
        /// for the OriginEndpoint.
        /// </summary>
        public int TimeDelaySeconds
        {
            get { return this._timeDelaySeconds.GetValueOrDefault(); }
            set { this._timeDelaySeconds = value; }
        }

        // Check to see if TimeDelaySeconds property is set
        internal bool IsSetTimeDelaySeconds()
        {
            return this._timeDelaySeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Whitelist. A list of source IP CIDR blocks that will be
        /// allowed to access the OriginEndpoint.
        /// </summary>
        public List<string> Whitelist
        {
            get { return this._whitelist; }
            set { this._whitelist = value; }
        }

        // Check to see if Whitelist property is set
        internal bool IsSetWhitelist()
        {
            return this._whitelist != null && this._whitelist.Count > 0; 
        }

    }
}