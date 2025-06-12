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
    /// This is the response object from the ListQualificationRequests operation.
    /// </summary>
    public partial class ListQualificationRequestsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private int? _numResults;
        private List<QualificationRequest> _qualificationRequests = AWSConfigs.InitializeCollections ? new List<QualificationRequest>() : null;

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
        /// The number of Qualification requests on this page in the filtered results list, equivalent
        /// to the number of Qualification requests being returned by this call.
        /// </para>
        /// </summary>
        public int? NumResults
        {
            get { return this._numResults; }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualificationRequests. 
        /// <para>
        /// The Qualification request. The response includes one QualificationRequest element
        /// for each Qualification request returned by the query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QualificationRequest> QualificationRequests
        {
            get { return this._qualificationRequests; }
            set { this._qualificationRequests = value; }
        }

        // Check to see if QualificationRequests property is set
        internal bool IsSetQualificationRequests()
        {
            return this._qualificationRequests != null && (this._qualificationRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}