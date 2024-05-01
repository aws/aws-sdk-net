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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the TransferDomainToAnotherAwsAccount operation.
    /// Transfers a domain from the current Amazon Web Services account to another Amazon
    /// Web Services account. Note the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The Amazon Web Services account that you're transferring the domain to must accept
    /// the transfer. If the other account doesn't accept the transfer within 3 days, we cancel
    /// the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can cancel the transfer before the other account accepts it. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_CancelDomainTransferToAnotherAwsAccount.html">CancelDomainTransferToAnotherAwsAccount</a>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The other account can reject the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_RejectDomainTransferFromAnotherAwsAccount.html">RejectDomainTransferFromAnotherAwsAccount</a>.
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// When you transfer a domain from one Amazon Web Services account to another, Route
    /// 53 doesn't transfer the hosted zone that is associated with the domain. DNS resolution
    /// isn't affected if the domain and the hosted zone are owned by separate accounts, so
    /// transferring the hosted zone is optional. For information about transferring the hosted
    /// zone to another Amazon Web Services account, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/hosted-zones-migrating.html">Migrating
    /// a Hosted Zone to a Different Amazon Web Services Account</a> in the <i>Amazon Route
    /// 53 Developer Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
    /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
    /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
    /// provides additional information, for example, <c>Domain Transfer from Aws Account
    /// 111122223333 has been cancelled</c>. 
    /// </para>
    /// </summary>
    public partial class TransferDomainToAnotherAwsAccountRequest : AmazonRoute53DomainsRequest
    {
        private string _accountId;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the Amazon Web Services account that you want to transfer the domain
        /// to, for example, <c>111122223333</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to transfer from the current Amazon Web Services
        /// account to another account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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

    }
}