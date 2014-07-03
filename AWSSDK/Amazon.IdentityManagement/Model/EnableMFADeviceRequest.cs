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
    /// Container for the parameters to the EnableMFADevice operation.
    /// Enables the specified MFA device and associates it with the specified user name. When            enabled,
    /// the MFA device is required for every subsequent login by the user name associated            with
    /// the device.
    /// </summary>
    public partial class EnableMFADeviceRequest : AmazonWebServiceRequest
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


        /// <summary>
        /// Sets the AuthenticationCode1 property
        /// </summary>
        /// <param name="authenticationCode1">The value to set for the AuthenticationCode1 property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableMFADeviceRequest WithAuthenticationCode1(string authenticationCode1)
        {
            this._authenticationCode1 = authenticationCode1;
            return this;
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


        /// <summary>
        /// Sets the AuthenticationCode2 property
        /// </summary>
        /// <param name="authenticationCode2">The value to set for the AuthenticationCode2 property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableMFADeviceRequest WithAuthenticationCode2(string authenticationCode2)
        {
            this._authenticationCode2 = authenticationCode2;
            return this;
        }

        // Check to see if AuthenticationCode2 property is set
        internal bool IsSetAuthenticationCode2()
        {
            return this._authenticationCode2 != null;
        }


        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number that uniquely identifies the MFA device. For virtual MFA devices,
        /// the            serial number is the device ARN.
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }


        /// <summary>
        /// Sets the SerialNumber property
        /// </summary>
        /// <param name="serialNumber">The value to set for the SerialNumber property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableMFADeviceRequest WithSerialNumber(string serialNumber)
        {
            this._serialNumber = serialNumber;
            return this;
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }


        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user for whom you want to enable the MFA device.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }


        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableMFADeviceRequest WithUserName(string userName)
        {
            this._userName = userName;
            return this;
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}