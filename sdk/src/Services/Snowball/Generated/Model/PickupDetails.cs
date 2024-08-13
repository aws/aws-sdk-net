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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
        private string _devicePickupId;
        private string _email;
        private DateTime? _identificationExpirationDate;
        private string _identificationIssuingOrg;
        private string _identificationNumber;
        private string _name;
        private string _phoneNumber;

        /// <summary>
        /// Gets and sets the property DevicePickupId. 
        /// <para>
        /// The unique ID for a device that will be picked up.
        /// </para>
        /// </summary>
        [AWSProperty(Min=40, Max=40)]
        public string DevicePickupId
        {
            get { return this._devicePickupId; }
            set { this._devicePickupId = value; }
        }

        // Check to see if DevicePickupId property is set
        internal bool IsSetDevicePickupId()
        {
            return this._devicePickupId != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=320)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property IdentificationExpirationDate. 
        /// <para>
        /// Expiration date of the credential identifying the person picking up the device.
        /// </para>
        /// </summary>
        public DateTime? IdentificationExpirationDate
        {
            get { return this._identificationExpirationDate; }
            set { this._identificationExpirationDate = value; }
        }

        // Check to see if IdentificationExpirationDate property is set
        internal bool IsSetIdentificationExpirationDate()
        {
            return this._identificationExpirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentificationIssuingOrg. 
        /// <para>
        /// Organization that issued the credential identifying the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string IdentificationIssuingOrg
        {
            get { return this._identificationIssuingOrg; }
            set { this._identificationIssuingOrg = value; }
        }

        // Check to see if IdentificationIssuingOrg property is set
        internal bool IsSetIdentificationIssuingOrg()
        {
            return this._identificationIssuingOrg != null;
        }

        /// <summary>
        /// Gets and sets the property IdentificationNumber. 
        /// <para>
        /// The number on the credential identifying the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string IdentificationNumber
        {
            get { return this._identificationNumber; }
            set { this._identificationNumber = value; }
        }

        // Check to see if IdentificationNumber property is set
        internal bool IsSetIdentificationNumber()
        {
            return this._identificationNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number of the person picking up the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=7, Max=30)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

    }
}