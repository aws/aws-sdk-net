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
    /// An artifact generated during code generation, such as a CloudFormation template or
    /// Terraform file.
    /// </summary>
    public partial class NetworkMigrationCodeGenerationArtifact
    {
        private string _artifactid;
        private NetworkMigrationCodeGenerationArtifactSubType _artifactSubType;
        private NetworkMigrationCodeGenerationArtifactType _artifactType;
        private Checksum _checksum;
        private DateTime? _createdAt;
        private string _logicalid;
        private S3Configuration _outputs3Configuration;

        /// <summary>
        /// Gets and sets the property ArtifactID. 
        /// <para>
        /// The unique identifier of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ArtifactID
        {
            get { return this._artifactid; }
            set { this._artifactid = value; }
        }

        // Check to see if ArtifactID property is set
        internal bool IsSetArtifactID()
        {
            return this._artifactid != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactSubType. 
        /// <para>
        /// The sub-type of the artifact for further classification.
        /// </para>
        /// </summary>
        public NetworkMigrationCodeGenerationArtifactSubType ArtifactSubType
        {
            get { return this._artifactSubType; }
            set { this._artifactSubType = value; }
        }

        // Check to see if ArtifactSubType property is set
        internal bool IsSetArtifactSubType()
        {
            return this._artifactSubType != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        /// The type of the artifact, such as CLOUDFORMATION_TEMPLATE or TERRAFORM_MODULE.
        /// </para>
        /// </summary>
        public NetworkMigrationCodeGenerationArtifactType ArtifactType
        {
            get { return this._artifactType; }
            set { this._artifactType = value; }
        }

        // Check to see if ArtifactType property is set
        internal bool IsSetArtifactType()
        {
            return this._artifactType != null;
        }

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum of the artifact for integrity verification.
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
        /// The timestamp when the artifact was created.
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
        /// Gets and sets the property LogicalID. 
        /// <para>
        /// The logical identifier for the artifact.
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
        /// Gets and sets the property OutputS3Configuration. 
        /// <para>
        /// The S3 location where the artifact is stored.
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

    }
}