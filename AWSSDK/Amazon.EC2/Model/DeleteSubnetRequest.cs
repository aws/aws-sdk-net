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
    /// Deletes a subnet from a VPC.
    /// </summary>
    /// <remarks>
    /// You must terminate all running instances in the subnet
    /// before deleting it, otherwise Amazon VPC returns an error.
    ///
    /// AWS might delete any subnet if you leave it inactive for
    /// an extended period of time (inactive means that there are
    /// no running Amazon EC2 instances in the subnet).
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteSubnetRequest
    {    
        private string subnetIdField;

        /// <summary>
        /// The ID of the subnet you want to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the subnet you want to delete.
        /// </summary>
        /// <param name="subnetId">The ID of the subnet you want to delete.</param>
        /// <returns>this instance</returns>
        public DeleteSubnetRequest WithSubnetId(string subnetId)
        {
            this.subnetIdField = subnetId;
            return this;
        }

        /// <summary>
        /// Checks if SubnetId property is set
        /// </summary>
        /// <returns>true if SubnetId property is set</returns>
        public bool IsSetSubnetId()
        {
            return this.subnetIdField != null;
        }

    }
}
