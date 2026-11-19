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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetScopedCredentials operation. Returns a set
    /// of temporary security credentials that are scoped down from the caller's existing
    /// temporary security credentials. <c>GetScopedCredentials</c> preserves the caller's
    /// identity while narrowing the permissions and optionally shortening the session lifetime.
    /// <para> For a comparison of <c>GetScopedCredentials</c> with the other API operations
    /// that produce temporary security credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_sts-comparison.html">Compare
    /// STS credentials</a> in the IAM User Guide. </para> <para> <b>Credential requirements</b>
    /// </para> <para> You can only call <c>GetScopedCredentials</c> with temporary security
    /// credentials, for example, credentials from an assumed role or a federated session.
    /// You cannot call it with IAM user credentials or root credentials. If you want to scope
    /// down IAM user credentials, first call <c>GetSessionToken</c> to get temporary security
    /// credentials, and then call <c>GetScopedCredentials</c> with those credentials. </para>
    /// <note> <para> The <c>GetScopedCredentials</c> API is not available on the STS Global
    /// endpoint. </para> </note>
    /// </summary>
    public partial class GetScopedCredentialsRequest : AmazonSecurityTokenServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, of the resulting scoped down credentials. The value can
        /// range from 1 second to 129,600 seconds (36 hours).
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this value, the scoped down credentials will inherit the calling
        /// session's expiration time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 129600)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumSessionTokenSize.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public int? MinimumSessionTokenSize { get; set; }

        /// <summary>
        /// Checks to see if the MinimumSessionTokenSize property is set.
        /// </summary>
        internal bool IsSetMinimumSessionTokenSize() => this.MinimumSessionTokenSize.HasValue;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// An IAM policy in JSON format that you want to use as a scope down policy.
        /// </para>
        ///  
        /// <para>
        /// A request must provide at least one of <c>Policy</c> or <c>DurationSeconds</c>. Both
        /// parameters are optional individually, but you must specify at least one of them.
        /// </para>
        ///  
        /// <para>
        /// The resulting session's permissions are the intersection of the calling session's
        /// existing permissions and this scope down policy. You cannot use this scope down policy
        /// to grant more permissions than the calling session already has.
        /// </para>
        ///  
        /// <para>
        /// The plaintext of the scope down policy cannot exceed 2,048 characters. The JSON policy
        /// characters can be any ASCII character from the space character to the end of the valid
        /// character list (\u0020 through \u00FF). It can also include the tab (\u0009), linefeed
        /// (\u000A), and carriage return (\u000D) characters.
        /// </para>
        ///  <note> 
        /// <para>
        /// An internal conversion compresses the inline scope down policy into a packed binary
        /// format that has a separate limit. If the packed policy exceeds this limit, the request
        /// fails with <c>PackedPolicyTooLarge</c>.
        /// </para>
        ///  
        /// <para>
        /// If the document is not valid IAM policy JSON, the request fails with <c>MalformedPolicyDocument</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property ScopedSessionDescription. 
        /// <para>
        /// A caller-supplied description of the scoped session. The value cannot exceed 256 characters.
        /// This description is logged to CloudTrail for the request, so you can use it to record
        /// the purpose of the scoped session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 256)]
        public string ScopedSessionDescription { get; set; }

        /// <summary>
        /// Checks to see if the ScopedSessionDescription property is set.
        /// </summary>
        internal bool IsSetScopedSessionDescription() => this.ScopedSessionDescription != null;
    }
}
