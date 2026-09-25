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

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Container for the parameters to the GetEndpoint operation. Gets information about
    /// an Device Advisor endpoint.
    /// </summary>
    public partial class GetEndpointRequest : AmazonIoTDeviceAdvisorRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// The authentication method used during the device connection.
        /// </para>
        /// </summary>
        public AuthenticationMethod AuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethod() => this.AuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The certificate ARN of the device. This is an optional parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property DeviceRoleArn. 
        /// <para>
        /// The device role ARN of the device. This is an optional parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DeviceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceRoleArn property is set.
        /// </summary>
        internal bool IsSetDeviceRoleArn() => this.DeviceRoleArn != null;

        /// <summary>
        /// Gets and sets the property ThingArn. 
        /// <para>
        /// The thing ARN of the device. This is an optional parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ThingArn { get; set; }

        /// <summary>
        /// Checks to see if the ThingArn property is set.
        /// </summary>
        internal bool IsSetThingArn() => this.ThingArn != null;
    }
}
