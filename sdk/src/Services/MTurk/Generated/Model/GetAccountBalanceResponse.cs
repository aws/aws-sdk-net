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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// This is the response object from the GetAccountBalance operation.
    /// </summary>
    public partial class GetAccountBalanceResponse : AmazonWebServiceResponse
    {
        private string _availableBalance;
        private string _onHoldBalance;

        /// <summary>
        /// Gets and sets the property AvailableBalance.
        /// </summary>
        public string AvailableBalance
        {
            get { return this._availableBalance; }
            set { this._availableBalance = value; }
        }

        // Check to see if AvailableBalance property is set
        internal bool IsSetAvailableBalance()
        {
            return this._availableBalance != null;
        }

        /// <summary>
        /// Gets and sets the property OnHoldBalance.
        /// </summary>
        public string OnHoldBalance
        {
            get { return this._onHoldBalance; }
            set { this._onHoldBalance = value; }
        }

        // Check to see if OnHoldBalance property is set
        internal bool IsSetOnHoldBalance()
        {
            return this._onHoldBalance != null;
        }

    }
}