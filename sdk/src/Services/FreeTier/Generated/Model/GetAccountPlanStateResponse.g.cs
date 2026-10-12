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

namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// This is the response object from the GetAccountPlanState operation.
    /// </summary>
    public partial class GetAccountPlanStateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  A unique identifier that identifies the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountPlanExpirationDate. 
        /// <para>
        ///  The timestamp for when the current account plan expires. 
        /// </para>
        /// </summary>
        public DateTime? AccountPlanExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the AccountPlanExpirationDate property is set.
        /// </summary>
        internal bool IsSetAccountPlanExpirationDate() => this.AccountPlanExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property AccountPlanRemainingCredits. 
        /// <para>
        ///  The amount of credits remaining for the account. 
        /// </para>
        /// </summary>
        public MonetaryAmount AccountPlanRemainingCredits { get; set; }

        /// <summary>
        /// Checks to see if the AccountPlanRemainingCredits property is set.
        /// </summary>
        internal bool IsSetAccountPlanRemainingCredits() => this.AccountPlanRemainingCredits != null;

        /// <summary>
        /// Gets and sets the property AccountPlanStatus. 
        /// <para>
        ///  The current status for the account plan. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccountPlanStatus AccountPlanStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountPlanStatus property is set.
        /// </summary>
        internal bool IsSetAccountPlanStatus() => this.AccountPlanStatus != null;

        /// <summary>
        /// Gets and sets the property AccountPlanType. 
        /// <para>
        ///  The plan type for the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccountPlanType AccountPlanType { get; set; }

        /// <summary>
        /// Checks to see if the AccountPlanType property is set.
        /// </summary>
        internal bool IsSetAccountPlanType() => this.AccountPlanType != null;
    }
}
