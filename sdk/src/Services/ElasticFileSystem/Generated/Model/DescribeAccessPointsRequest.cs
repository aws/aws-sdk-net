/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccessPoints operation.
    /// Returns the description of a specific Amazon EFS access point if the <code>AccessPointId</code>
    /// is provided. If you provide an EFS <code>FileSystemId</code>, it returns descriptions
    /// of all access points for that file system. You can provide either an <code>AccessPointId</code>
    /// or a <code>FileSystemId</code> in the request, but not both. 
    /// 
    ///  
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:DescribeAccessPoints</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DescribeAccessPointsRequest : AmazonElasticFileSystemRequest
    {
        private string _accessPointId;
        private string _fileSystemId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// (Optional) Specifies an EFS access point to describe in the response; mutually exclusive
        /// with <code>FileSystemId</code>.
        /// </para>
        /// </summary>
        public string AccessPointId
        {
            get { return this._accessPointId; }
            set { this._accessPointId = value; }
        }

        // Check to see if AccessPointId property is set
        internal bool IsSetAccessPointId()
        {
            return this._accessPointId != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// (Optional) If you provide a <code>FileSystemId</code>, EFS returns all access points
        /// for that file system; mutually exclusive with <code>AccessPointId</code>.
        /// </para>
        /// </summary>
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
        /// (Optional) When retrieving all access points for a file system, you can optionally
        /// specify the <code>MaxItems</code> parameter to limit the number of objects returned
        /// in a response. The default value is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        ///  <code>NextToken</code> is present if the response is paginated. You can use <code>NextMarker</code>
        /// in the subsequent request to fetch the next page of access point descriptions.
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

    }
}