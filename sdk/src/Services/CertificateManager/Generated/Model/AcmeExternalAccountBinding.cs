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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains detailed information about an ACME external account binding.
    /// </summary>
    public partial class AcmeExternalAccountBinding
    {
        private string _acmeEndpointArn;
        private string _acmeExternalAccountBindingArn;
        private DateTime? _createdAt;
        private DateTime? _expiresAt;
        private DateTime? _lastUsedAt;
        private DateTime? _revokedAt;
        private string _roleArn;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string AcmeEndpointArn
        {
            get { return this._acmeEndpointArn; }
            set { this._acmeEndpointArn = value; }
        }

        // Check to see if AcmeEndpointArn property is set
        internal bool IsSetAcmeEndpointArn()
        {
            return this._acmeEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property AcmeExternalAccountBindingArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME external account binding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string AcmeExternalAccountBindingArn
        {
            get { return this._acmeExternalAccountBindingArn; }
            set { this._acmeExternalAccountBindingArn = value; }
        }

        // Check to see if AcmeExternalAccountBindingArn property is set
        internal bool IsSetAcmeExternalAccountBindingArn()
        {
            return this._acmeExternalAccountBindingArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the external account binding was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The time at which the external account binding expires.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUsedAt. 
        /// <para>
        /// The time at which the external account binding was last used.
        /// </para>
        /// </summary>
        public DateTime? LastUsedAt
        {
            get { return this._lastUsedAt; }
            set { this._lastUsedAt = value; }
        }

        // Check to see if LastUsedAt property is set
        internal bool IsSetLastUsedAt()
        {
            return this._lastUsedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The time at which the external account binding was revoked.
        /// </para>
        /// </summary>
        public DateTime? RevokedAt
        {
            get { return this._revokedAt; }
            set { this._revokedAt = value; }
        }

        // Check to see if RevokedAt property is set
        internal bool IsSetRevokedAt()
        {
            return this._revokedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the external account
        /// binding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the external account binding was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}