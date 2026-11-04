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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the GetDelegationRequest operation.
    /// </summary>
    public partial class GetDelegationRequestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DelegationRequest. 
        /// <para>
        /// The delegation request object containing all details about the request.
        /// </para>
        /// </summary>
        public DelegationRequest DelegationRequest { get; set; }

        /// <summary>
        /// Checks to see if the DelegationRequest property is set.
        /// </summary>
        internal bool IsSetDelegationRequest() => this.DelegationRequest != null;

        /// <summary>
        /// Gets and sets the property PermissionCheckResult. 
        /// <para>
        /// The result of the permission check, indicating whether the caller has sufficient permissions
        /// to cover the requested permissions. This is an approximate result.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOWED</c> : The caller has sufficient permissions cover all the requested permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DENIED</c> : The caller does not have sufficient permissions to cover all the
        /// requested permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNSURE</c> : It is not possible to determine whether the caller has all the permissions
        /// needed. This output is most likely for cases when the caller has permissions with
        /// conditions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionCheckResultType PermissionCheckResult { get; set; }

        /// <summary>
        /// Checks to see if the PermissionCheckResult property is set.
        /// </summary>
        internal bool IsSetPermissionCheckResult() => this.PermissionCheckResult != null;

        /// <summary>
        /// Gets and sets the property PermissionCheckStatus. 
        /// <para>
        /// The status of the permission check for the delegation request.
        /// </para>
        ///  
        /// <para>
        /// This value indicates the status of the process to check whether the caller has sufficient
        /// permissions to cover the requested actions in the delegation request. Since this is
        /// an asynchronous process, there are three potential values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> : The permission check process has started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> : The permission check process has completed. The <c>PermissionCheckResult</c>
        /// will include the result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> : The permission check process has failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionCheckStatusType PermissionCheckStatus { get; set; }

        /// <summary>
        /// Checks to see if the PermissionCheckStatus property is set.
        /// </summary>
        internal bool IsSetPermissionCheckStatus() => this.PermissionCheckStatus != null;
    }
}
