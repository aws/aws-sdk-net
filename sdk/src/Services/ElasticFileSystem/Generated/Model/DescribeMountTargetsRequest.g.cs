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
    /// Container for the parameters to the DescribeMountTargets operation. Returns the descriptions
    /// of all the current mount targets, or a specific mount target, for a file system. When
    /// requesting all of the current mount targets, the order of mount targets returned in
    /// the response is unspecified. <para> This operation requires permissions for the <c>elasticfilesystem:DescribeMountTargets</c>
    /// action, on either the file system ID that you specify in <c>FileSystemId</c>, or on
    /// the file system of the mount target that you specify in <c>MountTargetId</c>. </para>
    /// </summary>
    public partial class DescribeMountTargetsRequest : AmazonElasticFileSystemRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeMountTargetsRequest() { }

        /// <summary>
        /// Instantiates DescribeMountTargetsRequest with the parameterized properties
        /// </summary>
        /// <param name="fileSystemId">(Optional) ID of the file system whose mount targets you want to list (String). It must   be included in your request if an <c>AccessPointId</c> or <c>MountTargetId</c> is not included. Accepts either a file system ID or ARN as input.</param>
        public DescribeMountTargetsRequest(string fileSystemId)
        {
            this.FileSystemId = fileSystemId;
        }

        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// (Optional) The ID of the access point whose mount targets that you want to list. It
        /// must be included in your request if a <c>FileSystemId</c> or <c>MountTargetId</c>
        /// is not included in your request. Accepts either an access point ID or ARN as input.
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
        /// (Optional) ID of the file system whose mount targets you want to list (String). It
        /// must be included in your request if an <c>AccessPointId</c> or <c>MountTargetId</c>
        /// is not included. Accepts either a file system ID or ARN as input.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// (Optional) Opaque pagination token returned from a previous <c>DescribeMountTargets</c>
        /// operation (String). If present, it specifies to continue the list from where the previous
        /// returning call left off.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) Maximum number of mount targets to return in the response. Currently, this
        /// number is automatically set to 10, and other values are ignored. The response is paginated
        /// at 100 per page if you have more than 100 mount targets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property MountTargetId. 
        /// <para>
        /// (Optional) ID of the mount target that you want to have described (String). It must
        /// be included in your request if <c>FileSystemId</c> is not included. Accepts either
        /// a mount target ID or ARN as input.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 13, Max = 45)]
        public string MountTargetId { get; set; }

        /// <summary>
        /// Checks to see if the MountTargetId property is set.
        /// </summary>
        internal bool IsSetMountTargetId() => this.MountTargetId != null;
    }
}
