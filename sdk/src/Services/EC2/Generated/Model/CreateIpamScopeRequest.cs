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
    /// Container for the parameters to the CreateIpamScope operation.
    /// Create an IPAM scope. In IPAM, a scope is the highest-level container within IPAM.
    /// An IPAM contains two default scopes. Each scope represents the IP space for a single
    /// network. The private scope is intended for all private IP address space. The public
    /// scope is intended for all public IP address space. Scopes enable you to reuse IP addresses
    /// across multiple unconnected networks without causing IP address overlap or conflict.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/add-scope-ipam.html">Add
    /// a scope</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateIpamScopeRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private ExternalAuthorityConfiguration _externalAuthorityConfiguration;
        private string _ipamId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the scope you're creating.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalAuthorityConfiguration. 
        /// <para>
        /// The configuration that links an Amazon VPC IPAM scope to an external authority system.
        /// It specifies the type of external system and the external resource identifier that
        /// identifies your account or instance in that system.
        /// </para>
        ///  
        /// <para>
        /// In IPAM, an external authority is a third-party IP address management system that
        /// provides CIDR blocks when you provision address space for top-level IPAM pools. This
        /// allows you to use your existing IP management system to control which address ranges
        /// are allocated to Amazon Web Services while using Amazon VPC IPAM to manage subnets
        /// within those ranges.
        /// </para>
        /// </summary>
        public ExternalAuthorityConfiguration ExternalAuthorityConfiguration
        {
            get { return this._externalAuthorityConfiguration; }
            set { this._externalAuthorityConfiguration = value; }
        }

        // Check to see if ExternalAuthorityConfiguration property is set
        internal bool IsSetExternalAuthorityConfiguration()
        {
            return this._externalAuthorityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM for which you're creating this scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamId
        {
            get { return this._ipamId; }
            set { this._ipamId = value; }
        }

        // Check to see if IpamId property is set
        internal bool IsSetIpamId()
        {
            return this._ipamId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>, specify <c>tag:Owner</c>
        /// for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}