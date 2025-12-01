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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
        private string _awsAccountId;
        private string _awsCreditCode;
        private DateTime? _expiresAt;
        private DateTime? _issuedAt;
        private BenefitAllocationStatus _status;
        private MonetaryValue _value;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID that the credit code is associated with or can be applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsCreditCode. 
        /// <para>
        /// The actual credit code string that can be redeemed in the AWS billing console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AwsCreditCode
        {
            get { return this._awsCreditCode; }
            set { this._awsCreditCode = value; }
        }

        // Check to see if AwsCreditCode property is set
        internal bool IsSetAwsCreditCode()
        {
            return this._awsCreditCode != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the credit code expires and can no longer be redeemed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The timestamp when the credit code was issued.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? IssuedAt
        {
            get { return this._issuedAt; }
            set { this._issuedAt = value; }
        }

        // Check to see if IssuedAt property is set
        internal bool IsSetIssuedAt()
        {
            return this._issuedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the credit code (e.g., active, redeemed, expired).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BenefitAllocationStatus Status
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The monetary value of the credit code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonetaryValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}