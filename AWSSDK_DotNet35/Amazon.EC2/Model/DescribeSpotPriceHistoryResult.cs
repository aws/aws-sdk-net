/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.EC2.Model
{
    /// <summary>Describe Spot Price History Result
    /// </summary>
    public partial class DescribeSpotPriceHistoryResult : AmazonWebServiceResponse
    {
        
        private List<SpotPrice> spotPriceHistory = new List<SpotPrice>();
        private string nextToken;

        public List<SpotPrice> SpotPriceHistory
        {
            get { return this.spotPriceHistory; }
            set { this.spotPriceHistory = value; }
        }

        // Check to see if SpotPriceHistory property is set
        internal bool IsSetSpotPriceHistory()
        {
            return this.spotPriceHistory.Count > 0;
        }

        /// <summary>
        /// The string marking the next set of results returned. Displays empty if there are no more results to be returned.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
