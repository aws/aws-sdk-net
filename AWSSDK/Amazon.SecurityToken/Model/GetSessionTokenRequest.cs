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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the GetSessionToken operation.
    /// <para>The GetSessionToken action returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an Access
    /// Key ID, a Secret Access Key, and a security token. These credentials are valid for the specified duration only. The session duration for IAM
    /// users can be between 15 minutes and 36 hours, with a default of 12 hours. The session duration for AWS account owners is restricted to a
    /// maximum of one hour. Providing the AWS Multi-Factor Authentication (MFA) device serial number and the token code is optional.</para>
    /// <para>For more information about using GetSessionToken to create temporary credentials, go to Creating Temporary Credentials to Enable
    /// Access for IAM Users in <i>Using IAM</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetSessionToken"/>
    public class GetSessionTokenRequest : AmazonWebServiceRequest
    {
        private int? durationSeconds;
        private string serialNumber;
        private string tokenCode;

        /// <summary>
        /// The duration, in seconds, that the credentials should remain valid. Acceptable durations for IAM user sessions range from 900s (15 minutes)
        /// to 129600s (36 hours), with 43200s (12 hours) as the default. Sessions for AWS account owners are restricted to a maximum of 3600s (one
        /// hour). If the duration is longer than one hour, the session for AWS account owners defaults to one hour.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>900 - 129600</description>
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
            

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this.durationSeconds.HasValue;       
        }

        /// <summary>
        /// The identification number of the MFA device for the user. If the IAM user has a policy requiring MFA authentication (or is in a group
        /// requiring MFA authentication) to access resources, provide the device value here.The value is in the <b>Security Credentials</b> tab of the
        /// user's details pane in the IAM console. If the IAM user has an active MFA device, the details pane displays a <b>Multi-Factor Authentication
        /// Device</b> value. The value is either for a virtual device, such as <c>arn:aws:iam::123456789012:mfa/user</c>, or it is the device serial
        /// number for a hardware device (usually the number from the back of the device), such as <c>GAHT12345678</c>. For more information, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/Using_ManagingMFA.html" target="_blank">Using Multi-Factor Authentication (MFA)
        /// Devices with AWS</a> in <i>Using IAM</i>.
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
        public GetSessionTokenRequest WithSerialNumber(string serialNumber)
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
        /// The value provided by the MFA device. If the user has an access policy requiring an MFA code (or is in a group requiring an MFA code),
        /// provide the value here to get permission to resources as specified in the access policy. If MFA authentication is required, and the user
        /// does not provide a code when requesting a set of temporary security credentials, the user will receive an "access denied" response when
        /// requesting resources that require MFA authentication. For more information, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/Using_ManagingMFA.html" target="_blank">Using Multi-Factor Authentication (MFA)
        /// Devices with AWS</a> in <i>Using IAM</i>.
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
            

        // Check to see if TokenCode property is set
        internal bool IsSetTokenCode()
        {
            return this.tokenCode != null;       
        }
    }
}
    
