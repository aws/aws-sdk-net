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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a permission for a network interface.
    /// </summary>
    public partial class NetworkInterfacePermission
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// The Amazon Web Services service.
        /// </para>
        /// </summary>
        public string AwsService { get; set; }

        /// <summary>
        /// Checks to see if the AwsService property is set.
        /// </summary>
        internal bool IsSetAwsService() => this.AwsService != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfacePermissionId. 
        /// <para>
        /// The ID of the network interface permission.
        /// </para>
        /// </summary>
        public string NetworkInterfacePermissionId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfacePermissionId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfacePermissionId() => this.NetworkInterfacePermissionId != null;

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The type of permission.
        /// </para>
        /// </summary>
        public InterfacePermissionType Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;

        /// <summary>
        /// Gets and sets the property PermissionState. 
        /// <para>
        /// Information about the state of the permission.
        /// </para>
        /// </summary>
        public NetworkInterfacePermissionState PermissionState { get; set; }

        /// <summary>
        /// Checks to see if the PermissionState property is set.
        /// </summary>
        internal bool IsSetPermissionState() => this.PermissionState != null;
    }
}
