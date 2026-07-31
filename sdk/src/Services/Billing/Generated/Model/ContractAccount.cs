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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// An account that is covered by the Enterprise Support contract.
    /// </summary>
    public partial class ContractAccount
    {
        private string _accountId;
        private bool? _isGdn;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID.
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
        /// Gets and sets the property IsGdn. 
        /// <para>
        /// When true, Support charges are calculated on charges before private discounts. When
        /// false, they are calculated after private discounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsGdn
        {
            get { return this._isGdn; }
            set { this._isGdn = value; }
        }

        // Check to see if IsGdn property is set
        internal bool IsSetIsGdn()
        {
            return this._isGdn.HasValue; 
        }

    }
}