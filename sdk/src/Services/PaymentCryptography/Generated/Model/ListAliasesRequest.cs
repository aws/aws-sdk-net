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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the ListAliases operation.
    /// Lists the aliases for all keys in the caller's Amazon Web Services account and Amazon
    /// Web Services Region. You can filter the aliases by <c>keyARN</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-managealias.html">Using
    /// aliases</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// This is a paginated operation, which means that each response might contain only a
    /// subset of all the aliases. When the response contains only a subset of aliases, it
    /// includes a <c>NextToken</c> value. Use this value in a subsequent <c>ListAliases</c>
    /// request to get more aliases. When you receive a response with no NextToken (or an
    /// empty or null value), that means there are no more aliases to get.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetAlias.html">GetAlias</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListAliasesRequest : AmazonPaymentCryptographyRequest
    {
        private string _keyArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The <c>keyARN</c> for which you want to list all aliases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=70, Max=150)]
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Use this parameter to specify the maximum number of items to return. When this value
        /// is present, Amazon Web Services Payment Cryptography does not return more than the
        /// specified number of items, but it might return fewer.
        /// </para>
        ///  
        /// <para>
        /// This value is optional. If you include a value, it must be between 1 and 100, inclusive.
        /// If you do not include a value, it defaults to 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use this parameter in a subsequent request after you receive a response with truncated
        /// results. Set it to the value of <c>NextToken</c> from the truncated response you just
        /// received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}