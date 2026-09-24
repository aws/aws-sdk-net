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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the email names for
        /// SAML users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the user full "friendly"
        /// names for user groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Groups { get; set; }

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null;

        /// <summary>
        /// Gets and sets the property Login. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the login names for
        /// SAML users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Login { get; set; }

        /// <summary>
        /// Checks to see if the Login property is set.
        /// </summary>
        internal bool IsSetLogin() => this.Login != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the user full "friendly"
        /// names for SAML users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Org. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the user full "friendly"
        /// names for the users' organizations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Org { get; set; }

        /// <summary>
        /// Checks to see if the Org property is set.
        /// </summary>
        internal bool IsSetOrg() => this.Org != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The name of the attribute within the SAML assertion to use as the user roles.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;
    }
}
