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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SavingsPlans.Model
{
    /// <summary>
    /// This is the response object from the DescribeSavingsPlans operation.
    /// </summary>
    public partial class DescribeSavingsPlansResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SavingsPlan> _savingsPlans = new List<SavingsPlan>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is null when there
        /// are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property SavingsPlans. 
        /// <para>
        /// Information about the Savings Plans.
        /// </para>
        /// </summary>
        public List<SavingsPlan> SavingsPlans
        {
            get { return this._savingsPlans; }
            set { this._savingsPlans = value; }
        }

        // Check to see if SavingsPlans property is set
        internal bool IsSetSavingsPlans()
        {
            return this._savingsPlans != null && this._savingsPlans.Count > 0; 
        }

    }
}