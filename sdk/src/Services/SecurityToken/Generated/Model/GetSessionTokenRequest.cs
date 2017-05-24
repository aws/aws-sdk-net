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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
    /// Returns a set of temporary credentials for an AWS account or IAM user. The credentials
    /// consist of an access key ID, a secret access key, and a security token. Typically,
    /// you use <code>GetSessionToken</code> if you want to use MFA to protect programmatic
    /// calls to specific AWS APIs like Amazon EC2 <code>StopInstances</code>. MFA-enabled
    /// IAM users would need to call <code>GetSessionToken</code> and submit an MFA code that
    /// is associated with their MFA device. Using the temporary security credentials that
    /// are returned from the call, IAM users can then make programmatic calls to APIs that
    /// require MFA authentication. If you do not supply a correct MFA code, then the API
    /// returns an access denied error. For a comparison of <code>GetSessionToken</code> with
    /// the other APIs that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
    /// 
    ///  
    /// <para>
    /// The <code>GetSessionToken</code> action must be called by using the long-term AWS
    /// security credentials of the AWS account or an IAM user. Credentials that are created
    /// by IAM users are valid for the duration that you specify, from 900 seconds (15 minutes)
    /// up to a maximum of 129600 seconds (36 hours), with a default of 43200 seconds (12
    /// hours); credentials that are created by using account credentials can range from 900
    /// seconds (15 minutes) up to a maximum of 3600 seconds (1 hour), with a default of 1
    /// hour. 
    /// </para>
    ///  
    /// <para>
    /// The temporary security credentials created by <code>GetSessionToken</code> can be
    /// used to make API calls to any AWS service with the following exceptions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You cannot call any IAM APIs unless MFA authentication information is included in
    /// the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot call any STS API <i>except</i> <code>AssumeRole</code> or <code>GetCallerIdentity</code>.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// We recommend that you do not call <code>GetSessionToken</code> with root account credentials.
    /// Instead, follow our <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#create-iam-users">best
    /// practices</a> by creating one or more IAM users, giving them the necessary permissions,
    /// and using IAM users for everyday interaction with AWS. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The permissions associated with the temporary security credentials returned by <code>GetSessionToken</code>
    /// are based on the permissions associated with account or IAM user whose credentials
    /// are used to call the action. If <code>GetSessionToken</code> is called using root
    /// account credentials, the temporary credentials have root account permissions. Similarly,
    /// if <code>GetSessionToken</code> is called using the credentials of an IAM user, the
    /// temporary credentials have the same permissions as the IAM user. 
    /// </para>
    ///  
    /// <para>
    /// For more information about using <code>GetSessionToken</code> to create temporary
    /// credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
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
        /// for IAM user sessions range from 900 seconds (15 minutes) to 129600 seconds (36 hours),
        /// with 43200 seconds (12 hours) as the default. Sessions for AWS account owners are
        /// restricted to a maximum of 3600 seconds (one hour). If the duration is longer than
        /// one hour, the session for AWS account owners defaults to one hour.
        /// </para>
        /// </summary>
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
        /// is making the <code>GetSessionToken</code> call. Specify this value if the IAM user
        /// has a policy that requires MFA authentication. The value is either the serial number
        /// for a hardware device (such as <code>GAHT12345678</code>) or an Amazon Resource Name
        /// (ARN) for a virtual device (such as <code>arn:aws:iam::123456789012:mfa/user</code>).
        /// You can find the device for an IAM user by going to the AWS Management Console and
        /// viewing the user's security credentials. 
        /// </para>
        ///  
        /// <para>
        /// The regex used to validated this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@:/-
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
        /// Gets and sets the property TokenCode. 
        /// <para>
        /// The value provided by the MFA device, if MFA is required. If any policy requires the
        /// IAM user to submit an MFA code, specify this value. If MFA authentication is required,
        /// and the user does not provide a code when requesting a set of temporary security credentials,
        /// the user will receive an "access denied" response when requesting resources that require
        /// MFA authentication.
        /// </para>
        ///  
        /// <para>
        /// The format for this parameter, as described by its regex pattern, is a sequence of
        /// six numeric digits.
        /// </para>
        /// </summary>
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