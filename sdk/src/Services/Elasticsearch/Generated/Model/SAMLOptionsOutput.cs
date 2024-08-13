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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Describes the SAML application configured for the domain.
    /// </summary>
    public partial class SAMLOptionsOutput
    {
        private bool? _enabled;
        private SAMLIdp _idp;
        private string _rolesKey;
        private int? _sessionTimeoutMinutes;
        private string _subjectKey;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True if SAML is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Idp. 
        /// <para>
        /// Describes the SAML Identity Provider's information.
        /// </para>
        /// </summary>
        public SAMLIdp Idp
        {
            get { return this._idp; }
            set { this._idp = value; }
        }

        // Check to see if Idp property is set
        internal bool IsSetIdp()
        {
            return this._idp != null;
        }

        /// <summary>
        /// Gets and sets the property RolesKey. 
        /// <para>
        /// The key used for matching the SAML Roles attribute.
        /// </para>
        /// </summary>
        public string RolesKey
        {
            get { return this._rolesKey; }
            set { this._rolesKey = value; }
        }

        // Check to see if RolesKey property is set
        internal bool IsSetRolesKey()
        {
            return this._rolesKey != null;
        }

        /// <summary>
        /// Gets and sets the property SessionTimeoutMinutes. 
        /// <para>
        /// The duration, in minutes, after which a user session becomes inactive.
        /// </para>
        /// </summary>
        public int? SessionTimeoutMinutes
        {
            get { return this._sessionTimeoutMinutes; }
            set { this._sessionTimeoutMinutes = value; }
        }

        // Check to see if SessionTimeoutMinutes property is set
        internal bool IsSetSessionTimeoutMinutes()
        {
            return this._sessionTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubjectKey. 
        /// <para>
        /// The key used for matching the SAML Subject attribute.
        /// </para>
        /// </summary>
        public string SubjectKey
        {
            get { return this._subjectKey; }
            set { this._subjectKey = value; }
        }

        // Check to see if SubjectKey property is set
        internal bool IsSetSubjectKey()
        {
            return this._subjectKey != null;
        }

    }
}