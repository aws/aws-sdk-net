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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
    /// A segment of generated code representing a logical grouping of infrastructure resources.
    /// </summary>
    public partial class NetworkMigrationCodeGenerationSegment
    {
        private List<NetworkMigrationCodeGenerationArtifact> _artifacts = AWSConfigs.InitializeCollections ? new List<NetworkMigrationCodeGenerationArtifact>() : null;
        private DateTime? _createdAt;
        private string _jobid;
        private string _logicalid;
        private string _mapperSegmentID;
        private string _networkMigrationDefinitionID;
        private string _networkMigrationExecutionID;
        private string _segmentid;
        private NetworkMigrationCodeGenerationSegmentType _segmentType;

        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// A list of artifacts generated for this segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkMigrationCodeGenerationArtifact> Artifacts
        {
            get { return this._artifacts; }
            set { this._artifacts = value; }
        }

        // Check to see if Artifacts property is set
        internal bool IsSetArtifacts()
        {
            return this._artifacts != null && (this._artifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the segment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier of the code generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property LogicalID. 
        /// <para>
        /// The logical identifier for the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LogicalID
        {
            get { return this._logicalid; }
            set { this._logicalid = value; }
        }

        // Check to see if LogicalID property is set
        internal bool IsSetLogicalID()
        {
            return this._logicalid != null;
        }

        /// <summary>
        /// Gets and sets the property MapperSegmentID. 
        /// <para>
        /// The ID of the mapper segment that this code generation segment was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MapperSegmentID
        {
            get { return this._mapperSegmentID; }
            set { this._mapperSegmentID = value; }
        }

        // Check to see if MapperSegmentID property is set
        internal bool IsSetMapperSegmentID()
        {
            return this._mapperSegmentID != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string NetworkMigrationDefinitionID
        {
            get { return this._networkMigrationDefinitionID; }
            set { this._networkMigrationDefinitionID = value; }
        }

        // Check to see if NetworkMigrationDefinitionID property is set
        internal bool IsSetNetworkMigrationDefinitionID()
        {
            return this._networkMigrationDefinitionID != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string NetworkMigrationExecutionID
        {
            get { return this._networkMigrationExecutionID; }
            set { this._networkMigrationExecutionID = value; }
        }

        // Check to see if NetworkMigrationExecutionID property is set
        internal bool IsSetNetworkMigrationExecutionID()
        {
            return this._networkMigrationExecutionID != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The unique identifier of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SegmentID
        {
            get { return this._segmentid; }
            set { this._segmentid = value; }
        }

        // Check to see if SegmentID property is set
        internal bool IsSetSegmentID()
        {
            return this._segmentid != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentType. 
        /// <para>
        /// The type of the segment.
        /// </para>
        /// </summary>
        public NetworkMigrationCodeGenerationSegmentType SegmentType
        {
            get { return this._segmentType; }
            set { this._segmentType = value; }
        }

        // Check to see if SegmentType property is set
        internal bool IsSetSegmentType()
        {
            return this._segmentType != null;
        }

    }
}