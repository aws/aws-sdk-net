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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the ListDataSourceSyncJobs operation.
    /// </summary>
    public partial class ListDataSourceSyncJobsResponse : AmazonWebServiceResponse
    {
        private List<DataSourceSyncJob> _history = AWSConfigs.InitializeCollections ? new List<DataSourceSyncJob>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property History. 
        /// <para>
        /// A history of synchronization jobs for the data source connector.
        /// </para>
        /// </summary>
        public List<DataSourceSyncJob> History
        {
            get { return this._history; }
            set { this._history = value; }
        }

        // Check to see if History property is set
        internal bool IsSetHistory()
        {
            return this._history != null && (this._history.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Kendra returns this token that you can use in
        /// the subsequent request to retrieve the next set of jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
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