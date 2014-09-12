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
    /// Container for the parameters to the ResyncMFADevice operation.
    /// Synchronizes the specified MFA device with AWS servers.
    /// </summary>
    public partial class ResyncMFADeviceRequest : AmazonIdentityManagementServiceRequest
    {
        private string _authenticationCode1;
        private string _authenticationCode2;
        private string _serialNumber;
        private string _userName;

        /// <summary>
        /// Gets and sets the property AuthenticationCode1. 
        /// <para>
        /// An authentication code emitted by the device.
        /// </para>
        /// </summary>
        public string AuthenticationCode1
        {
            get { return this._authenticationCode1; }
            set { this._authenticationCode1 = value; }
        }

        // Check to see if AuthenticationCode1 property is set
        internal bool IsSetAuthenticationCode1()
        {
            return this._authenticationCode1 != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationCode2. 
        /// <para>
        /// A subsequent authentication code emitted by the device.
        /// </para>
        /// </summary>
        public string AuthenticationCode2
        {
            get { return this._authenticationCode2; }
            set { this._authenticationCode2 = value; }
        }

        // Check to see if AuthenticationCode2 property is set
        internal bool IsSetAuthenticationCode2()
        {
            return this._authenticationCode2 != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// Serial number that uniquely identifies the MFA device.
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
        /// Name of the user whose MFA device you want to resynchronize.
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