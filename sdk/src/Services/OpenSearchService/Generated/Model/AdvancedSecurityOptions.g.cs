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
    /// Container for fine-grained access control settings.
    /// </summary>
    public partial class AdvancedSecurityOptions
    {
        /// <summary>
        /// Gets and sets the property AnonymousAuthDisableDate. 
        /// <para>
        /// Date and time when the migration period will be disabled. Only necessary when <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/fgac.html#fgac-enabling-existing">enabling
        /// fine-grained access control on an existing domain</a>.
        /// </para>
        /// </summary>
        public DateTime? AnonymousAuthDisableDate { get; set; }

        /// <summary>
        /// Checks to see if the AnonymousAuthDisableDate property is set.
        /// </summary>
        internal bool IsSetAnonymousAuthDisableDate() => this.AnonymousAuthDisableDate.HasValue;

        /// <summary>
        /// Gets and sets the property AnonymousAuthEnabled. 
        /// <para>
        /// True if a 30-day migration period is enabled, during which administrators can create
        /// role mappings. Only necessary when <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/fgac.html#fgac-enabling-existing">enabling
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
        /// True if fine-grained access control is enabled.
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
        /// Configuration options for IAM identity federation in advanced security settings.
        /// </para>
        /// </summary>
        public IAMFederationOptionsOutput IAMFederationOptions { get; set; }

        /// <summary>
        /// Checks to see if the IAMFederationOptions property is set.
        /// </summary>
        internal bool IsSetIAMFederationOptions() => this.IAMFederationOptions != null;

        /// <summary>
        /// Gets and sets the property InternalUserDatabaseEnabled. 
        /// <para>
        /// True if the internal user database is enabled.
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
        /// </para>
        /// </summary>
        public JWTOptionsOutput JWTOptions { get; set; }

        /// <summary>
        /// Checks to see if the JWTOptions property is set.
        /// </summary>
        internal bool IsSetJWTOptions() => this.JWTOptions != null;

        /// <summary>
        /// Gets and sets the property SAMLOptions. 
        /// <para>
        /// Container for information about the SAML configuration for OpenSearch Dashboards.
        /// </para>
        /// </summary>
        public SAMLOptionsOutput SAMLOptions { get; set; }

        /// <summary>
        /// Checks to see if the SAMLOptions property is set.
        /// </summary>
        internal bool IsSetSAMLOptions() => this.SAMLOptions != null;
    }
}
