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
    /// Specifies the advanced security configuration: whether advanced security is enabled,
    /// whether the internal database option is enabled.
    /// </summary>
    public partial class AdvancedSecurityOptions
    {
        private DateTime? _anonymousAuthDisableDate;
        private bool? _anonymousAuthEnabled;
        private bool? _enabled;
        private bool? _internalUserDatabaseEnabled;
        private SAMLOptionsOutput _samlOptions;

        /// <summary>
        /// Gets and sets the property AnonymousAuthDisableDate. 
        /// <para>
        /// Specifies the Anonymous Auth Disable Date when Anonymous Auth is enabled.
        /// </para>
        /// </summary>
        public DateTime? AnonymousAuthDisableDate
        {
            get { return this._anonymousAuthDisableDate; }
            set { this._anonymousAuthDisableDate = value; }
        }

        // Check to see if AnonymousAuthDisableDate property is set
        internal bool IsSetAnonymousAuthDisableDate()
        {
            return this._anonymousAuthDisableDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AnonymousAuthEnabled. 
        /// <para>
        /// True if Anonymous auth is enabled. Anonymous auth can be enabled only when AdvancedSecurity
        /// is enabled on existing domains.
        /// </para>
        /// </summary>
        public bool? AnonymousAuthEnabled
        {
            get { return this._anonymousAuthEnabled; }
            set { this._anonymousAuthEnabled = value; }
        }

        // Check to see if AnonymousAuthEnabled property is set
        internal bool IsSetAnonymousAuthEnabled()
        {
            return this._anonymousAuthEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True if advanced security is enabled.
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
        /// Gets and sets the property InternalUserDatabaseEnabled. 
        /// <para>
        /// True if the internal user database is enabled.
        /// </para>
        /// </summary>
        public bool? InternalUserDatabaseEnabled
        {
            get { return this._internalUserDatabaseEnabled; }
            set { this._internalUserDatabaseEnabled = value; }
        }

        // Check to see if InternalUserDatabaseEnabled property is set
        internal bool IsSetInternalUserDatabaseEnabled()
        {
            return this._internalUserDatabaseEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SAMLOptions. 
        /// <para>
        /// Describes the SAML application configured for a domain.
        /// </para>
        /// </summary>
        public SAMLOptionsOutput SAMLOptions
        {
            get { return this._samlOptions; }
            set { this._samlOptions = value; }
        }

        // Check to see if SAMLOptions property is set
        internal bool IsSetSAMLOptions()
        {
            return this._samlOptions != null;
        }

    }
}