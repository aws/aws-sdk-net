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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeliverabilityTestReports operation.
    /// Show a list of the predictive inbox placement tests that you've performed, regardless
    /// of their statuses. For predictive inbox placement tests that are complete, you can
    /// use the <c>GetDeliverabilityTestReport</c> operation to view the results.
    /// </summary>
    public partial class ListDeliverabilityTestReportsRequest : AmazonPinpointEmailRequest
    {
        private string _nextToken;
        private int? _pageSize;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from a previous call to <c>ListDeliverabilityTestReports</c> to indicate
        /// the position in the list of predictive inbox placement tests.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of results to show in a single call to <c>ListDeliverabilityTestReports</c>.
        /// If the number of results is larger than the number you specified in this parameter,
        /// then the response includes a <c>NextToken</c> element, which you can use to obtain
        /// additional results.
        /// </para>
        ///  
        /// <para>
        /// The value you specify has to be at least 0, and can be no more than 1000.
        /// </para>
        /// </summary>
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}