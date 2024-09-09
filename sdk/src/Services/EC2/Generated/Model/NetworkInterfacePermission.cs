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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a permission for a network interface.
    /// </summary>
    public partial class NetworkInterfacePermission
    {
        private string _awsAccountId;
        private string _awsService;
        private string _networkInterfaceId;
        private string _networkInterfacePermissionId;
        private InterfacePermissionType _permission;
        private NetworkInterfacePermissionState _permissionState;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// The Amazon Web Services service.
        /// </para>
        /// </summary>
        public string AwsService
        {
            get { return this._awsService; }
            set { this._awsService = value; }
        }

        // Check to see if AwsService property is set
        internal bool IsSetAwsService()
        {
            return this._awsService != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfacePermissionId. 
        /// <para>
        /// The ID of the network interface permission.
        /// </para>
        /// </summary>
        public string NetworkInterfacePermissionId
        {
            get { return this._networkInterfacePermissionId; }
            set { this._networkInterfacePermissionId = value; }
        }

        // Check to see if NetworkInterfacePermissionId property is set
        internal bool IsSetNetworkInterfacePermissionId()
        {
            return this._networkInterfacePermissionId != null;
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The type of permission.
        /// </para>
        /// </summary>
        public InterfacePermissionType Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionState. 
        /// <para>
        /// Information about the state of the permission.
        /// </para>
        /// </summary>
        public NetworkInterfacePermissionState PermissionState
        {
            get { return this._permissionState; }
            set { this._permissionState = value; }
        }

        // Check to see if PermissionState property is set
        internal bool IsSetPermissionState()
        {
            return this._permissionState != null;
        }

    }
}