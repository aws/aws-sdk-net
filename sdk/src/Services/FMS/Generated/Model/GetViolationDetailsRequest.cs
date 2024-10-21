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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the GetViolationDetails operation.
    /// Retrieves violations for a resource based on the specified Firewall Manager policy
    /// and Amazon Web Services account.
    /// </summary>
    public partial class GetViolationDetailsRequest : AmazonFMSRequest
    {
        private string _memberAccount;
        private string _policyId;
        private string _resourceId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The Amazon Web Services account ID that you want the details for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string MemberAccount
        {
            get { return this._memberAccount; }
            set { this._memberAccount = value; }
        }

        // Check to see if MemberAccount property is set
        internal bool IsSetMemberAccount()
        {
            return this._memberAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the Firewall Manager policy that you want the details for. You can get violation
        /// details for the following policy types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// WAF
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DNS Firewall
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Imported Network Firewall
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network Firewall
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Security group content audit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network ACL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Third-party firewall
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource that has violations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. This is in the format shown in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services Resource Types Reference</a>. Supported resource types are: <c>AWS::WAFv2::WebACL</c>,
        /// <c>AWS::EC2::Instance</c>, <c>AWS::EC2::NetworkInterface</c>, <c>AWS::EC2::SecurityGroup</c>,
        /// <c>AWS::NetworkFirewall::FirewallPolicy</c>, and <c>AWS::EC2::Subnet</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceType
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