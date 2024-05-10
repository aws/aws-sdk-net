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
    /// This is the response object from the ListApplicationVersions operation.
    /// </summary>
    public partial class ListApplicationVersionsResponse : AmazonWebServiceResponse
    {
        private List<ApplicationVersionSummary> _applicationVersionSummaries = AWSConfigs.InitializeCollections ? new List<ApplicationVersionSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationVersionSummaries. 
        /// <para>
        /// A list of the application versions and the associated configuration summaries. The
        /// list includes application versions that were rolled back.
        /// </para>
        ///  
        /// <para>
        /// To get the complete description of a specific application version, invoke the <a>DescribeApplicationVersion</a>
        /// operation.
        /// </para>
        /// </summary>
        public List<ApplicationVersionSummary> ApplicationVersionSummaries
        {
            get { return this._applicationVersionSummaries; }
            set { this._applicationVersionSummaries = value; }
        }

        // Check to see if ApplicationVersionSummaries property is set
        internal bool IsSetApplicationVersionSummaries()
        {
            return this._applicationVersionSummaries != null && (this._applicationVersionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next set of results, or <c>null</c> if there are no additional
        /// results. To retrieve the next set of items, pass this token into a subsequent invocation
        /// of this operation. For more information about pagination, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/pagination.html">Using
        /// the Amazon Command Line Interface's Pagination Options</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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