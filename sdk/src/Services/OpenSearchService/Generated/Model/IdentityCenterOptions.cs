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
    /// Settings container for integrating IAM Identity Center with OpenSearch UI applications,
    /// which enables enabling secure user authentication and access control across multiple
    /// data sources. This setup supports single sign-on (SSO) through IAM Identity Center,
    /// allowing centralized user management.
    /// </summary>
    public partial class IdentityCenterOptions
    {
        private bool? _enabledAPIAccess;
        private string _identityCenterApplicationARN;
        private string _identityCenterInstanceARN;
        private string _identityStoreId;
        private RolesKeyIdCOption _rolesKey;
        private SubjectKeyIdCOption _subjectKey;

        /// <summary>
        /// Gets and sets the property EnabledAPIAccess. 
        /// <para>
        /// Indicates whether IAM Identity Center is enabled for the application.
        /// </para>
        /// </summary>
        public bool? EnabledAPIAccess
        {
            get { return this._enabledAPIAccess; }
            set { this._enabledAPIAccess = value; }
        }

        // Check to see if EnabledAPIAccess property is set
        internal bool IsSetEnabledAPIAccess()
        {
            return this._enabledAPIAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationARN. 
        /// <para>
        /// The ARN of the IAM Identity Center application that integrates with Amazon OpenSearch
        /// Service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IdentityCenterApplicationARN
        {
            get { return this._identityCenterApplicationARN; }
            set { this._identityCenterApplicationARN = value; }
        }

        // Check to see if IdentityCenterApplicationARN property is set
        internal bool IsSetIdentityCenterApplicationARN()
        {
            return this._identityCenterApplicationARN != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IdentityCenterInstanceARN
        {
            get { return this._identityCenterInstanceARN; }
            set { this._identityCenterInstanceARN = value; }
        }

        // Check to see if IdentityCenterInstanceARN property is set
        internal bool IsSetIdentityCenterInstanceARN()
        {
            return this._identityCenterInstanceARN != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The identifier of the IAM Identity Store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string IdentityStoreId
        {
            get { return this._identityStoreId; }
            set { this._identityStoreId = value; }
        }

        // Check to see if IdentityStoreId property is set
        internal bool IsSetIdentityStoreId()
        {
            return this._identityStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property RolesKey. 
        /// <para>
        /// Specifies the attribute that contains the backend role identifier (such as group name
        /// or group ID) in IAM Identity Center.
        /// </para>
        /// </summary>
        public RolesKeyIdCOption RolesKey
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
        /// Specifies the attribute that contains the subject identifier (such as username, user
        /// ID, or email) in IAM Identity Center.
        /// </para>
        /// </summary>
        public SubjectKeyIdCOption SubjectKey
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