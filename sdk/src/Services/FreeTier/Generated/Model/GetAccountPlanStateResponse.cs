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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
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
namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// This is the response object from the GetAccountPlanState operation.
    /// </summary>
    public partial class GetAccountPlanStateResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private DateTime? _accountPlanExpirationDate;
        private MonetaryAmount _accountPlanRemainingCredits;
        private AccountPlanStatus _accountPlanStatus;
        private AccountPlanType _accountPlanType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  A unique identifier that identifies the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountPlanExpirationDate. 
        /// <para>
        ///  The timestamp for when the current account plan expires. 
        /// </para>
        /// </summary>
        public DateTime? AccountPlanExpirationDate
        {
            get { return this._accountPlanExpirationDate; }
            set { this._accountPlanExpirationDate = value; }
        }

        // Check to see if AccountPlanExpirationDate property is set
        internal bool IsSetAccountPlanExpirationDate()
        {
            return this._accountPlanExpirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AccountPlanRemainingCredits. 
        /// <para>
        ///  The amount of credits remaining for the account. 
        /// </para>
        /// </summary>
        public MonetaryAmount AccountPlanRemainingCredits
        {
            get { return this._accountPlanRemainingCredits; }
            set { this._accountPlanRemainingCredits = value; }
        }

        // Check to see if AccountPlanRemainingCredits property is set
        internal bool IsSetAccountPlanRemainingCredits()
        {
            return this._accountPlanRemainingCredits != null;
        }

        /// <summary>
        /// Gets and sets the property AccountPlanStatus. 
        /// <para>
        ///  The current status for the account plan. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountPlanStatus AccountPlanStatus
        {
            get { return this._accountPlanStatus; }
            set { this._accountPlanStatus = value; }
        }

        // Check to see if AccountPlanStatus property is set
        internal bool IsSetAccountPlanStatus()
        {
            return this._accountPlanStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AccountPlanType. 
        /// <para>
        ///  The plan type for the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountPlanType AccountPlanType
        {
            get { return this._accountPlanType; }
            set { this._accountPlanType = value; }
        }

        // Check to see if AccountPlanType property is set
        internal bool IsSetAccountPlanType()
        {
            return this._accountPlanType != null;
        }

    }
}