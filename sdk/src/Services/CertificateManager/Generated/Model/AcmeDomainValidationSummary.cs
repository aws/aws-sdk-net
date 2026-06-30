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
    /// Contains summary information about an ACME domain validation.
    /// </summary>
    public partial class AcmeDomainValidationSummary
    {
        private string _acmeDomainValidationArn;
        private string _acmeEndpointArn;
        private DateTime? _createdAt;
        private string _domainName;
        private FailureDetails _failureDetails;
        private PrevalidationDetails _prevalidationDetails;
        private PrevalidationType _prevalidationType;
        private AcmeDomainValidationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AcmeDomainValidationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME domain validation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string AcmeDomainValidationArn
        {
            get { return this._acmeDomainValidationArn; }
            set { this._acmeDomainValidationArn = value; }
        }

        // Check to see if AcmeDomainValidationArn property is set
        internal bool IsSetAcmeDomainValidationArn()
        {
            return this._acmeDomainValidationArn != null;
        }

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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the domain validation was created.
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name being validated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
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
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Details about the failure, if the validation failed.
        /// </para>
        /// </summary>
        public FailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PrevalidationDetails. 
        /// <para>
        /// Details about the prevalidation configuration.
        /// </para>
        /// </summary>
        public PrevalidationDetails PrevalidationDetails
        {
            get { return this._prevalidationDetails; }
            set { this._prevalidationDetails = value; }
        }

        // Check to see if PrevalidationDetails property is set
        internal bool IsSetPrevalidationDetails()
        {
            return this._prevalidationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PrevalidationType. 
        /// <para>
        /// The type of prevalidation used.
        /// </para>
        /// </summary>
        public PrevalidationType PrevalidationType
        {
            get { return this._prevalidationType; }
            set { this._prevalidationType = value; }
        }

        // Check to see if PrevalidationType property is set
        internal bool IsSetPrevalidationType()
        {
            return this._prevalidationType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the domain validation.
        /// </para>
        /// </summary>
        public AcmeDomainValidationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the domain validation was last updated.
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