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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Updates the registered identity provider’s product related configuration settings
    /// such as the subnets to provision VPC endpoints.
    /// </summary>
    public partial class UpdateSettings
    {
        private List<string> _addSubnets = new List<string>();
        private List<string> _removeSubnets = new List<string>();
        private string _securityGroupId;

        /// <summary>
        /// Gets and sets the property AddSubnets. 
        /// <para>
        /// The ID of one or more subnets in which License Manager will create a VPC endpoint
        /// for products that require connectivity to activation servers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AddSubnets
        {
            get { return this._addSubnets; }
            set { this._addSubnets = value; }
        }

        // Check to see if AddSubnets property is set
        internal bool IsSetAddSubnets()
        {
            return this._addSubnets != null && this._addSubnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveSubnets. 
        /// <para>
        /// The ID of one or more subnets to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RemoveSubnets
        {
            get { return this._removeSubnets; }
            set { this._removeSubnets = value; }
        }

        // Check to see if RemoveSubnets property is set
        internal bool IsSetRemoveSubnets()
        {
            return this._removeSubnets != null && this._removeSubnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// A security group ID that allows inbound TCP port 1688 communication between resources
        /// in your VPC and the VPC endpoints for activation servers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=200)]
        public string SecurityGroupId
        {
            get { return this._securityGroupId; }
            set { this._securityGroupId = value; }
        }

        // Check to see if SecurityGroupId property is set
        internal bool IsSetSecurityGroupId()
        {
            return this._securityGroupId != null;
        }

    }
}