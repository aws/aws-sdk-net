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

namespace Amazon.AccountAccessRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GetRoleCredentials operation. Returns temporary
    /// Amazon Web Services credentials for a role that you are entitled to assume within
    /// a tenant. You can use these credentials for programmatic access with the CLI or an
    /// Amazon Web Services SDK. If you aren't entitled to the role, the request fails with
    /// an <c>AccessDeniedException</c> error.
    /// </summary>
    public partial class GetRoleCredentialsRequest : AmazonAccountAccessRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of access to request for the role. Specify <c>PROGRAMMATIC_ACCESS</c> to
        /// receive access key credentials for use with the CLI or an Amazon Web Services SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to retrieve credentials for. You must be
        /// entitled to assume this role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SessionDuration. 
        /// <para>
        /// The duration, in seconds, that the returned credentials remain valid. If you don't
        /// specify a value, the service uses the default session duration. The maximum value
        /// can't exceed the maximum session duration configured for the role.
        /// </para>
        /// </summary>
        public int? SessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the SessionDuration property is set.
        /// </summary>
        internal bool IsSetSessionDuration() => this.SessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// An optional name for the role session. The name can be 2 to 64 characters and can
        /// contain alphanumeric characters and the following symbols: plus (+), equal (=), comma
        /// (,), period (.), at (@), and hyphen (-). The session name appears in CloudTrail logs
        /// for the assumed role session.
        /// </para>
        /// </summary>
        public string SessionName { get; set; }

        /// <summary>
        /// Checks to see if the SessionName property is set.
        /// </summary>
        internal bool IsSetSessionName() => this.SessionName != null;

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The identifier of the tenant that the request applies to. A tenant ID begins with
        /// <c>aa-</c> and is 3 to 24 characters long. It can contain lowercase letters, numbers,
        /// and hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 24)]
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;
    }
}
