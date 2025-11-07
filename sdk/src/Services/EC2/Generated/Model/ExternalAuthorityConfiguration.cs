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
    /// The configuration that links an Amazon VPC IPAM scope to an external authority system.
    /// It specifies the type of external system and the external resource identifier that
    /// identifies your account or instance in that system.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/integrate-infoblox-ipam.html">Integrate
    /// VPC IPAM with Infoblox infrastructure</a> in the <i>Amazon VPC IPAM User Guide</i>..
    /// </para>
    /// </summary>
    public partial class ExternalAuthorityConfiguration
    {
        private string _externalResourceIdentifier;
        private IpamScopeExternalAuthorityType _type;

        /// <summary>
        /// Gets and sets the property ExternalResourceIdentifier. 
        /// <para>
        /// The identifier for the external resource managing this scope. For Infoblox integrations,
        /// this is the Infoblox resource identifier in the format <c>&lt;version&gt;.identity.account.&lt;entity_realm&gt;.&lt;entity_id&gt;</c>.
        /// </para>
        /// </summary>
        public string ExternalResourceIdentifier
        {
            get { return this._externalResourceIdentifier; }
            set { this._externalResourceIdentifier = value; }
        }

        // Check to see if ExternalResourceIdentifier property is set
        internal bool IsSetExternalResourceIdentifier()
        {
            return this._externalResourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of external authority.
        /// </para>
        /// </summary>
        public IpamScopeExternalAuthorityType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}