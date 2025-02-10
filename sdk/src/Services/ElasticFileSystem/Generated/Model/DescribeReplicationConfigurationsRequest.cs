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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReplicationConfigurations operation.
    /// Retrieves the replication configuration for a specific file system. If a file system
    /// is not specified, all of the replication configurations for the Amazon Web Services
    /// account in an Amazon Web Services Region are retrieved.
    /// </summary>
    public partial class DescribeReplicationConfigurationsRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// You can retrieve the replication configuration for a specific file system by providing
        /// its file system ID. For cross-account,cross-region replication, an account can only
        /// describe the replication configuration for a file system in its own Region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) To limit the number of objects returned in a response, you can specify
        /// the <c>MaxItems</c> parameter. The default value is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        ///  <c>NextToken</c> is present if the response is paginated. You can use <c>NextToken</c>
        /// in a subsequent request to fetch the next page of output.
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