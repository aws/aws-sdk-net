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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about the effect that a permissions boundary has on a policy
    /// simulation when the boundary is applied to an IAM entity.
    /// </summary>
    public partial class PermissionsBoundaryDecisionDetail
    {
        private bool? _allowedByPermissionsBoundary;

        /// <summary>
        /// Gets and sets the property AllowedByPermissionsBoundary. 
        /// <para>
        /// Specifies whether an action is allowed by a permissions boundary that is applied to
        /// an IAM entity (user or role). A value of <c>true</c> means that the permissions boundary
        /// does not deny the action. This means that the policy includes an <c>Allow</c> statement
        /// that matches the request. In this case, if an identity-based policy also allows the
        /// action, the request is allowed. A value of <c>false</c> means that either the requested
        /// action is not allowed (implicitly denied) or that the action is explicitly denied
        /// by the permissions boundary. In both of these cases, the action is not allowed, regardless
        /// of the identity-based policy.
        /// </para>
        /// </summary>
        public bool? AllowedByPermissionsBoundary
        {
            get { return this._allowedByPermissionsBoundary; }
            set { this._allowedByPermissionsBoundary = value; }
        }

        // Check to see if AllowedByPermissionsBoundary property is set
        internal bool IsSetAllowedByPermissionsBoundary()
        {
            return this._allowedByPermissionsBoundary.HasValue; 
        }

    }
}