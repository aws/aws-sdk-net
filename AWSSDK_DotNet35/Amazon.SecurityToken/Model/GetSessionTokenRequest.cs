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
    /// <para> Returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an access key ID, a secret access
    /// key, and a security token. Typically, you use <c>GetSessionToken</c> if you want use MFA to protect programmatic calls to specific AWS APIs
    /// like Amazon EC2 <c>StopInstances</c> . MFA-enabled IAM users would need to call <c>GetSessionToken</c> and submit an MFA code that is
    /// associated with their MFA device. Using the temporary security credentials that are returned from the call, IAM users can then make
    /// programmatic calls to APIs that require MFA authentication. </para> <para> The <c>GetSessionToken</c> action must be called by using the
    /// long-term AWS security credentials of the AWS account or an IAM user. Credentials that are created by IAM users are valid for the duration
    /// that you specify, between 900 seconds (15 minutes) and 129600 seconds (36 hours); credentials that are created by using account credentials
    /// have a maximum duration of 3600 seconds (1 hour). </para> <para>Optionally, you can pass an AWS IAM access policy to this operation. The
    /// temporary security credentials that are returned by the operation have the permissions that are associated with the entity that is making
    /// the <c>GetSessionToken</c> call, except for any permissions explicitly denied by the policy you pass. This gives you a way to further
    /// restrict the permissions for the federated user. These policies and any applicable resource-based policies are evaluated when calls to AWS
    /// are made using the temporary security credentials. </para> <para>For more information about using <c>GetSessionToken</c> to create temporary
    /// credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingSessionTokens.html" > Creating Temporary Credentials to
    /// Enable Access for IAM Users </a> in <i>Using IAM</i> .
    /// </para>
    /// </summary>
    public partial class GetSessionTokenRequest : AmazonSecurityTokenServiceRequest
    {
        private int? durationSeconds;
        private string serialNumber;
        private string tokenCode;


        /// <summary>
        /// The duration, in seconds, that the credentials should remain valid. Acceptable durations for IAM user sessions range from 900 seconds (15
        /// minutes) to 129600 seconds (36 hours), with 43200 seconds (12 hours) as the default. Sessions for AWS account owners are restricted to a
        /// maximum of 3600 seconds (one hour). If the duration is longer than one hour, the session for AWS account owners defaults to one hour.
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

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this.durationSeconds.HasValue;
        }

        /// <summary>
        /// The identification number of the MFA device that is associated with the IAM user who is making the <c>GetSessionToken</c> call. Specify this
        /// value if the IAM user has a policy that requires MFA authentication. The value is either the serial number for a hardware device (such as
        /// <c>GAHT12345678</c>) or an Amazon Resource Name (ARN) for a virtual device (such as <c>arn:aws:iam::123456789012:mfa/user</c>). You can find
        /// the device for an IAM user by going to the AWS Management Console and viewing the user's security credentials.
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

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this.serialNumber != null;
        }

        /// <summary>
        /// The value provided by the MFA device, if MFA is required. If any policy requires the IAM user to submit an MFA code, specify this value. If
        /// MFA authentication is required, and the user does not provide a code when requesting a set of temporary security credentials, the user will
        /// receive an "access denied" response when requesting resources that require MFA authentication.
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

        // Check to see if TokenCode property is set
        internal bool IsSetTokenCode()
        {
            return this.tokenCode != null;
        }

    }
}
    
