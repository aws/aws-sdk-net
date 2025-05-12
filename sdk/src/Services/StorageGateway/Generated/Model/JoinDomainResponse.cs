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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// JoinDomainOutput
    /// </summary>
    public partial class JoinDomainResponse : AmazonWebServiceResponse
    {
        private ActiveDirectoryStatus _activeDirectoryStatus;
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryStatus. 
        /// <para>
        /// Indicates the status of the gateway as a member of the Active Directory domain.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is only used as part of a <c>JoinDomain</c> request. It is not affected
        /// by Active Directory connectivity changes that occur after the <c>JoinDomain</c> request
        /// succeeds.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>ACCESS_DENIED</c>: Indicates that the <c>JoinDomain</c> operation failed due to
        /// an authentication error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DETACHED</c>: Indicates that gateway is not joined to a domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JOINED</c>: Indicates that the gateway has successfully joined a domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JOINING</c>: Indicates that a <c>JoinDomain</c> operation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_PERMISSIONS</c>: Indicates that the <c>JoinDomain</c> operation failed
        /// because the specified user lacks the necessary permissions to join the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETWORK_ERROR</c>: Indicates that <c>JoinDomain</c> operation failed due to a
        /// network or connectivity error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TIMEOUT</c>: Indicates that the <c>JoinDomain</c> operation failed because the
        /// operation didn't complete within the allotted time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN_ERROR</c>: Indicates that the <c>JoinDomain</c> operation failed due to
        /// another type of error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ActiveDirectoryStatus ActiveDirectoryStatus
        {
            get { return this._activeDirectoryStatus; }
            set { this._activeDirectoryStatus = value; }
        }

        // Check to see if ActiveDirectoryStatus property is set
        internal bool IsSetActiveDirectoryStatus()
        {
            return this._activeDirectoryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the gateway that joined the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

    }
}