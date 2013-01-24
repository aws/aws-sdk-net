/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ResyncMFADevice operation.
    /// <para>Synchronizes the specified MFA device with AWS servers.</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ResyncMFADevice"/>
    public class ResyncMFADeviceRequest : AmazonWebServiceRequest
    {
        private string userName;
        private string serialNumber;
        private string authenticationCode1;
        private string authenticationCode2;

        /// <summary>
        /// Name of the user whose MFA device you want to resynchronize.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        public ResyncMFADeviceRequest WithUserName(string userName)
        {
            this.userName = userName;
            return this;
        }
            

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;       
        }

        /// <summary>
        /// Serial number that uniquely identifies the MFA device.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>9 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=/:,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this.serialNumber; }
            set { this.serialNumber = value; }
        }

        /// <summary>
        /// Sets the SerialNumber property
        /// </summary>
        /// <param name="serialNumber">The value to set for the SerialNumber property </param>
        /// <returns>this instance</returns>
        public ResyncMFADeviceRequest WithSerialNumber(string serialNumber)
        {
            this.serialNumber = serialNumber;
            return this;
        }
            

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this.serialNumber != null;       
        }

        /// <summary>
        /// An authentication code emitted by the device.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>6 - 6</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\d]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AuthenticationCode1
        {
            get { return this.authenticationCode1; }
            set { this.authenticationCode1 = value; }
        }

        /// <summary>
        /// Sets the AuthenticationCode1 property
        /// </summary>
        /// <param name="authenticationCode1">The value to set for the AuthenticationCode1 property </param>
        /// <returns>this instance</returns>
        public ResyncMFADeviceRequest WithAuthenticationCode1(string authenticationCode1)
        {
            this.authenticationCode1 = authenticationCode1;
            return this;
        }
            

        // Check to see if AuthenticationCode1 property is set
        internal bool IsSetAuthenticationCode1()
        {
            return this.authenticationCode1 != null;       
        }

        /// <summary>
        /// A subsequent authentication code emitted by the device.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>6 - 6</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\d]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AuthenticationCode2
        {
            get { return this.authenticationCode2; }
            set { this.authenticationCode2 = value; }
        }

        /// <summary>
        /// Sets the AuthenticationCode2 property
        /// </summary>
        /// <param name="authenticationCode2">The value to set for the AuthenticationCode2 property </param>
        /// <returns>this instance</returns>
        public ResyncMFADeviceRequest WithAuthenticationCode2(string authenticationCode2)
        {
            this.authenticationCode2 = authenticationCode2;
            return this;
        }
            

        // Check to see if AuthenticationCode2 property is set
        internal bool IsSetAuthenticationCode2()
        {
            return this.authenticationCode2 != null;       
        }
    }
}
    
