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
    /// This is the response object from the CreateReplicationConfiguration operation.
    /// </summary>
    public partial class CreateReplicationConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Describes when the replication configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// An array of destination objects. Only one destination object is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Destination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<Destination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OriginalSourceFileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the original source EFS file system in the replication
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OriginalSourceFileSystemArn { get; set; }

        /// <summary>
        /// Checks to see if the OriginalSourceFileSystemArn property is set.
        /// </summary>
        internal bool IsSetOriginalSourceFileSystemArn() => this.OriginalSourceFileSystemArn != null;

        /// <summary>
        /// Gets and sets the property SourceFileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the current source file system in the replication
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceFileSystemArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceFileSystemArn property is set.
        /// </summary>
        internal bool IsSetSourceFileSystemArn() => this.SourceFileSystemArn != null;

        /// <summary>
        /// Gets and sets the property SourceFileSystemId. 
        /// <para>
        /// The ID of the source Amazon EFS file system that is being replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string SourceFileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the SourceFileSystemId property is set.
        /// </summary>
        internal bool IsSetSourceFileSystemId() => this.SourceFileSystemId != null;

        /// <summary>
        /// Gets and sets the property SourceFileSystemOwnerId. 
        /// <para>
        /// ID of the Amazon Web Services account in which the source file system resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 14)]
        public string SourceFileSystemOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the SourceFileSystemOwnerId property is set.
        /// </summary>
        internal bool IsSetSourceFileSystemOwnerId() => this.SourceFileSystemOwnerId != null;

        /// <summary>
        /// Gets and sets the property SourceFileSystemRegion. 
        /// <para>
        /// The Amazon Web Services Region in which the source EFS file system is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SourceFileSystemRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceFileSystemRegion property is set.
        /// </summary>
        internal bool IsSetSourceFileSystemRegion() => this.SourceFileSystemRegion != null;
    }
}
