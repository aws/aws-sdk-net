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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// This is the response object from the ListResourceSnapshotJobs operation.
    /// </summary>
    public partial class ListResourceSnapshotJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceSnapshotJobSummary> _resourceSnapshotJobSummaries = AWSConfigs.InitializeCollections ? new List<ResourceSnapshotJobSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token to retrieve the next set of results. If there are no additional results,
        /// this value is null. 
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
        /// Gets and sets the property ResourceSnapshotJobSummaries. 
        /// <para>
        ///  An array of resource snapshot job summary objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceSnapshotJobSummary> ResourceSnapshotJobSummaries
        {
            get { return this._resourceSnapshotJobSummaries; }
            set { this._resourceSnapshotJobSummaries = value; }
        }

        // Check to see if ResourceSnapshotJobSummaries property is set
        internal bool IsSetResourceSnapshotJobSummaries()
        {
            return this._resourceSnapshotJobSummaries != null && (this._resourceSnapshotJobSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}