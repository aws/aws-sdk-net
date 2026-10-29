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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Configuration settings for a remote access session, including billing method.
    /// </summary>
    public partial class CreateRemoteAccessSessionConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuxiliaryApps. 
        /// <para>
        /// A list of upload ARNs for app packages to be installed onto your device. (Maximum
        /// 3)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> AuxiliaryApps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuxiliaryApps property is set.
        /// </summary>
        internal bool IsSetAuxiliaryApps() => this.AuxiliaryApps != null && (this.AuxiliaryApps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingMethod. 
        /// <para>
        /// The billing method for the remote access session.
        /// </para>
        /// </summary>
        public BillingMethod BillingMethod { get; set; }

        /// <summary>
        /// Checks to see if the BillingMethod property is set.
        /// </summary>
        internal bool IsSetBillingMethod() => this.BillingMethod != null;

        /// <summary>
        /// Gets and sets the property DeviceProxy. 
        /// <para>
        /// The device proxy to be configured on the device for the remote access session.
        /// </para>
        /// </summary>
        public DeviceProxy DeviceProxy { get; set; }

        /// <summary>
        /// Checks to see if the DeviceProxy property is set.
        /// </summary>
        internal bool IsSetDeviceProxy() => this.DeviceProxy != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The name-value string pairs that specify additional settings for the remote access
        /// session.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>appium:version</c>: The major version of the Appium server to use for the session
        /// (for example, 2 or 3). The service may reject the selected version if it is not available
        /// for the selected device.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpceConfigurationArns. 
        /// <para>
        /// An array of ARNs included in the VPC endpoint configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpceConfigurationArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpceConfigurationArns property is set.
        /// </summary>
        internal bool IsSetVpceConfigurationArns() => this.VpceConfigurationArns != null && (this.VpceConfigurationArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
