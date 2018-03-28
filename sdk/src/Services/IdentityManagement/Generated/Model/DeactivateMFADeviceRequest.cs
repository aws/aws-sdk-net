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

/*
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    /// Container for the parameters to the DeactivateMFADevice operation.
    /// Deactivates the specified MFA device and removes it from association with the user
    /// name for which it was originally enabled.
    /// 
    ///  
    /// <para>
    /// For more information about creating and working with virtual MFA devices, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
    /// a Virtual MFA Device</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeactivateMFADeviceRequest : AmazonIdentityManagementServiceRequest
    {
        private string _serialNumber;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeactivateMFADeviceRequest() { }

        /// <summary>
        /// Instantiates DeactivateMFADeviceRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user whose MFA device you want to deactivate. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="serialNumber">The serial number that uniquely identifies the MFA device. For virtual MFA devices, the serial number is the device ARN. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: =,.@:/-</param>
        public DeactivateMFADeviceRequest(string userName, string serialNumber)
        {
            _userName = userName;
            _serialNumber = serialNumber;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number that uniquely identifies the MFA device. For virtual MFA devices,
        /// the serial number is the device ARN.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: =,.@:/-
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

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user whose MFA device you want to deactivate.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
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