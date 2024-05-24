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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
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
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// A structure that defines which attributes in the IdP assertion are to be used to define
    /// information about the users authenticated by the IdP to use the workspace.
    /// </summary>
    public partial class AssertionAttributes
    {
        private string _email;
        private string _groups;
        private string _login;
        private string _name;
        private string _org;
        private string _role;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the email names for
        /// SAML users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the user full "friendly"
        /// names for user groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null;
        }

        /// <summary>
        /// Gets and sets the property Login. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the login names for
        /// SAML users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Login
        {
            get { return this._login; }
            set { this._login = value; }
        }

        // Check to see if Login property is set
        internal bool IsSetLogin()
        {
            return this._login != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the user full "friendly"
        /// names for SAML users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Org. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the user full "friendly"
        /// names for the users' organizations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Org
        {
            get { return this._org; }
            set { this._org = value; }
        }

        // Check to see if Org property is set
        internal bool IsSetOrg()
        {
            return this._org != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the user roles.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Role
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