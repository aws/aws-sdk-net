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
    /// Container for the parameters to the CreateAcmeDomainValidation operation.
    /// Creates a domain validation for an ACME endpoint. Domain validations authorize the
    /// endpoint to issue certificates for specified domain names. You configure prevalidation
    /// to prove domain ownership.
    /// </summary>
    public partial class CreateAcmeDomainValidationRequest : AmazonCertificateManagerRequest
    {
        private string _acmeEndpointArn;
        private string _domainName;
        private string _idempotencyToken;
        private PrevalidationOptions _prevalidationOptions;
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name to validate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=253)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
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
        /// Gets and sets the property PrevalidationOptions. 
        /// <para>
        /// The prevalidation options for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrevalidationOptions PrevalidationOptions
        {
            get { return this._prevalidationOptions; }
            set { this._prevalidationOptions = value; }
        }

        // Check to see if PrevalidationOptions property is set
        internal bool IsSetPrevalidationOptions()
        {
            return this._prevalidationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to associate with the domain validation.
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