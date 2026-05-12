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
    /// This is the response object from the UpdateNetworkMigrationMapperSegment operation.
    /// </summary>
    public partial class UpdateNetworkMigrationMapperSegmentResponse : AmazonWebServiceResponse
    {
        private Checksum _checksum;
        private DateTime? _createdAt;
        private string _description;
        private string _jobid;
        private string _logicalid;
        private string _name;
        private string _networkMigrationDefinitionID;
        private string _networkMigrationExecutionID;
        private S3Configuration _outputs3Configuration;
        private List<string> _referencedSegments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _scopeTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _segmentid;
        private NetworkMigrationMapperSegmentType _segmentType;
        private string _targetAccount;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum of the segment data for integrity verification.
        /// </para>
        /// </summary>
        public Checksum Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier of the job that created this segment.
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
        /// The logical identifier for the segment in the infrastructure code.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        /// Gets and sets the property OutputS3Configuration. 
        /// <para>
        /// The S3 location where segment artifacts are stored.
        /// </para>
        /// </summary>
        public S3Configuration OutputS3Configuration
        {
            get { return this._outputs3Configuration; }
            set { this._outputs3Configuration = value; }
        }

        // Check to see if OutputS3Configuration property is set
        internal bool IsSetOutputS3Configuration()
        {
            return this._outputs3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ReferencedSegments. 
        /// <para>
        /// A list of other segments that this segment depends on or references.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReferencedSegments
        {
            get { return this._referencedSegments; }
            set { this._referencedSegments = value; }
        }

        // Check to see if ReferencedSegments property is set
        internal bool IsSetReferencedSegments()
        {
            return this._referencedSegments != null && (this._referencedSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScopeTags. 
        /// <para>
        /// Scope tags for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=40)]
        public Dictionary<string, string> ScopeTags
        {
            get { return this._scopeTags; }
            set { this._scopeTags = value; }
        }

        // Check to see if ScopeTags property is set
        internal bool IsSetScopeTags()
        {
            return this._scopeTags != null && (this._scopeTags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The type of the segment, such as VPC, subnet, or security group.
        /// </para>
        /// </summary>
        public NetworkMigrationMapperSegmentType SegmentType
        {
            get { return this._segmentType; }
            set { this._segmentType = value; }
        }

        // Check to see if SegmentType property is set
        internal bool IsSetSegmentType()
        {
            return this._segmentType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccount. 
        /// <para>
        /// The target AWS account where this segment will be deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string TargetAccount
        {
            get { return this._targetAccount; }
            set { this._targetAccount = value; }
        }

        // Check to see if TargetAccount property is set
        internal bool IsSetTargetAccount()
        {
            return this._targetAccount != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the segment was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}