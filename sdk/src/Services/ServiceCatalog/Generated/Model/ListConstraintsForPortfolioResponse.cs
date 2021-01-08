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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the ListConstraintsForPortfolio operation.
    /// </summary>
    public partial class ListConstraintsForPortfolioResponse : AmazonWebServiceResponse
    {
        private List<ConstraintDetail> _constraintDetails = new List<ConstraintDetail>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property ConstraintDetails. 
        /// <para>
        /// Information about the constraints.
        /// </para>
        /// </summary>
        public List<ConstraintDetail> ConstraintDetails
        {
            get { return this._constraintDetails; }
            set { this._constraintDetails = value; }
        }

        // Check to see if ConstraintDetails property is set
        internal bool IsSetConstraintDetails()
        {
            return this._constraintDetails != null && this._constraintDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The page token to use to retrieve the next set of results. If there are no additional
        /// results, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2024)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}