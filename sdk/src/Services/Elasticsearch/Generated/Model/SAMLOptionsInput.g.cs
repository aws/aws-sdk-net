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
    /// Specifies the SAML application configuration for the domain.
    /// </summary>
    public partial class SAMLOptionsInput
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True if SAML is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Idp. 
        /// <para>
        /// Specifies the SAML Identity Provider's information.
        /// </para>
        /// </summary>
        public SAMLIdp Idp { get; set; }

        /// <summary>
        /// Checks to see if the Idp property is set.
        /// </summary>
        internal bool IsSetIdp() => this.Idp != null;

        /// <summary>
        /// Gets and sets the property MasterBackendRole. 
        /// <para>
        /// The backend role to which the SAML master user is mapped to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MasterBackendRole { get; set; }

        /// <summary>
        /// Checks to see if the MasterBackendRole property is set.
        /// </summary>
        internal bool IsSetMasterBackendRole() => this.MasterBackendRole != null;

        /// <summary>
        /// Gets and sets the property MasterUserName. 
        /// <para>
        /// The SAML master username, which is stored in the Amazon Elasticsearch Service domain's
        /// internal database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string MasterUserName { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserName property is set.
        /// </summary>
        internal bool IsSetMasterUserName() => this.MasterUserName != null;

        /// <summary>
        /// Gets and sets the property RolesKey. 
        /// <para>
        /// The key to use for matching the SAML Roles attribute.
        /// </para>
        /// </summary>
        public string RolesKey { get; set; }

        /// <summary>
        /// Checks to see if the RolesKey property is set.
        /// </summary>
        internal bool IsSetRolesKey() => this.RolesKey != null;

        /// <summary>
        /// Gets and sets the property SessionTimeoutMinutes. 
        /// <para>
        /// The duration, in minutes, after which a user session becomes inactive. Acceptable
        /// values are between 1 and 1440, and the default value is 60.
        /// </para>
        /// </summary>
        public int? SessionTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the SessionTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetSessionTimeoutMinutes() => this.SessionTimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property SubjectKey. 
        /// <para>
        /// The key to use for matching the SAML Subject attribute.
        /// </para>
        /// </summary>
        public string SubjectKey { get; set; }

        /// <summary>
        /// Checks to see if the SubjectKey property is set.
        /// </summary>
        internal bool IsSetSubjectKey() => this.SubjectKey != null;
    }
}
