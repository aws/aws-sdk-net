/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteVirtualMFADevice operation.
    /// Deletes a virtual MFA device.
    /// 
    ///         <note>You must deactivate a user's virtual MFA device before you can delete it.
    /// For information            about deactivating MFA devices, see <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_DeactivateMFADevice.html">DeactivateMFADevice</a>.</note>
    /// </summary>
    public partial class DeleteVirtualMFADeviceRequest : AmazonIdentityManagementServiceRequest
    {
        private string _serialNumber;


        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number that uniquely identifies the MFA device. For virtual MFA devices,
        /// the            serial number is the same as the ARN.
        /// </para>
        /// </summary>
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

    }
}