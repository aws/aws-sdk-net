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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeRecommendationLimitations operation.
    /// </summary>
    public partial class DescribeRecommendationLimitationsResponse : AmazonWebServiceResponse
    {
        private List<Limitation> _limitations = new List<Limitation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Limitations. 
        /// <para>
        /// The list of limitations for recommendations of target Amazon Web Services engines.
        /// </para>
        /// </summary>
        public List<Limitation> Limitations
        {
            get { return this._limitations; }
            set { this._limitations = value; }
        }

        // Check to see if Limitations property is set
        internal bool IsSetLimitations()
        {
            return this._limitations != null && this._limitations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The unique pagination token returned for you to pass to a subsequent request. Fleet
        /// Advisor returns this token when the number of records in the response is greater than
        /// the <code>MaxRecords</code> value. To retrieve the next page, make the call again
        /// using the returned token and keeping all other arguments unchanged.
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