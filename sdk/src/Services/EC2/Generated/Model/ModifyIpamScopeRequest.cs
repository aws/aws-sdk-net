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
    /// Container for the parameters to the ModifyIpamScope operation.
    /// Modify an IPAM scope.
    /// </summary>
    public partial class ModifyIpamScopeRequest : AmazonEC2Request
    {
        private string _description;
        private bool? _dryRun;
        private ExternalAuthorityConfiguration _externalAuthorityConfiguration;
        private string _ipamScopeId;
        private bool? _removeExternalAuthorityConfiguration;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the scope you want to modify.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The ID of the scope you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamScopeId
        {
            get { return this._ipamScopeId; }
            set { this._ipamScopeId = value; }
        }

        // Check to see if IpamScopeId property is set
        internal bool IsSetIpamScopeId()
        {
            return this._ipamScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveExternalAuthorityConfiguration. 
        /// <para>
        /// Remove the external authority configuration. <c>true</c> to remove.
        /// </para>
        /// </summary>
        public bool? RemoveExternalAuthorityConfiguration
        {
            get { return this._removeExternalAuthorityConfiguration; }
            set { this._removeExternalAuthorityConfiguration = value; }
        }

        // Check to see if RemoveExternalAuthorityConfiguration property is set
        internal bool IsSetRemoveExternalAuthorityConfiguration()
        {
            return this._removeExternalAuthorityConfiguration.HasValue; 
        }

    }
}