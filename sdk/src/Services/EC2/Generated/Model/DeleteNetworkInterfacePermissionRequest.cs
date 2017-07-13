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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNetworkInterfacePermission operation.
    /// Deletes a permission for a network interface. By default, you cannot delete the permission
    /// if the account for which you're removing the permission has attached the network interface
    /// to an instance. However, you can force delete the permission, regardless of any attachment.
    /// </summary>
    public partial class DeleteNetworkInterfacePermissionRequest : AmazonEC2Request
    {
        private bool? _force;
        private string _networkInterfacePermissionId;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Specify <code>true</code> to remove the permission even if the network interface is
        /// attached to an instance.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
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

    }
}