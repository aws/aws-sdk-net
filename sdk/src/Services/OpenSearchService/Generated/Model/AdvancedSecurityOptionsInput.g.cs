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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Options for enabling and configuring fine-grained access control. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/fgac.html">Fine-grained
    /// access control in Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class AdvancedSecurityOptionsInput
    {
        /// <summary>
        /// Gets and sets the property AnonymousAuthEnabled. 
        /// <para>
        /// True to enable a 30-day migration period during which administrators can create role
        /// mappings. Only necessary when <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/fgac.html#fgac-enabling-existing">enabling
        /// fine-grained access control on an existing domain</a>.
        /// </para>
        /// </summary>
        public bool? AnonymousAuthEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AnonymousAuthEnabled property is set.
        /// </summary>
        internal bool IsSetAnonymousAuthEnabled() => this.AnonymousAuthEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True to enable fine-grained access control.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property IAMFederationOptions. 
        /// <para>
        /// Input configuration for IAM identity federation within advanced security options.
        /// </para>
        /// </summary>
        public IAMFederationOptionsInput IAMFederationOptions { get; set; }

        /// <summary>
        /// Checks to see if the IAMFederationOptions property is set.
        /// </summary>
        internal bool IsSetIAMFederationOptions() => this.IAMFederationOptions != null;

        /// <summary>
        /// Gets and sets the property InternalUserDatabaseEnabled. 
        /// <para>
        /// True to enable the internal user database.
        /// </para>
        /// </summary>
        public bool? InternalUserDatabaseEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InternalUserDatabaseEnabled property is set.
        /// </summary>
        internal bool IsSetInternalUserDatabaseEnabled() => this.InternalUserDatabaseEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property JWTOptions. 
        /// <para>
        /// Container for information about the JWT configuration of the Amazon OpenSearch Service.
        /// 
        /// </para>
        /// </summary>
        public JWTOptionsInput JWTOptions { get; set; }

        /// <summary>
        /// Checks to see if the JWTOptions property is set.
        /// </summary>
        internal bool IsSetJWTOptions() => this.JWTOptions != null;

        /// <summary>
        /// Gets and sets the property MasterUserOptions. 
        /// <para>
        /// Container for information about the master user.
        /// </para>
        /// </summary>
        public MasterUserOptions MasterUserOptions { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserOptions property is set.
        /// </summary>
        internal bool IsSetMasterUserOptions() => this.MasterUserOptions != null;

        /// <summary>
        /// Gets and sets the property SAMLOptions. 
        /// <para>
        /// Container for information about the SAML configuration for OpenSearch Dashboards.
        /// </para>
        /// </summary>
        public SAMLOptionsInput SAMLOptions { get; set; }

        /// <summary>
        /// Checks to see if the SAMLOptions property is set.
        /// </summary>
        internal bool IsSetSAMLOptions() => this.SAMLOptions != null;
    }
}
