/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// A list of the predictive inbox placement test reports that are available for your
    /// account, regardless of whether or not those tests are complete.
    /// </summary>
    public partial class ListDeliverabilityTestReportsResponse : AmazonWebServiceResponse
    {
        private List<DeliverabilityTestReport> _deliverabilityTestReports = new List<DeliverabilityTestReport>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeliverabilityTestReports. 
        /// <para>
        /// An object that contains a lists of predictive inbox placement tests that you've performed.
        /// </para>
        /// </summary>
        public List<DeliverabilityTestReport> DeliverabilityTestReports
        {
            get { return this._deliverabilityTestReports; }
            set { this._deliverabilityTestReports = value; }
        }

        // Check to see if DeliverabilityTestReports property is set
        internal bool IsSetDeliverabilityTestReports()
        {
            return this._deliverabilityTestReports != null && this._deliverabilityTestReports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there are additional predictive inbox placement tests
        /// to list. To view additional predictive inbox placement tests, issue another request
        /// to <code>ListDeliverabilityTestReports</code>, and pass this token in the <code>NextToken</code>
        /// parameter.
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

    }
}