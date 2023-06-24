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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// A studio member is an association of a user from your studio identity source to elevated
    /// permissions that they are granted in the studio.
    /// 
    ///  
    /// <para>
    /// When you add a user to your studio using the Nimble Studio console, they are given
    /// access to the studio's IAM Identity Center application and are given access to log
    /// in to the Nimble Studio portal. These users have the permissions provided by the studio's
    /// user IAM role and do not appear in the studio membership collection. Only studio admins
    /// appear in studio membership.
    /// </para>
    ///  
    /// <para>
    /// When you add a user to studio membership with the ADMIN persona, upon logging in to
    /// the Nimble Studio portal, they are granted permissions specified by the Studio's Admin
    /// IAM role.
    /// </para>
    /// </summary>
    public partial class StudioMembership
    {
        private string _identityStoreId;
        private StudioPersona _persona;
        private string _principalId;
        private string _sid;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The ID of the identity store.
        /// </para>
        /// </summary>
        public string IdentityStoreId
        {
            get { return this._identityStoreId; }
            set { this._identityStoreId = value; }
        }

        // Check to see if IdentityStoreId property is set
        internal bool IsSetIdentityStoreId()
        {
            return this._identityStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property Persona. 
        /// <para>
        /// The persona.
        /// </para>
        /// </summary>
        public StudioPersona Persona
        {
            get { return this._persona; }
            set { this._persona = value; }
        }

        // Check to see if Persona property is set
        internal bool IsSetPersona()
        {
            return this._persona != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The principal ID.
        /// </para>
        /// </summary>
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

        /// <summary>
        /// Gets and sets the property Sid. 
        /// <para>
        /// The Active Directory Security Identifier for this user, if available.
        /// </para>
        /// </summary>
        public string Sid
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if Sid property is set
        internal bool IsSetSid()
        {
            return this._sid != null;
        }

    }
}