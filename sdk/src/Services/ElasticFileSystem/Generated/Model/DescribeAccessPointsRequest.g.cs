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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeAccessPoints operation. Returns the description
    /// of a specific Amazon EFS access point if the <c>AccessPointId</c> is provided. If
    /// you provide an EFS <c>FileSystemId</c>, it returns descriptions of all access points
    /// for that file system. You can provide either an <c>AccessPointId</c> or a <c>FileSystemId</c>
    /// in the request, but not both. <para> This operation requires permissions for the <c>elasticfilesystem:DescribeAccessPoints</c>
    /// action. </para>
    /// </summary>
    public partial class DescribeAccessPointsRequest : AmazonElasticFileSystemRequest
    {
        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// (Optional) Specifies an EFS access point to describe in the response; mutually exclusive
        /// with <c>FileSystemId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointId property is set.
        /// </summary>
        internal bool IsSetAccessPointId() => this.AccessPointId != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// (Optional) If you provide a <c>FileSystemId</c>, EFS returns all access points for
        /// that file system; mutually exclusive with <c>AccessPointId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) When retrieving all access points for a file system, you can optionally
        /// specify the <c>MaxItems</c> parameter to limit the number of objects returned in a
        /// response. The default value is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  <c>NextToken</c> is present if the response is paginated. You can use <c>NextMarker</c>
        /// in the subsequent request to fetch the next page of access point descriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
