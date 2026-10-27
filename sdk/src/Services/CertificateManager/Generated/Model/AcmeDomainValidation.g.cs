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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains detailed information about an ACME domain validation.
    /// </summary>
    public partial class AcmeDomainValidation
    {
        /// <summary>
        /// Gets and sets the property AcmeDomainValidationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME domain validation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string AcmeDomainValidationArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmeDomainValidationArn property is set.
        /// </summary>
        internal bool IsSetAcmeDomainValidationArn() => this.AcmeDomainValidationArn != null;

        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string AcmeEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmeEndpointArn property is set.
        /// </summary>
        internal bool IsSetAcmeEndpointArn() => this.AcmeEndpointArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the domain validation was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name being validated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Details about the failure, if the validation failed.
        /// </para>
        /// </summary>
        public FailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property PrevalidationDetails. 
        /// <para>
        /// Details about the prevalidation configuration.
        /// </para>
        /// </summary>
        public PrevalidationDetails PrevalidationDetails { get; set; }

        /// <summary>
        /// Checks to see if the PrevalidationDetails property is set.
        /// </summary>
        internal bool IsSetPrevalidationDetails() => this.PrevalidationDetails != null;

        /// <summary>
        /// Gets and sets the property PrevalidationType. 
        /// <para>
        /// The type of prevalidation used.
        /// </para>
        /// </summary>
        public PrevalidationType PrevalidationType { get; set; }

        /// <summary>
        /// Checks to see if the PrevalidationType property is set.
        /// </summary>
        internal bool IsSetPrevalidationType() => this.PrevalidationType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the domain validation.
        /// </para>
        /// </summary>
        public AcmeDomainValidationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the domain validation was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
