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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for fine-grained access control settings.
    /// </summary>
    public partial class AdvancedSecurityOptions
    {
        private DateTime? _anonymousAuthDisableDate;
        private bool? _anonymousAuthEnabled;
        private bool? _enabled;
        private IAMFederationOptionsOutput _iamFederationOptions;
        private bool? _internalUserDatabaseEnabled;
        private JWTOptionsOutput _jwtOptions;
        private SAMLOptionsOutput _samlOptions;

        /// <summary>
        /// Gets and sets the property AnonymousAuthDisableDate. 
        /// <para>
        /// Date and time when the migration period will be disabled. Only necessary when <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/fgac.html#fgac-enabling-existing">enabling
        /// fine-grained access control on an existing domain</a>.
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
        /// True if a 30-day migration period is enabled, during which administrators can create
        /// role mappings. Only necessary when <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/fgac.html#fgac-enabling-existing">enabling
        /// fine-grained access control on an existing domain</a>.
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
        /// True if fine-grained access control is enabled.
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
        /// Gets and sets the property IAMFederationOptions. 
        /// <para>
        /// Container for information about the IAM federation configuration for an OpenSearch
        /// UI application.
        /// </para>
        /// </summary>
        public IAMFederationOptionsOutput IAMFederationOptions
        {
            get { return this._iamFederationOptions; }
            set { this._iamFederationOptions = value; }
        }

        // Check to see if IAMFederationOptions property is set
        internal bool IsSetIAMFederationOptions()
        {
            return this._iamFederationOptions != null;
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
        /// Gets and sets the property JWTOptions. 
        /// <para>
        /// Container for information about the JWT configuration of the Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public JWTOptionsOutput JWTOptions
        {
            get { return this._jwtOptions; }
            set { this._jwtOptions = value; }
        }

        // Check to see if JWTOptions property is set
        internal bool IsSetJWTOptions()
        {
            return this._jwtOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SAMLOptions. 
        /// <para>
        /// Container for information about the SAML configuration for OpenSearch Dashboards.
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