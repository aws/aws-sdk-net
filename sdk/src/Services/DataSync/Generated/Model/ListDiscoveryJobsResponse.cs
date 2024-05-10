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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the ListDiscoveryJobs operation.
    /// </summary>
    public partial class ListDiscoveryJobsResponse : AmazonWebServiceResponse
    {
        private List<DiscoveryJobListEntry> _discoveryJobs = AWSConfigs.InitializeCollections ? new List<DiscoveryJobListEntry>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DiscoveryJobs. 
        /// <para>
        /// The discovery jobs that you've run.
        /// </para>
        /// </summary>
        public List<DiscoveryJobListEntry> DiscoveryJobs
        {
            get { return this._discoveryJobs; }
            set { this._discoveryJobs = value; }
        }

        // Check to see if DiscoveryJobs property is set
        internal bool IsSetDiscoveryJobs()
        {
            return this._discoveryJobs != null && (this._discoveryJobs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The opaque string that indicates the position to begin the next list of results in
        /// the response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=65535)]
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