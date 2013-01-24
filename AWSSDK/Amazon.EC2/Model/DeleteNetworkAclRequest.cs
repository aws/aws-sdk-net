/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Deletes a network ACL from a VPC.
    /// </summary>
    /// <remarks>
    /// The ACL must not have any subnets associated with it.
    /// You can't delete the default network ACL. For more
    /// information about network ACLs, go to Network ACLs in the
    /// Amazon Virtual Private Cloud User Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteNetworkAclRequest
    {    
        private string networkAclIdField;

        /// <summary>
        /// The ID of the network ACL to be deleted.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkAclId")]
        public string NetworkAclId
        {
            get { return this.networkAclIdField; }
            set { this.networkAclIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the network ACL to be deleted.
        /// </summary>
        /// <param name="networkAclId">The ID of the network ACL to be deleted.</param>
        /// <returns>this instance</returns>
        public DeleteNetworkAclRequest WithNetworkAclId(string networkAclId)
        {
            this.networkAclIdField = networkAclId;
            return this;
        }

        /// <summary>
        /// Checks if NetworkAclId property is set
        /// </summary>
        /// <returns>true if NetworkAclId property is set</returns>
        public bool IsSetNetworkAclId()
        {
            return this.networkAclIdField != null;
        }

    }
}
