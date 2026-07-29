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
    /// Container for the parameters to the CreateAcmeExternalAccountBinding operation.
    /// Creates an external account binding (EAB) for an ACME endpoint. An EAB provides credentials
    /// that authorize an ACME client to register an account with the endpoint. Each EAB is
    /// associated with an IAM role that controls what certificate operations the ACME client
    /// can perform.
    /// </summary>
    public partial class CreateAcmeExternalAccountBindingRequest : AmazonCertificateManagerRequest
    {
        private string _acmeEndpointArn;
        private Expiration _expiration;
        private string _idempotencyToken;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The expiration configuration for the external account binding.
        /// </para>
        /// </summary>
        public Expiration Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to associate with the external account
        /// binding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to associate with the external account binding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}