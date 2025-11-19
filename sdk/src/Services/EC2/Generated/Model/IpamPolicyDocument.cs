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
    /// Information about an IPAM policy.
    /// </summary>
    public partial class IpamPolicyDocument
    {
        private List<IpamPolicyAllocationRule> _allocationRules = AWSConfigs.InitializeCollections ? new List<IpamPolicyAllocationRule>() : null;
        private string _ipamPolicyId;
        private string _locale;
        private IpamPolicyResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property AllocationRules. 
        /// <para>
        /// The allocation rules in the IPAM policy document.
        /// </para>
        ///  
        /// <para>
        /// Allocation rules are optional configurations within an IPAM policy that map Amazon
        /// Web Services resource types to specific IPAM pools. If no rules are defined, the resource
        /// types default to using Amazon-provided IP addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamPolicyAllocationRule> AllocationRules
        {
            get { return this._allocationRules; }
            set { this._allocationRules = value; }
        }

        // Check to see if AllocationRules property is set
        internal bool IsSetAllocationRules()
        {
            return this._allocationRules != null && (this._allocationRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpamPolicyId. 
        /// <para>
        /// The ID of the IPAM policy.
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
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the IPAM policy document.
        /// </para>
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type of the IPAM policy document.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services service or resource type that can use IP addresses through
        /// IPAM policies. Supported services and resource types include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Elastic IP addresses
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamPolicyResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}