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
    /// This is the response object from the CreateAccessPoint operation.
    /// </summary>
    public partial class CreateAccessPointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointArn property is set.
        /// </summary>
        internal bool IsSetAccessPointArn() => this.AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// The ID of the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointId property is set.
        /// </summary>
        internal bool IsSetAccessPointId() => this.AccessPointId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token that was provided in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the S3 File System.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the access point owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 12)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PosixUser. 
        /// <para>
        /// The POSIX identity configured for this access point.
        /// </para>
        /// </summary>
        public PosixUser PosixUser { get; set; }

        /// <summary>
        /// Checks to see if the PosixUser property is set.
        /// </summary>
        internal bool IsSetPosixUser() => this.PosixUser != null;

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The root directory configuration for this access point.
        /// </para>
        /// </summary>
        public RootDirectory RootDirectory { get; set; }

        /// <summary>
        /// Checks to see if the RootDirectory property is set.
        /// </summary>
        internal bool IsSetRootDirectory() => this.RootDirectory != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LifeCycleState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the access point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
