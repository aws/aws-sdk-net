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
    /// This is the response object from the GetScopedCredentials operation.
    /// </summary>
    public partial class GetScopedCredentialsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary security credentials for the scoped down session, which include an access
        /// key ID, a secret access key, and a security token.
        /// </para>
        ///  <note> 
        /// <para>
        /// The size of the security token that STS API operations return is not fixed. We strongly
        /// recommend that you make no assumptions about the maximum size.
        /// </para>
        ///  </note>
        /// </summary>
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property ScopedPoliciesCount. 
        /// <para>
        ///  <c>GetScopedCredentials</c> can be called recursively and <c>ScopedPoliciesCount</c>
        /// specifies the number of scope down policies applied to the session. Each recursive
        /// call adds another scope down policy layer. A maximum of 3 scope down policy layers
        /// are allowed per session. If a session already has 3 <c>GetScopedCredentials</c> scope-down
        /// policies, a subsequent <c>GetScopedCredentials</c> call that supplies a <c>Policy</c>
        /// (attempting to append a fourth scope-down policy) is denied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ScopedPoliciesCount { get; set; }

        /// <summary>
        /// Checks to see if the ScopedPoliciesCount property is set.
        /// </summary>
        internal bool IsSetScopedPoliciesCount() => this.ScopedPoliciesCount.HasValue;

        /// <summary>
        /// Gets and sets the property SessionInfo. 
        /// <para>
        /// Metadata about the resulting scoped session, including its identifier and ARN. Because
        /// the identity does not change, the identifiers reflect the same principal and session
        /// name as the calling session.
        /// </para>
        /// </summary>
        public ScopedSession SessionInfo { get; set; }

        /// <summary>
        /// Checks to see if the SessionInfo property is set.
        /// </summary>
        internal bool IsSetSessionInfo() => this.SessionInfo != null;

        /// <summary>
        /// Gets and sets the property SessionTokenSize.
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SessionTokenSize { get; set; }

        /// <summary>
        /// Checks to see if the SessionTokenSize property is set.
        /// </summary>
        internal bool IsSetSessionTokenSize() => this.SessionTokenSize.HasValue;

        /// <summary>
        /// Gets and sets the property SessionTokenUtilization.
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SessionTokenUtilization { get; set; }

        /// <summary>
        /// Checks to see if the SessionTokenUtilization property is set.
        /// </summary>
        internal bool IsSetSessionTokenUtilization() => this.SessionTokenUtilization.HasValue;

        /// <summary>
        /// Gets and sets the property SourceIdentity. 
        /// <para>
        /// The source identity of the calling session, carried forward unchanged. This operation
        /// never sets or modifies the source identity; it reflects the value established when
        /// the source identity was first set. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_monitor.html">Monitor
        /// and control actions taken with assumed roles</a> in the IAM User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 256)]
        public string SourceIdentity { get; set; }

        /// <summary>
        /// Checks to see if the SourceIdentity property is set.
        /// </summary>
        internal bool IsSetSourceIdentity() => this.SourceIdentity != null;
    }
}
