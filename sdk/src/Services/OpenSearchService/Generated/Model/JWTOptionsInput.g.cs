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
    /// The JWT authentication and authorization configuration for an Amazon OpenSearch Service
    /// domain.
    /// </summary>
    public partial class JWTOptionsInput
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True to enable JWT authentication and authorization for a domain.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property JwksUrl. 
        /// <para>
        /// The URL endpoint that hosts the JSON Web Key Set (JWKS) containing public keys used
        /// to verify JWT signatures.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string JwksUrl { get; set; }

        /// <summary>
        /// Checks to see if the JwksUrl property is set.
        /// </summary>
        internal bool IsSetJwksUrl() => this.JwksUrl != null;

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// Element of the JWT assertion used by the cluster to verify JWT signatures.
        /// </para>
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Checks to see if the PublicKey property is set.
        /// </summary>
        internal bool IsSetPublicKey() => this.PublicKey != null;

        /// <summary>
        /// Gets and sets the property RolesKey. 
        /// <para>
        /// Element of the JWT assertion to use for roles.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RolesKey { get; set; }

        /// <summary>
        /// Checks to see if the RolesKey property is set.
        /// </summary>
        internal bool IsSetRolesKey() => this.RolesKey != null;

        /// <summary>
        /// Gets and sets the property SubjectKey. 
        /// <para>
        /// Element of the JWT assertion to use for the user name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SubjectKey { get; set; }

        /// <summary>
        /// Checks to see if the SubjectKey property is set.
        /// </summary>
        internal bool IsSetSubjectKey() => this.SubjectKey != null;
    }
}
