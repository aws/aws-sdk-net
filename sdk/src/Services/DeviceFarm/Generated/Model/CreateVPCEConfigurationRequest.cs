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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
    /// Container for the parameters to the CreateVPCEConfiguration operation.
    /// Creates a configuration record in Device Farm for your Amazon Virtual Private Cloud
    /// (VPC) endpoint.
    /// </summary>
    public partial class CreateVPCEConfigurationRequest : AmazonDeviceFarmRequest
    {
        private string _serviceDnsName;
        private string _vpceConfigurationDescription;
        private string _vpceConfigurationName;
        private string _vpceServiceName;

        /// <summary>
        /// Gets and sets the property ServiceDnsName. 
        /// <para>
        /// The DNS name of the service running in your VPC that you want Device Farm to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ServiceDnsName
        {
            get { return this._serviceDnsName; }
            set { this._serviceDnsName = value; }
        }

        // Check to see if ServiceDnsName property is set
        internal bool IsSetServiceDnsName()
        {
            return this._serviceDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property VpceConfigurationDescription. 
        /// <para>
        /// An optional description that provides details about your VPC endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string VpceConfigurationDescription
        {
            get { return this._vpceConfigurationDescription; }
            set { this._vpceConfigurationDescription = value; }
        }

        // Check to see if VpceConfigurationDescription property is set
        internal bool IsSetVpceConfigurationDescription()
        {
            return this._vpceConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property VpceConfigurationName. 
        /// <para>
        /// The friendly name you give to your VPC endpoint configuration, to manage your configurations
        /// more easily.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string VpceConfigurationName
        {
            get { return this._vpceConfigurationName; }
            set { this._vpceConfigurationName = value; }
        }

        // Check to see if VpceConfigurationName property is set
        internal bool IsSetVpceConfigurationName()
        {
            return this._vpceConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property VpceServiceName. 
        /// <para>
        /// The name of the VPC endpoint service running in your AWS account that you want Device
        /// Farm to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string VpceServiceName
        {
            get { return this._vpceServiceName; }
            set { this._vpceServiceName = value; }
        }

        // Check to see if VpceServiceName property is set
        internal bool IsSetVpceServiceName()
        {
            return this._vpceServiceName != null;
        }

    }
}