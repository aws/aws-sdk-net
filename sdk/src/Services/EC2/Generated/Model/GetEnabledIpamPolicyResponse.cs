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
    /// This is the response object from the GetEnabledIpamPolicy operation.
    /// </summary>
    public partial class GetEnabledIpamPolicyResponse : AmazonWebServiceResponse
    {
        private bool? _ipamPolicyEnabled;
        private string _ipamPolicyId;
        private IpamPolicyManagedBy _managedBy;

        /// <summary>
        /// Gets and sets the property IpamPolicyEnabled. 
        /// <para>
        /// Indicates whether the IPAM policy is enabled.
        /// </para>
        /// </summary>
        public bool? IpamPolicyEnabled
        {
            get { return this._ipamPolicyEnabled; }
            set { this._ipamPolicyEnabled = value; }
        }

        // Check to see if IpamPolicyEnabled property is set
        internal bool IsSetIpamPolicyEnabled()
        {
            return this._ipamPolicyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamPolicyId. 
        /// <para>
        /// The ID of the enabled IPAM policy.
        /// </para>
        /// </summary>
        public string IpamPolicyId
        {
            get { return this._ipamPolicyId; }
            set { this._ipamPolicyId = value; }
        }

        // Check to see if IpamPolicyId property is set
        internal bool IsSetIpamPolicyId()
        {
            return this._ipamPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the IPAM policy.
        /// </para>
        /// </summary>
        public IpamPolicyManagedBy ManagedBy
        {
            get { return this._managedBy; }
            set { this._managedBy = value; }
        }

        // Check to see if ManagedBy property is set
        internal bool IsSetManagedBy()
        {
            return this._managedBy != null;
        }

    }
}