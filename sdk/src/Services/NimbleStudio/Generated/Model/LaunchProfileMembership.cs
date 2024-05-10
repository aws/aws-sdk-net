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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Studio admins can use launch profile membership to delegate launch profile access
    /// to studio users in the Nimble Studio portal without writing or maintaining complex
    /// IAM policies. A launch profile member is a user association from your studio identity
    /// source who is granted permissions to a launch profile.
    /// 
    ///  
    /// <para>
    /// A launch profile member (type USER) provides the following permissions to that launch
    /// profile:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// GetLaunchProfile
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GetLaunchProfileInitialization
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GetLaunchProfileMembers
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GetLaunchProfileMember
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CreateStreamingSession
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GetLaunchProfileDetails
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LaunchProfileMembership
    {
        private string _identityStoreId;
        private LaunchProfilePersona _persona;
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
        public LaunchProfilePersona Persona
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