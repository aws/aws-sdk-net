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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The policy grant principal.
    /// </summary>
    public partial class PolicyGrantPrincipal
    {
        private DomainUnitPolicyGrantPrincipal _domainUnit;
        private GroupPolicyGrantPrincipal _group;
        private ProjectPolicyGrantPrincipal _project;
        private UserPolicyGrantPrincipal _user;

        /// <summary>
        /// Gets and sets the property DomainUnit. 
        /// <para>
        /// The domain unit of the policy grant principal.
        /// </para>
        /// </summary>
        public DomainUnitPolicyGrantPrincipal DomainUnit
        {
            get { return this._domainUnit; }
            set { this._domainUnit = value; }
        }

        // Check to see if DomainUnit property is set
        internal bool IsSetDomainUnit()
        {
            return this._domainUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The group of the policy grant principal.
        /// </para>
        /// </summary>
        public GroupPolicyGrantPrincipal Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The project of the policy grant principal.
        /// </para>
        /// </summary>
        public ProjectPolicyGrantPrincipal Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user of the policy grant principal.
        /// </para>
        /// </summary>
        public UserPolicyGrantPrincipal User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}