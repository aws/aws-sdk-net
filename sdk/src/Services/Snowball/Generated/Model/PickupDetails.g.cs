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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Information identifying the person picking up the device.
    /// </summary>
    public partial class PickupDetails
    {
        /// <summary>
        /// Gets and sets the property DevicePickupId. 
        /// <para>
        /// The unique ID for a device that will be picked up.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string DevicePickupId { get; set; }

        /// <summary>
        /// Checks to see if the DevicePickupId property is set.
        /// </summary>
        internal bool IsSetDevicePickupId() => this.DevicePickupId != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 320)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property IdentificationExpirationDate. 
        /// <para>
        /// Expiration date of the credential identifying the person picking up the device.
        /// </para>
        /// </summary>
        public DateTime? IdentificationExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the IdentificationExpirationDate property is set.
        /// </summary>
        internal bool IsSetIdentificationExpirationDate() => this.IdentificationExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property IdentificationIssuingOrg. 
        /// <para>
        /// Organization that issued the credential identifying the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string IdentificationIssuingOrg { get; set; }

        /// <summary>
        /// Checks to see if the IdentificationIssuingOrg property is set.
        /// </summary>
        internal bool IsSetIdentificationIssuingOrg() => this.IdentificationIssuingOrg != null;

        /// <summary>
        /// Gets and sets the property IdentificationNumber. 
        /// <para>
        /// The number on the credential identifying the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Checks to see if the IdentificationNumber property is set.
        /// </summary>
        internal bool IsSetIdentificationNumber() => this.IdentificationNumber != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number of the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 7, Max = 30)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;
    }
}
