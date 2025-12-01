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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// A mapping between an Argo CD role and IAM Identity CenterIAM; Identity Center identities.
    /// This defines which users or groups have specific permissions in Argo CD.
    /// </summary>
    public partial class ArgoCdRoleMapping
    {
        private List<SsoIdentity> _identities = AWSConfigs.InitializeCollections ? new List<SsoIdentity>() : null;
        private ArgoCdRole _role;

        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// A list of IAM Identity CenterIAM; Identity Center identities (users or groups) that
        /// should be assigned this Argo CD role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SsoIdentity> Identities
        {
            get { return this._identities; }
            set { this._identities = value; }
        }

        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this._identities != null && (this._identities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Argo CD role to assign. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ADMIN</c> – Full administrative access to Argo CD.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EDITOR</c> – Edit access to Argo CD resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VIEWER</c> – Read-only access to Argo CD resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArgoCdRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}