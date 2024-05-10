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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// This is the response object from the ListApplications operation.
    /// </summary>
    public partial class ListApplicationsResponse : AmazonWebServiceResponse
    {
        private List<ApplicationSummary> _applicationSummaries = AWSConfigs.InitializeCollections ? new List<ApplicationSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationSummaries. 
        /// <para>
        /// A list of <c>ApplicationSummary</c> objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ApplicationSummary> ApplicationSummaries
        {
            get { return this._applicationSummaries; }
            set { this._applicationSummaries = value; }
        }

        // Check to see if ApplicationSummaries property is set
        internal bool IsSetApplicationSummaries()
        {
            return this._applicationSummaries != null && (this._applicationSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next set of results, or <c>null</c> if there are no additional
        /// results. Pass this token into a subsequent command to retrieve the next set of items
        /// For more information about pagination, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/pagination.html">Using
        /// the Amazon Command Line Interface's Pagination Options</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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