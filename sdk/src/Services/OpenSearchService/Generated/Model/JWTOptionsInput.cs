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
    /// The JWT authentication and authorization configuration for an Amazon OpenSearch Service
    /// domain.
    /// </summary>
    public partial class JWTOptionsInput
    {
        private bool? _enabled;
        private string _publicKey;
        private string _rolesKey;
        private string _subjectKey;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True to enable JWT authentication and authorization for a domain.
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
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// Element of the JWT assertion used by the cluster to verify JWT signatures.
        /// </para>
        /// </summary>
        public string PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

        /// <summary>
        /// Gets and sets the property RolesKey. 
        /// <para>
        /// Element of the JWT assertion to use for roles.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property SubjectKey. 
        /// <para>
        /// Element of the JWT assertion to use for the user name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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