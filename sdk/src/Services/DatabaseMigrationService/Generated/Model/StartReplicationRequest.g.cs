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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the StartReplication operation. For a given DMS Serverless
    /// replication configuration, DMS connects to the source endpoint and collects the metadata
    /// to analyze the replication workload. Using this metadata, DMS then computes and provisions
    /// the required capacity and starts replicating to the target endpoint using the server
    /// resources that DMS has provisioned for the DMS Serverless replication.
    /// </summary>
    public partial class StartReplicationRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property CdcStartPosition. 
        /// <para>
        /// Indicates when you want a change data capture (CDC) operation to start. Use either
        /// <c>CdcStartPosition</c> or <c>CdcStartTime</c> to specify when you want a CDC operation
        /// to start. Specifying both values results in an error.
        /// </para>
        ///  
        /// <para>
        /// The value can be in date, checkpoint, or LSN/SCN format.
        /// </para>
        /// </summary>
        public string CdcStartPosition { get; set; }

        /// <summary>
        /// Checks to see if the CdcStartPosition property is set.
        /// </summary>
        internal bool IsSetCdcStartPosition() => this.CdcStartPosition != null;

        /// <summary>
        /// Gets and sets the property CdcStartTime. 
        /// <para>
        /// Indicates the start time for a change data capture (CDC) operation. Use either <c>CdcStartTime</c>
        /// or <c>CdcStartPosition</c> to specify when you want a CDC operation to start. Specifying
        /// both values results in an error.
        /// </para>
        /// </summary>
        public DateTime? CdcStartTime { get; set; }

        /// <summary>
        /// Checks to see if the CdcStartTime property is set.
        /// </summary>
        internal bool IsSetCdcStartTime() => this.CdcStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property CdcStopPosition. 
        /// <para>
        /// Indicates when you want a change data capture (CDC) operation to stop. The value can
        /// be either server time or commit time.
        /// </para>
        /// </summary>
        public string CdcStopPosition { get; set; }

        /// <summary>
        /// Checks to see if the CdcStopPosition property is set.
        /// </summary>
        internal bool IsSetCdcStopPosition() => this.CdcStopPosition != null;

        /// <summary>
        /// Gets and sets the property PremigrationAssessmentSettings. 
        /// <para>
        /// User-defined settings for the premigration assessment. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ResultLocationFolder</c>: The folder within an Amazon S3 bucket where you want
        /// DMS to store the results of this assessment run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResultEncryptionMode</c>: The supported values are <c>SSE_KMS</c> and <c>SSE_S3</c>.
        /// If these values are not provided, then the files are not encrypted at rest. For more
        /// information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.KMSKeys">Creating
        /// Amazon Web Services KMS keys to encrypt Amazon S3 target objects</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResultKmsKeyArn</c>: The ARN of a customer KMS encryption key that you specify
        /// when you set <c>ResultEncryptionMode</c> to <c>SSE_KMS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IncludeOnly</c>: A space-separated list of names for specific individual assessments
        /// that you want to include. These names come from the default list of individual assessments
        /// that Database Migration Service supports for the associated migration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Exclude</c>: A space-separated list of names for specific individual assessments
        /// that you want to exclude. These names come from the default list of individual assessments
        /// that Database Migration Service supports for the associated migration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FailOnAssessmentFailure</c>: A configurable setting you can set to <c>true</c>
        /// (the default setting) or <c>false</c>. Use this setting to to stop the replication
        /// from starting automatically if the assessment fails. This can help you evaluate the
        /// issue that is preventing the replication from running successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PremigrationAssessmentSettings { get; set; }

        /// <summary>
        /// Checks to see if the PremigrationAssessmentSettings property is set.
        /// </summary>
        internal bool IsSetPremigrationAssessmentSettings() => this.PremigrationAssessmentSettings != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigArn. 
        /// <para>
        /// The Amazon Resource Name of the replication for which to start replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigArn property is set.
        /// </summary>
        internal bool IsSetReplicationConfigArn() => this.ReplicationConfigArn != null;

        /// <summary>
        /// Gets and sets the property StartReplicationType. 
        /// <para>
        /// The replication type.
        /// </para>
        ///  
        /// <para>
        /// When the replication type is <c>full-load</c> or <c>full-load-and-cdc</c>, the only
        /// valid value for the first run of the replication is <c>start-replication</c>. This
        /// option will start the replication.
        /// </para>
        ///  
        /// <para>
        /// You can also use <a>ReloadTables</a> to reload specific tables that failed during
        /// replication instead of restarting the replication.
        /// </para>
        ///  
        /// <para>
        /// The <c>resume-processing</c> option isn't applicable for a full-load replication,
        /// because you can't resume partially loaded tables during the full load phase.
        /// </para>
        ///  
        /// <para>
        /// For a <c>full-load-and-cdc</c> replication, DMS migrates table data, and then applies
        /// data changes that occur on the source. To load all the tables again, and start capturing
        /// source changes, use <c>reload-target</c>. Otherwise use <c>resume-processing</c>,
        /// to replicate the changes from the last stop position.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StartReplicationType { get; set; }

        /// <summary>
        /// Checks to see if the StartReplicationType property is set.
        /// </summary>
        internal bool IsSetStartReplicationType() => this.StartReplicationType != null;
    }
}
