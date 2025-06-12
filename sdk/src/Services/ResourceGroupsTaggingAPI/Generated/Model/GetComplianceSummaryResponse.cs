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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
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
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// This is the response object from the GetComplianceSummary operation.
    /// </summary>
    public partial class GetComplianceSummaryResponse : AmazonWebServiceResponse
    {
        private string _paginationToken;
        private List<Summary> _summaryList = AWSConfigs.InitializeCollections ? new List<Summary>() : null;

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// A string that indicates that there is more data available than this response contains.
        /// To receive the next part of the response, specify this response value as the <c>PaginationToken</c>
        /// value in the request for the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryList. 
        /// <para>
        /// A table that shows counts of noncompliant resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Summary> SummaryList
        {
            get { return this._summaryList; }
            set { this._summaryList = value; }
        }

        // Check to see if SummaryList property is set
        internal bool IsSetSummaryList()
        {
            return this._summaryList != null && (this._summaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}