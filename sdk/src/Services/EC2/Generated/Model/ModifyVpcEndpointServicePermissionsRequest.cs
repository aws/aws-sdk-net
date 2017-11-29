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
    /// Container for the parameters to the ModifyVpcEndpointServicePermissions operation.
    /// Modifies the permissions for your VPC endpoint service. You can add or remove permissions
    /// for service consumers (IAM users, IAM roles, and AWS accounts) to discover your endpoint
    /// service.
    /// </summary>
    public partial class ModifyVpcEndpointServicePermissionsRequest : AmazonEC2Request
    {
        private List<string> _addAllowedPrincipals = new List<string>();
        private List<string> _removeAllowedPrincipals = new List<string>();
        private string _serviceId;

        /// <summary>
        /// Gets and sets the property AddAllowedPrincipals. 
        /// <para>
        /// One or more Amazon Resource Names (ARNs) of principals for which to allow permission.
        /// Specify <code>*</code> to allow all principals.
        /// </para>
        /// </summary>
        public List<string> AddAllowedPrincipals
        {
            get { return this._addAllowedPrincipals; }
            set { this._addAllowedPrincipals = value; }
        }

        // Check to see if AddAllowedPrincipals property is set
        internal bool IsSetAddAllowedPrincipals()
        {
            return this._addAllowedPrincipals != null && this._addAllowedPrincipals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveAllowedPrincipals. 
        /// <para>
        /// One or more Amazon Resource Names (ARNs) of principals for which to remove permission.
        /// </para>
        /// </summary>
        public List<string> RemoveAllowedPrincipals
        {
            get { return this._removeAllowedPrincipals; }
            set { this._removeAllowedPrincipals = value; }
        }

        // Check to see if RemoveAllowedPrincipals property is set
        internal bool IsSetRemoveAllowedPrincipals()
        {
            return this._removeAllowedPrincipals != null && this._removeAllowedPrincipals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service.
        /// </para>
        /// </summary>
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

    }
}