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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeJobDefinitions operation.
    /// Describes a list of job definitions. You can specify a <c>status</c> (such as <c>ACTIVE</c>)
    /// to only return job definitions that match that status.
    /// </summary>
    public partial class DescribeJobDefinitionsRequest : AmazonBatchRequest
    {
        private string _jobDefinitionName;
        private List<string> _jobDefinitions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _status;

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the job definition to describe.
        /// </para>
        /// </summary>
        public string JobDefinitionName
        {
            get { return this._jobDefinitionName; }
            set { this._jobDefinitionName = value; }
        }

        // Check to see if JobDefinitionName property is set
        internal bool IsSetJobDefinitionName()
        {
            return this._jobDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinitions. 
        /// <para>
        /// A list of up to 100 job definitions. Each entry in the list can either be an ARN in
        /// the format <c>arn:aws:batch:${Region}:${Account}:job-definition/${JobDefinitionName}:${Revision}</c>
        /// or a short version using the form <c>${JobDefinitionName}:${Revision}</c>. This parameter
        /// can't be used with other parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobDefinitions
        {
            get { return this._jobDefinitions; }
            set { this._jobDefinitions = value; }
        }

        // Check to see if JobDefinitions property is set
        internal bool IsSetJobDefinitions()
        {
            return this._jobDefinitions != null && (this._jobDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by <c>DescribeJobDefinitions</c> in paginated
        /// output. When this parameter is used, <c>DescribeJobDefinitions</c> only returns <c>maxResults</c>
        /// results in a single page and a <c>nextToken</c> response element. The remaining results
        /// of the initial request can be seen by sending another <c>DescribeJobDefinitions</c>
        /// request with the returned <c>nextToken</c> value. This value can be between 1 and
        /// 100. If this parameter isn't used, then <c>DescribeJobDefinitions</c> returns up to
        /// 100 results and a <c>nextToken</c> value if applicable.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated <c>DescribeJobDefinitions</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. This value is <c>null</c> when there are no more results
        /// to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// Treat this token as an opaque identifier that's only used to retrieve the next items
        /// in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status used to filter job definitions.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}