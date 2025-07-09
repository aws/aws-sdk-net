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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an MFA device.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListMFADevices.html">ListMFADevices</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class MFADevice
    {
        private DateTime? _enableDate;
        private string _serialNumber;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public MFADevice() { }

        /// <summary>
        /// Instantiates MFADevice with the parameterized properties
        /// </summary>
        /// <param name="userName">The user with whom the MFA device is associated.</param>
        /// <param name="serialNumber">The serial number that uniquely identifies the MFA device. For virtual MFA devices, the serial number is the device ARN.</param>
        /// <param name="enableDate">The date when the MFA device was enabled for the user.</param>
        public MFADevice(string userName, string serialNumber, DateTime? enableDate)
        {
            _userName = userName;
            _serialNumber = serialNumber;
            _enableDate = enableDate;
        }

        /// <summary>
        /// Gets and sets the property EnableDate. 
        /// <para>
        /// The date when the MFA device was enabled for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EnableDate
        {
            get { return this._enableDate; }
            set { this._enableDate = value; }
        }

        // Check to see if EnableDate property is set
        internal bool IsSetEnableDate()
        {
            return this._enableDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number that uniquely identifies the MFA device. For virtual MFA devices,
        /// the serial number is the device ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=9, Max=256)]
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user with whom the MFA device is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}