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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ExportVerifiedAccessInstanceClientConfiguration operation.
    /// </summary>
    public partial class ExportVerifiedAccessInstanceClientConfigurationResponse : AmazonWebServiceResponse
    {
        private List<string> _deviceTrustProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<VerifiedAccessInstanceOpenVpnClientConfiguration> _openVpnConfigurations = AWSConfigs.InitializeCollections ? new List<VerifiedAccessInstanceOpenVpnClientConfiguration>() : null;
        private string _region;
        private VerifiedAccessInstanceUserTrustProviderClientConfiguration _userTrustProvider;
        private string _verifiedAccessInstanceId;
        private string _version;

        /// <summary>
        /// Gets and sets the property DeviceTrustProviders. 
        /// <para>
        /// The device trust providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeviceTrustProviders
        {
            get { return this._deviceTrustProviders; }
            set { this._deviceTrustProviders = value; }
        }

        // Check to see if DeviceTrustProviders property is set
        internal bool IsSetDeviceTrustProviders()
        {
            return this._deviceTrustProviders != null && (this._deviceTrustProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OpenVpnConfigurations. 
        /// <para>
        /// The Open VPN configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VerifiedAccessInstanceOpenVpnClientConfiguration> OpenVpnConfigurations
        {
            get { return this._openVpnConfigurations; }
            set { this._openVpnConfigurations = value; }
        }

        // Check to see if OpenVpnConfigurations property is set
        internal bool IsSetOpenVpnConfigurations()
        {
            return this._openVpnConfigurations != null && (this._openVpnConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property UserTrustProvider. 
        /// <para>
        /// The user identity trust provider.
        /// </para>
        /// </summary>
        public VerifiedAccessInstanceUserTrustProviderClientConfiguration UserTrustProvider
        {
            get { return this._userTrustProvider; }
            set { this._userTrustProvider = value; }
        }

        // Check to see if UserTrustProvider property is set
        internal bool IsSetUserTrustProvider()
        {
            return this._userTrustProvider != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstanceId. 
        /// <para>
        /// The ID of the Verified Access instance.
        /// </para>
        /// </summary>
        public string VerifiedAccessInstanceId
        {
            get { return this._verifiedAccessInstanceId; }
            set { this._verifiedAccessInstanceId = value; }
        }

        // Check to see if VerifiedAccessInstanceId property is set
        internal bool IsSetVerifiedAccessInstanceId()
        {
            return this._verifiedAccessInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}