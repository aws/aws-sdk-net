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
    /// Container for the parameters to the CreateVPCEConfiguration operation. Creates a configuration
    /// record in Device Farm for your Amazon Virtual Private Cloud (VPC) endpoint.
    /// </summary>
    public partial class CreateVPCEConfigurationRequest : AmazonDeviceFarmRequest
    {
        /// <summary>
        /// Gets and sets the property ServiceDnsName. 
        /// <para>
        /// The DNS name of the service running in your VPC that you want Device Farm to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ServiceDnsName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceDnsName property is set.
        /// </summary>
        internal bool IsSetServiceDnsName() => this.ServiceDnsName != null;

        /// <summary>
        /// Gets and sets the property VpceConfigurationDescription. 
        /// <para>
        /// An optional description that provides details about your VPC endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string VpceConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the VpceConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetVpceConfigurationDescription() => this.VpceConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property VpceConfigurationName. 
        /// <para>
        /// The friendly name you give to your VPC endpoint configuration, to manage your configurations
        /// more easily.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string VpceConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the VpceConfigurationName property is set.
        /// </summary>
        internal bool IsSetVpceConfigurationName() => this.VpceConfigurationName != null;

        /// <summary>
        /// Gets and sets the property VpceServiceName. 
        /// <para>
        /// The name of the VPC endpoint service running in your AWS account that you want Device
        /// Farm to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string VpceServiceName { get; set; }

        /// <summary>
        /// Checks to see if the VpceServiceName property is set.
        /// </summary>
        internal bool IsSetVpceServiceName() => this.VpceServiceName != null;
    }
}
