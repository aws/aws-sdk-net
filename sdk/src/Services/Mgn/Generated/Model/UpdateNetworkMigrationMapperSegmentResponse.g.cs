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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// This is the response object from the UpdateNetworkMigrationMapperSegment operation.
    /// </summary>
    public partial class UpdateNetworkMigrationMapperSegmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum of the segment data for integrity verification.
        /// </para>
        /// </summary>
        public Checksum Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the segment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 600)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier of the job that created this segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string JobID { get; set; }

        /// <summary>
        /// Checks to see if the JobID property is set.
        /// </summary>
        internal bool IsSetJobID() => this.JobID != null;

        /// <summary>
        /// Gets and sets the property LogicalID. 
        /// <para>
        /// The logical identifier for the segment in the infrastructure code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LogicalID { get; set; }

        /// <summary>
        /// Checks to see if the LogicalID property is set.
        /// </summary>
        internal bool IsSetLogicalID() => this.LogicalID != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string NetworkMigrationDefinitionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationDefinitionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationDefinitionID() => this.NetworkMigrationDefinitionID != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string NetworkMigrationExecutionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationExecutionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationExecutionID() => this.NetworkMigrationExecutionID != null;

        /// <summary>
        /// Gets and sets the property OutputS3Configuration. 
        /// <para>
        /// The S3 location where segment artifacts are stored.
        /// </para>
        /// </summary>
        public S3Configuration OutputS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Configuration property is set.
        /// </summary>
        internal bool IsSetOutputS3Configuration() => this.OutputS3Configuration != null;

        /// <summary>
        /// Gets and sets the property ReferencedSegments. 
        /// <para>
        /// A list of other segments that this segment depends on or references.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReferencedSegments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReferencedSegments property is set.
        /// </summary>
        internal bool IsSetReferencedSegments() => this.ReferencedSegments != null && (this.ReferencedSegments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScopeTags. 
        /// <para>
        /// Scope tags for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 40)]
        public Dictionary<string, string> ScopeTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ScopeTags property is set.
        /// </summary>
        internal bool IsSetScopeTags() => this.ScopeTags != null && (this.ScopeTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The unique identifier of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SegmentID { get; set; }

        /// <summary>
        /// Checks to see if the SegmentID property is set.
        /// </summary>
        internal bool IsSetSegmentID() => this.SegmentID != null;

        /// <summary>
        /// Gets and sets the property SegmentType. 
        /// <para>
        /// The category of the network migration segment. A segment groups the network constructs
        /// (such as VPCs, subnets, and security groups) that are migrated together. Valid values:
        /// <c>WORKLOAD</c>, <c>APPLIANCE</c>.
        /// </para>
        /// </summary>
        public NetworkMigrationMapperSegmentType SegmentType { get; set; }

        /// <summary>
        /// Checks to see if the SegmentType property is set.
        /// </summary>
        internal bool IsSetSegmentType() => this.SegmentType != null;

        /// <summary>
        /// Gets and sets the property TargetAccount. 
        /// <para>
        /// The target AWS account where this segment will be deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string TargetAccount { get; set; }

        /// <summary>
        /// Checks to see if the TargetAccount property is set.
        /// </summary>
        internal bool IsSetTargetAccount() => this.TargetAccount != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the segment was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
