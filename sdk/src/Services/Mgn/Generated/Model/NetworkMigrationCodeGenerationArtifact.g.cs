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
    /// An artifact generated during code generation, such as a CloudFormation template or
    /// Terraform file.
    /// </summary>
    public partial class NetworkMigrationCodeGenerationArtifact
    {
        /// <summary>
        /// Gets and sets the property ArtifactID. 
        /// <para>
        /// The unique identifier of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ArtifactID { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactID property is set.
        /// </summary>
        internal bool IsSetArtifactID() => this.ArtifactID != null;

        /// <summary>
        /// Gets and sets the property ArtifactSubType. 
        /// <para>
        /// The sub-type of the artifact for further classification.
        /// </para>
        /// </summary>
        public NetworkMigrationCodeGenerationArtifactSubType ArtifactSubType { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactSubType property is set.
        /// </summary>
        internal bool IsSetArtifactSubType() => this.ArtifactSubType != null;

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        /// The type of the generated artifact.
        /// </para>
        /// </summary>
        public NetworkMigrationCodeGenerationArtifactType ArtifactType { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactType property is set.
        /// </summary>
        internal bool IsSetArtifactType() => this.ArtifactType != null;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum of the artifact for integrity verification.
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
        /// The timestamp when the artifact was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LogicalID. 
        /// <para>
        /// The logical identifier for the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LogicalID { get; set; }

        /// <summary>
        /// Checks to see if the LogicalID property is set.
        /// </summary>
        internal bool IsSetLogicalID() => this.LogicalID != null;

        /// <summary>
        /// Gets and sets the property OutputS3Configuration. 
        /// <para>
        /// The S3 location where the artifact is stored.
        /// </para>
        /// </summary>
        public S3Configuration OutputS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Configuration property is set.
        /// </summary>
        internal bool IsSetOutputS3Configuration() => this.OutputS3Configuration != null;
    }
}
