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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the GetImpersonationRoleEffect operation.
    /// Tests whether the given impersonation role can impersonate a target user.
    /// </summary>
    public partial class GetImpersonationRoleEffectRequest : AmazonWorkMailRequest
    {
        private string _impersonationRoleId;
        private string _organizationId;
        private string _targetUser;

        /// <summary>
        /// Gets and sets the property ImpersonationRoleId. 
        /// <para>
        /// The impersonation role ID to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ImpersonationRoleId
        {
            get { return this._impersonationRoleId; }
            set { this._impersonationRoleId = value; }
        }

        // Check to see if ImpersonationRoleId property is set
        internal bool IsSetImpersonationRoleId()
        {
            return this._impersonationRoleId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The WorkMail organization where the impersonation role is defined.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetUser. 
        /// <para>
        /// The WorkMail organization user chosen to test the impersonation role. The following
        /// identity formats are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User ID: <c>12345678-1234-1234-1234-123456789012</c> or <c>S-1-1-12-1234567890-123456789-123456789-1234</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: <c>user@domain.tld</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name: <c>user</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TargetUser
        {
            get { return this._targetUser; }
            set { this._targetUser = value; }
        }

        // Check to see if TargetUser property is set
        internal bool IsSetTargetUser()
        {
            return this._targetUser != null;
        }

    }
}