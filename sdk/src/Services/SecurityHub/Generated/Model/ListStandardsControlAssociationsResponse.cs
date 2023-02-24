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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the ListStandardsControlAssociations operation.
    /// </summary>
    public partial class ListStandardsControlAssociationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StandardsControlAssociationSummary> _standardsControlAssociationSummaries = new List<StandardsControlAssociationSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination parameter that's included in the response only if it was included in
        /// the request. 
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
        /// Gets and sets the property StandardsControlAssociationSummaries. 
        /// <para>
        ///  An array that provides the enablement status and other details for each security
        /// control that applies to each enabled standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<StandardsControlAssociationSummary> StandardsControlAssociationSummaries
        {
            get { return this._standardsControlAssociationSummaries; }
            set { this._standardsControlAssociationSummaries = value; }
        }

        // Check to see if StandardsControlAssociationSummaries property is set
        internal bool IsSetStandardsControlAssociationSummaries()
        {
            return this._standardsControlAssociationSummaries != null && this._standardsControlAssociationSummaries.Count > 0; 
        }

    }
}