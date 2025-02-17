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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the GetSessionToken operation.
    /// Returns a set of temporary credentials for an Amazon Web Services account or IAM user.
    /// The credentials consist of an access key ID, a secret access key, and a security token.
    /// Typically, you use <c>GetSessionToken</c> if you want to use MFA to protect programmatic
    /// calls to specific Amazon Web Services API operations like Amazon EC2 <c>StopInstances</c>.
    /// 
    ///  
    /// <para>
    /// MFA-enabled IAM users must call <c>GetSessionToken</c> and submit an MFA code that
    /// is associated with their MFA device. Using the temporary security credentials that
    /// the call returns, IAM users can then make programmatic calls to API operations that
    /// require MFA authentication. An incorrect MFA code causes the API to return an access
    /// denied error. For a comparison of <c>GetSessionToken</c> with the other API operations
    /// that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_sts-comparison.html">Compare
    /// STS credentials</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// No permissions are required for users to perform this operation. The purpose of the
    /// <c>sts:GetSessionToken</c> operation is to authenticate the user using MFA. You cannot
    /// use policies to control authentication operations. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_getsessiontoken.html">Permissions
    /// for GetSessionToken</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Session Duration</b> 
    /// </para>
    ///  
    /// <para>
    /// The <c>GetSessionToken</c> operation must be called by using the long-term Amazon
    /// Web Services security credentials of an IAM user. Credentials that are created by
    /// IAM users are valid for the duration that you specify. This duration can range from
    /// 900 seconds (15 minutes) up to a maximum of 129,600 seconds (36 hours), with a default
    /// of 43,200 seconds (12 hours). Credentials based on account credentials can range from
    /// 900 seconds (15 minutes) up to 3,600 seconds (1 hour), with a default of 1 hour. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials created by <c>GetSessionToken</c> can be used to
    /// make API calls to any Amazon Web Services service with the following exceptions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You cannot call any IAM API operations unless MFA authentication information is included
    /// in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot call any STS API <i>except</i> <c>AssumeRole</c> or <c>GetCallerIdentity</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The credentials that <c>GetSessionToken</c> returns are based on permissions associated
    /// with the IAM user whose credentials were used to call the operation. The temporary
    /// credentials have the same permissions as the IAM user.
    /// </para>
    ///  <note> 
    /// <para>
    /// Although it is possible to call <c>GetSessionToken</c> using the security credentials
    /// of an Amazon Web Services account root user rather than an IAM user, we do not recommend
    /// it. If <c>GetSessionToken</c> is called using root user credentials, the temporary
    /// credentials have root user permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#lock-away-credentials">Safeguard
    /// your root user credentials and don't use them for everyday tasks</a> in the <i>IAM
    /// User Guide</i> 
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about using <c>GetSessionToken</c> to create temporary credentials,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
    /// Credentials for Users in Untrusted Environments</a> in the <i>IAM User Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class GetSessionTokenRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _serialNumber;
        private string _tokenCode;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetSessionTokenRequest() { }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, that the credentials should remain valid. Acceptable durations
        /// for IAM user sessions range from 900 seconds (15 minutes) to 129,600 seconds (36 hours),
        /// with 43,200 seconds (12 hours) as the default. Sessions for Amazon Web Services account
        /// owners are restricted to a maximum of 3,600 seconds (one hour). If the duration is
        /// longer than one hour, the session for Amazon Web Services account owners defaults
        /// to one hour.
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=129600)]
        public int DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The identification number of the MFA device that is associated with the IAM user who
        /// is making the <c>GetSessionToken</c> call. Specify this value if the IAM user has
        /// a policy that requires MFA authentication. The value is either the serial number for
        /// a hardware device (such as <c>GAHT12345678</c>) or an Amazon Resource Name (ARN) for
        /// a virtual device (such as <c>arn:aws:iam::123456789012:mfa/user</c>). You can find
        /// the device for an IAM user by going to the Amazon Web Services Management Console
        /// and viewing the user's security credentials. 
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@:/-
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=256)]
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
        /// Gets and sets the property TokenCode. 
        /// <para>
        /// The value provided by the MFA device, if MFA is required. If any policy requires the
        /// IAM user to submit an MFA code, specify this value. If MFA authentication is required,
        /// the user must provide a code when requesting a set of temporary security credentials.
        /// A user who fails to provide the code receives an "access denied" response when requesting
        /// resources that require MFA authentication.
        /// </para>
        ///  
        /// <para>
        /// The format for this parameter, as described by its regex pattern, is a sequence of
        /// six numeric digits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=6)]
        public string TokenCode
        {
            get { return this._tokenCode; }
            set { this._tokenCode = value; }
        }

        // Check to see if TokenCode property is set
        internal bool IsSetTokenCode()
        {
            return this._tokenCode != null;
        }

    }
}