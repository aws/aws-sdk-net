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
    /// Container for the parameters to the GetMobileDeviceAccessOverride operation. Gets
    /// the mobile device access override for the given WorkMail organization, user, and device.
    /// </summary>
    public partial class GetMobileDeviceAccessOverrideRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The mobile device to which the override applies. <c>DeviceId</c> is case insensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The WorkMail organization to which you want to apply the override.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Identifies the WorkMail user for the override. Accepts the following types of user
        /// identities: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User ID: <c>12345678-1234-1234-1234-123456789012</c> or <c>S-1-1-12-1234567890-123456789-123456789-1234</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: <c>user@domain.tld</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name: <c>user</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
