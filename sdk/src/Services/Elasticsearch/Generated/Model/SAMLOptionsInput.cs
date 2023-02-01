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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies the SAML application configuration for the domain.
    /// </summary>
    public partial class SAMLOptionsInput
    {
        private bool? _enabled;
        private SAMLIdp _idp;
        private string _masterBackendRole;
        private string _masterUserName;
        private string _rolesKey;
        private int? _sessionTimeoutMinutes;
        private string _subjectKey;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True if SAML is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
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
        /// Specifies the SAML Identity Provider's information.
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
        /// Gets and sets the property MasterBackendRole. 
        /// <para>
        /// The backend role to which the SAML master user is mapped to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MasterBackendRole
        {
            get { return this._masterBackendRole; }
            set { this._masterBackendRole = value; }
        }

        // Check to see if MasterBackendRole property is set
        internal bool IsSetMasterBackendRole()
        {
            return this._masterBackendRole != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserName. 
        /// <para>
        /// The SAML master username, which is stored in the Amazon Elasticsearch Service domain's
        /// internal database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string MasterUserName
        {
            get { return this._masterUserName; }
            set { this._masterUserName = value; }
        }

        // Check to see if MasterUserName property is set
        internal bool IsSetMasterUserName()
        {
            return this._masterUserName != null;
        }

        /// <summary>
        /// Gets and sets the property RolesKey. 
        /// <para>
        /// The key to use for matching the SAML Roles attribute.
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
        /// The duration, in minutes, after which a user session becomes inactive. Acceptable
        /// values are between 1 and 1440, and the default value is 60.
        /// </para>
        /// </summary>
        public int SessionTimeoutMinutes
        {
            get { return this._sessionTimeoutMinutes.GetValueOrDefault(); }
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
        /// The key to use for matching the SAML Subject attribute.
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