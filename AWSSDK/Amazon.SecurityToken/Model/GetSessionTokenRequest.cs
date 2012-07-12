/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the GetSessionToken operation.
    /// <para>The GetSessionToken action returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an Access
    /// Key ID, a Secret Access Key, and a security token. These credentials are valid for the specified duration only. The session duration for IAM
    /// users can be between one and 36 hours, with a default of 12 hours. The session duration for AWS account owners is restricted to one hour.
    /// Providing the MFA device serial number and the token code is optional.</para> <para>For more information about using GetSessionToken to
    /// create temporary credentials, go to Creating Temporary Credentials to Enable Access for IAM Users in <i>Using IAM</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetSessionToken"/>
    public class GetSessionTokenRequest : AmazonWebServiceRequest
    {
        private int? durationSeconds;
        private string serialNumber;
        private string tokenCode;

        /// <summary>
        /// The duration, in seconds, that the credentials should remain valid. Acceptable durations for IAM user sessions range from 3600s (one hour)
        /// to 129600s (36 hours), with 43200s (12 hours) as the default. Sessions for AWS account owners are restricted to a maximum of 3600s (one
        /// hour).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>3600 - 129600</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int DurationSeconds
        {
            get { return this.durationSeconds ?? default(int); }
            set { this.durationSeconds = value; }
        }

        /// <summary>
        /// Sets the DurationSeconds property
        /// </summary>
        /// <param name="durationSeconds">The value to set for the DurationSeconds property </param>
        /// <returns>this instance</returns>
        public GetSessionTokenRequest WithDurationSeconds(int durationSeconds)
        {
            this.durationSeconds = durationSeconds;
            return this;
        }

        /// <summary>
        /// Check to see if DurationSeconds property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        internal bool IsSetDurationSeconds()
        {
            return this.durationSeconds.HasValue;       
        }

        /// <summary>
        /// Gets and sets the identification number of the MFA device for the user. 
        /// </summary>
        /// <remarks>
        /// If the IAM user has a policy requiring MFA authentication (or is in a group requiring MFA authentication) 
        /// to access resources, provide the device value here.
        /// 
        /// The value is in the Security Credentials tab of the user's details pane in the IAM console. If the IAM user has an 
        /// active MFA device, the details pane displays a Multi-Factor Authentication Device value. The value is either for a 
        /// virtual device, such as arn:aws:iam::123456789012:mfa/user, or it is the device serial number for a hardware device 
        /// (usually the number from the back of the device), such as GAHT12345678.
        /// 
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>9 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </remarks>
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
        public GetSessionTokenRequest WithSerialNumber(string serialNumber)
        {
            this.serialNumber = serialNumber;
            return this;
        }
            
        /// <summary>
        /// Check to see if SerialNumber property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        internal bool IsSetSerialNumber()
        {
            return this.serialNumber != null;       
        }

        /// <summary>
        /// Gets and sets the value provided by the MFA device.
        /// </summary>
        /// <remarks>
        /// If the user has an access policy requiring an MFA code (or is in a group requiring an MFA code), provide the 
        /// value here to get permission to resources as specified in the access policy. If MFA authentication is required, 
        /// and the user does not provide a code when requesting a set of temporary security credentials, the user will receive 
        /// an "access denied" response when requesting resources that require MFA authentication.
        /// 
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>6 - 6</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </remarks>
        public string TokenCode
        {
            get { return this.tokenCode; }
            set { this.tokenCode = value; }
        }

        /// <summary>
        /// Sets the TokenCode property
        /// </summary>
        /// <param name="tokenCode">The value to set for the TokenCode property </param>
        /// <returns>this instance</returns>
        public GetSessionTokenRequest WithTokenCode(string tokenCode)
        {
            this.tokenCode = tokenCode;
            return this;
        }
            
        /// <summary>
        /// Check to see if TokenCode property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        internal bool IsSetTokenCode()
        {
            return this.tokenCode != null;       
        }
    }
}
    
