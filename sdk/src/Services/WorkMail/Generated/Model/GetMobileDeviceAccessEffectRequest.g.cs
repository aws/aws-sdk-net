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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the GetMobileDeviceAccessEffect operation. Simulates
    /// the effect of the mobile device access rules for the given attributes of a sample
    /// access event. Use this method to test the effects of the current set of mobile device
    /// access rules for the WorkMail organization for a particular user's attributes.
    /// </summary>
    public partial class GetMobileDeviceAccessEffectRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property DeviceModel. 
        /// <para>
        /// Device model the simulated user will report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Checks to see if the DeviceModel property is set.
        /// </summary>
        internal bool IsSetDeviceModel() => this.DeviceModel != null;

        /// <summary>
        /// Gets and sets the property DeviceOperatingSystem. 
        /// <para>
        /// Device operating system the simulated user will report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DeviceOperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the DeviceOperatingSystem property is set.
        /// </summary>
        internal bool IsSetDeviceOperatingSystem() => this.DeviceOperatingSystem != null;

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// Device type the simulated user will report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceType property is set.
        /// </summary>
        internal bool IsSetDeviceType() => this.DeviceType != null;

        /// <summary>
        /// Gets and sets the property DeviceUserAgent. 
        /// <para>
        /// Device user agent the simulated user will report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DeviceUserAgent { get; set; }

        /// <summary>
        /// Checks to see if the DeviceUserAgent property is set.
        /// </summary>
        internal bool IsSetDeviceUserAgent() => this.DeviceUserAgent != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The WorkMail organization to simulate the access effect for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;
    }
}
