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
    /// Details about an import file enrichment job.
    /// </summary>
    public partial class ImportFileEnrichment
    {
        private Checksum _checksum;
        private DateTime? _createdAt;
        private DateTime? _endedAt;
        private string _jobid;
        private EnrichmentTargetS3Configuration _s3BucketTarget;
        private ImportFileEnrichmentStatus _status;
        private string _statusDetails;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum of the enriched file for integrity verification.
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
        /// The timestamp when the enrichment job was created.
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
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the enrichment job completed or failed.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier of the import file enrichment job.
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
        /// Gets and sets the property S3BucketTarget. 
        /// <para>
        /// The target S3 configuration for the enriched import file.
        /// </para>
        /// </summary>
        public EnrichmentTargetS3Configuration S3BucketTarget
        {
            get { return this._s3BucketTarget; }
            set { this._s3BucketTarget = value; }
        }

        // Check to see if S3BucketTarget property is set
        internal bool IsSetS3BucketTarget()
        {
            return this._s3BucketTarget != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the import file enrichment job.
        /// </para>
        /// </summary>
        public ImportFileEnrichmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Detailed status information about the enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

    }
}