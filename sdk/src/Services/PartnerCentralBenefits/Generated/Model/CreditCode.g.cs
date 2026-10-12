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

namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Represents an AWS credit code that can be applied to an AWS account for billing purposes.
    /// </summary>
    public partial class CreditCode
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID that the credit code is associated with or can be applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsCreditCode. 
        /// <para>
        /// The actual credit code string that can be redeemed in the AWS billing console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AwsCreditCode { get; set; }

        /// <summary>
        /// Checks to see if the AwsCreditCode property is set.
        /// </summary>
        internal bool IsSetAwsCreditCode() => this.AwsCreditCode != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the credit code expires and can no longer be redeemed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The timestamp when the credit code was issued.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the credit code (e.g., active, redeemed, expired).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BenefitAllocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The monetary value of the credit code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonetaryValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
