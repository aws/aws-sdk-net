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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// This is the response object from the ListBonusPayments operation.
    /// </summary>
    public partial class ListBonusPaymentsResponse : AmazonWebServiceResponse
    {
        private List<BonusPayment> _bonusPayments = new List<BonusPayment>();
        private string _nextToken;
        private int? _numResults;

        /// <summary>
        /// Gets and sets the property BonusPayments. 
        /// <para>
        /// A successful request to the ListBonusPayments operation returns a list of BonusPayment
        /// objects. 
        /// </para>
        /// </summary>
        public List<BonusPayment> BonusPayments
        {
            get { return this._bonusPayments; }
            set { this._bonusPayments = value; }
        }

        // Check to see if BonusPayments property is set
        internal bool IsSetBonusPayments()
        {
            return this._bonusPayments != null && this._bonusPayments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of bonus payments on this page in the filtered results list, equivalent
        /// to the number of bonus payments being returned by this call. 
        /// </para>
        /// </summary>
        public int NumResults
        {
            get { return this._numResults.GetValueOrDefault(); }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

    }
}