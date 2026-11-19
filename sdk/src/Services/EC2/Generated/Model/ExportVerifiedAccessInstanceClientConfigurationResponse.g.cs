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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the ExportVerifiedAccessInstanceClientConfiguration
    /// operation.
    /// </summary>
    public partial class ExportVerifiedAccessInstanceClientConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeviceTrustProviders. 
        /// <para>
        /// The device trust providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeviceTrustProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DeviceTrustProviders property is set.
        /// </summary>
        internal bool IsSetDeviceTrustProviders() => this.DeviceTrustProviders != null && (this.DeviceTrustProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OpenVpnConfigurations. 
        /// <para>
        /// The Open VPN configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VerifiedAccessInstanceOpenVpnClientConfiguration> OpenVpnConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<VerifiedAccessInstanceOpenVpnClientConfiguration>() : null;

        /// <summary>
        /// Checks to see if the OpenVpnConfigurations property is set.
        /// </summary>
        internal bool IsSetOpenVpnConfigurations() => this.OpenVpnConfigurations != null && (this.OpenVpnConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property UserTrustProvider. 
        /// <para>
        /// The user identity trust provider.
        /// </para>
        /// </summary>
        public VerifiedAccessInstanceUserTrustProviderClientConfiguration UserTrustProvider { get; set; }

        /// <summary>
        /// Checks to see if the UserTrustProvider property is set.
        /// </summary>
        internal bool IsSetUserTrustProvider() => this.UserTrustProvider != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstanceId. 
        /// <para>
        /// The ID of the Verified Access instance.
        /// </para>
        /// </summary>
        public string VerifiedAccessInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessInstanceId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessInstanceId() => this.VerifiedAccessInstanceId != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
