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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Options for enabling and configuring fine-grained access control. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/fgac.html">Fine-grained
    /// access control in Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class AdvancedSecurityOptionsInput
    {
        private bool? _anonymousAuthEnabled;
        private bool? _enabled;
        private bool? _internalUserDatabaseEnabled;
        private MasterUserOptions _masterUserOptions;
        private SAMLOptionsInput _samlOptions;

        /// <summary>
        /// Gets and sets the property AnonymousAuthEnabled. 
        /// <para>
        /// True to enable a 30-day migration period during which administrators can create role
        /// mappings. Only necessary when <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/fgac.html#fgac-enabling-existing">enabling
        /// fine-grained access control on an existing domain</a>.
        /// </para>
        /// </summary>
        public bool AnonymousAuthEnabled
        {
            get { return this._anonymousAuthEnabled.GetValueOrDefault(); }
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
        /// True to enable fine-grained access control.
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
        /// Gets and sets the property InternalUserDatabaseEnabled. 
        /// <para>
        /// True to enable the internal user database.
        /// </para>
        /// </summary>
        public bool InternalUserDatabaseEnabled
        {
            get { return this._internalUserDatabaseEnabled.GetValueOrDefault(); }
            set { this._internalUserDatabaseEnabled = value; }
        }

        // Check to see if InternalUserDatabaseEnabled property is set
        internal bool IsSetInternalUserDatabaseEnabled()
        {
            return this._internalUserDatabaseEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUserOptions. 
        /// <para>
        /// Container for information about the master user.
        /// </para>
        /// </summary>
        public MasterUserOptions MasterUserOptions
        {
            get { return this._masterUserOptions; }
            set { this._masterUserOptions = value; }
        }

        // Check to see if MasterUserOptions property is set
        internal bool IsSetMasterUserOptions()
        {
            return this._masterUserOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SAMLOptions. 
        /// <para>
        /// Container for information about the SAML configuration for OpenSearch Dashboards.
        /// </para>
        /// </summary>
        public SAMLOptionsInput SAMLOptions
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