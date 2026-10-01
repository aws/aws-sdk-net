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

namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Container for the parameters to the ListMountTargets operation. Returns resource information
    /// for all mount targets with optional filtering by file system, access point, and VPC.
    /// </summary>
    public partial class ListMountTargetsRequest : AmazonS3FilesRequest
    {
        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// Optional filter to list only mount targets associated with the specified access point
        /// ID or Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointId property is set.
        /// </summary>
        internal bool IsSetAccessPointId() => this.AccessPointId != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// Optional filter to list only mount targets associated with the specified S3 File System
        /// ID or Amazon Resource Name (ARN). If provided, only mount targets for this file system
        /// will be returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of mount targets to return in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token returned from a previous call to continue listing mount targets.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
