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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
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
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListMigrationTaskUpdates operation.
    /// This is a paginated API that returns all the migration-task states for the specified
    /// <c>MigrationTaskName</c> and <c>ProgressUpdateStream</c>.
    /// </summary>
    public partial class ListMigrationTaskUpdatesRequest : AmazonMigrationHubRequest
    {
        private int? _maxResults;
        private string _migrationTaskName;
        private string _nextToken;
        private string _progressUpdateStream;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response. If more results exist than
        /// the value that you specify here for <c>MaxResults</c>, the response will include a
        /// token that you can use to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// A unique identifier that references the migration task. <i>Do not include sensitive
        /// data in this field.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MigrationTaskName
        {
            get { return this._migrationTaskName; }
            set { this._migrationTaskName = value; }
        }

        // Check to see if MigrationTaskName property is set
        internal bool IsSetMigrationTaskName()
        {
            return this._migrationTaskName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <c>NextToken</c> was returned by a previous call, there are more results available.
        /// The value of <c>NextToken</c> is a unique pagination token for each page. To retrieve
        /// the next page of results, specify the <c>NextToken</c> value that the previous call
        /// returned. Keep all other arguments unchanged. Each pagination token expires after
        /// 24 hours. Using an expired pagination token will return an HTTP 400 InvalidToken error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// The name of the progress-update stream, which is used for access control as well as
        /// a namespace for migration-task names that is implicitly linked to your AWS account.
        /// The progress-update stream must uniquely identify the migration tool as it is used
        /// for all updates made by the tool; however, it does not need to be unique for each
        /// AWS account because it is scoped to the AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string ProgressUpdateStream
        {
            get { return this._progressUpdateStream; }
            set { this._progressUpdateStream = value; }
        }

        // Check to see if ProgressUpdateStream property is set
        internal bool IsSetProgressUpdateStream()
        {
            return this._progressUpdateStream != null;
        }

    }
}