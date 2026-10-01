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
    /// Details about an import file enrichment job.
    /// </summary>
    public partial class ImportFileEnrichment
    {
        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum of the enriched file for integrity verification.
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
        /// The timestamp when the enrichment job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the enrichment job completed or failed.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier of the import file enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string JobID { get; set; }

        /// <summary>
        /// Checks to see if the JobID property is set.
        /// </summary>
        internal bool IsSetJobID() => this.JobID != null;

        /// <summary>
        /// Gets and sets the property S3BucketTarget. 
        /// <para>
        /// The target S3 configuration for the enriched import file.
        /// </para>
        /// </summary>
        public EnrichmentTargetS3Configuration S3BucketTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketTarget property is set.
        /// </summary>
        internal bool IsSetS3BucketTarget() => this.S3BucketTarget != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the import file enrichment job.
        /// </para>
        /// </summary>
        public ImportFileEnrichmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Detailed status information about the enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;
    }
}
