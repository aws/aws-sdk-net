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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// This is the response object from the VerifyTargetDomain operation.
    /// </summary>
    public partial class VerifyTargetDomainResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the target domain was created, in UTC format.
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
        /// The domain name of the target domain.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The verification status of the target domain.
        /// </para>
        /// </summary>
        public TargetDomainStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetDomainId. 
        /// <para>
        /// The unique identifier of the target domain.
        /// </para>
        /// </summary>
        public string TargetDomainId { get; set; }

        /// <summary>
        /// Checks to see if the TargetDomainId property is set.
        /// </summary>
        internal bool IsSetTargetDomainId() => this.TargetDomainId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the target domain was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VerificationStatusReason. 
        /// <para>
        /// The reason for the current target domain verification status.
        /// </para>
        /// </summary>
        public string VerificationStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the VerificationStatusReason property is set.
        /// </summary>
        internal bool IsSetVerificationStatusReason() => this.VerificationStatusReason != null;

        /// <summary>
        /// Gets and sets the property VerifiedAt. 
        /// <para>
        /// The date and time the target domain was verified, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? VerifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAt property is set.
        /// </summary>
        internal bool IsSetVerifiedAt() => this.VerifiedAt.HasValue;
    }
}
