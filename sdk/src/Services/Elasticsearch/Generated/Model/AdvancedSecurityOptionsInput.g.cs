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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies the advanced security configuration: whether advanced security is enabled,
    /// whether the internal database option is enabled, master username and password (if
    /// internal database is enabled), and master user ARN (if IAM is enabled).
    /// </summary>
    public partial class AdvancedSecurityOptionsInput
    {
        /// <summary>
        /// Gets and sets the property AnonymousAuthEnabled. 
        /// <para>
        /// True if Anonymous auth is enabled. Anonymous auth can be enabled only when AdvancedSecurity
        /// is enabled on existing domains.
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
        /// True if advanced security is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

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
        /// Gets and sets the property MasterUserOptions. 
        /// <para>
        /// Credentials for the master user: username and password, ARN, or both.
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
        /// Specifies the SAML application configuration for the domain.
        /// </para>
        /// </summary>
        public SAMLOptionsInput SAMLOptions { get; set; }

        /// <summary>
        /// Checks to see if the SAMLOptions property is set.
        /// </summary>
        internal bool IsSetSAMLOptions() => this.SAMLOptions != null;
    }
}
