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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The configuration information that will be updated for this workgroup, which includes
    /// the location in Amazon S3 where query and calculation results are stored, the encryption
    /// option, if any, used for query results, whether the Amazon CloudWatch Metrics are
    /// enabled for the workgroup, whether the workgroup settings override the client-side
    /// settings, and the data usage limit for the amount of bytes scanned per query, if it
    /// is specified.
    /// </summary>
    public partial class WorkGroupConfigurationUpdates
    {
        /// <summary>
        /// Gets and sets the property AdditionalConfiguration. 
        /// <para>
        /// Contains a user defined string in JSON format for a Spark-enabled workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AdditionalConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalConfiguration property is set.
        /// </summary>
        internal bool IsSetAdditionalConfiguration() => this.AdditionalConfiguration != null;

        /// <summary>
        /// Gets and sets the property BytesScannedCutoffPerQuery. 
        /// <para>
        /// The upper limit (cutoff) for the amount of bytes a single query in a workgroup is
        /// allowed to scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10000000)]
        public long? BytesScannedCutoffPerQuery { get; set; }

        /// <summary>
        /// Checks to see if the BytesScannedCutoffPerQuery property is set.
        /// </summary>
        internal bool IsSetBytesScannedCutoffPerQuery() => this.BytesScannedCutoffPerQuery.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerContentEncryptionConfiguration.
        /// </summary>
        public CustomerContentEncryptionConfiguration CustomerContentEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomerContentEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomerContentEncryptionConfiguration() => this.CustomerContentEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property EnableMinimumEncryptionConfiguration. 
        /// <para>
        /// Enforces a minimal level of encryption for the workgroup for query and calculation
        /// results that are written to Amazon S3. When enabled, workgroup users can set encryption
        /// only to the minimum level set by the administrator or higher when they submit queries.
        /// This setting does not apply to Spark-enabled workgroups.
        /// </para>
        ///  
        /// <para>
        /// The <c>EnforceWorkGroupConfiguration</c> setting takes precedence over the <c>EnableMinimumEncryptionConfiguration</c>
        /// flag. This means that if <c>EnforceWorkGroupConfiguration</c> is true, the <c>EnableMinimumEncryptionConfiguration</c>
        /// flag is ignored, and the workgroup configuration for encryption is used.
        /// </para>
        /// </summary>
        public bool? EnableMinimumEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EnableMinimumEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEnableMinimumEncryptionConfiguration() => this.EnableMinimumEncryptionConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property EnforceWorkGroupConfiguration. 
        /// <para>
        /// If set to "true", the settings for the workgroup override client-side settings. If
        /// set to "false" client-side settings are used. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool? EnforceWorkGroupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EnforceWorkGroupConfiguration property is set.
        /// </summary>
        internal bool IsSetEnforceWorkGroupConfiguration() => this.EnforceWorkGroupConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property EngineConfiguration.
        /// </summary>
        public EngineConfiguration EngineConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EngineConfiguration property is set.
        /// </summary>
        internal bool IsSetEngineConfiguration() => this.EngineConfiguration != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version requested when a workgroup is updated. After the update, all queries
        /// on the workgroup run on the requested engine version. If no value was previously set,
        /// the default is Auto. Queries on the <c>AmazonAthenaPreviewFunctionality</c> workgroup
        /// run on the preview engine regardless of this setting.
        /// </para>
        /// </summary>
        public EngineVersion EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The ARN of the execution role used to access user resources for Spark sessions and
        /// Identity Center enabled workgroups. This property applies only to Spark enabled workgroups
        /// and Identity Center enabled workgroups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property ManagedQueryResultsConfigurationUpdates. 
        /// <para>
        /// Updates configuration information for managed query results in the workgroup.
        /// </para>
        /// </summary>
        public ManagedQueryResultsConfigurationUpdates ManagedQueryResultsConfigurationUpdates { get; set; }

        /// <summary>
        /// Checks to see if the ManagedQueryResultsConfigurationUpdates property is set.
        /// </summary>
        internal bool IsSetManagedQueryResultsConfigurationUpdates() => this.ManagedQueryResultsConfigurationUpdates != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// Contains the configuration settings for managed log persistence, delivering logs to
        /// Amazon S3 buckets, Amazon CloudWatch log groups etc.
        /// </para>
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetMonitoringConfiguration() => this.MonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property PublishCloudWatchMetricsEnabled. 
        /// <para>
        /// Indicates whether this workgroup enables publishing metrics to Amazon CloudWatch.
        /// </para>
        /// </summary>
        public bool? PublishCloudWatchMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PublishCloudWatchMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetPublishCloudWatchMetricsEnabled() => this.PublishCloudWatchMetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property QueryResultsS3AccessGrantsConfiguration. 
        /// <para>
        /// Specifies whether Amazon S3 access grants are enabled for query results.
        /// </para>
        /// </summary>
        public QueryResultsS3AccessGrantsConfiguration QueryResultsS3AccessGrantsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QueryResultsS3AccessGrantsConfiguration property is set.
        /// </summary>
        internal bool IsSetQueryResultsS3AccessGrantsConfiguration() => this.QueryResultsS3AccessGrantsConfiguration != null;

        /// <summary>
        /// Gets and sets the property RemoveBytesScannedCutoffPerQuery. 
        /// <para>
        /// Indicates that the data usage control limit per query is removed. <a>WorkGroupConfiguration$BytesScannedCutoffPerQuery</a>
        /// 
        /// </para>
        /// </summary>
        public bool? RemoveBytesScannedCutoffPerQuery { get; set; }

        /// <summary>
        /// Checks to see if the RemoveBytesScannedCutoffPerQuery property is set.
        /// </summary>
        internal bool IsSetRemoveBytesScannedCutoffPerQuery() => this.RemoveBytesScannedCutoffPerQuery.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveCustomerContentEncryptionConfiguration. 
        /// <para>
        /// Removes content encryption configuration from an Apache Spark-enabled Athena workgroup.
        /// </para>
        /// </summary>
        public bool? RemoveCustomerContentEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveCustomerContentEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoveCustomerContentEncryptionConfiguration() => this.RemoveCustomerContentEncryptionConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property RequesterPaysEnabled. 
        /// <para>
        /// If set to <c>true</c>, allows members assigned to a workgroup to specify Amazon S3
        /// Requester Pays buckets in queries. If set to <c>false</c>, workgroup members cannot
        /// query data from Requester Pays buckets, and queries that retrieve data from Requester
        /// Pays buckets cause an error. The default is <c>false</c>. For more information about
        /// Requester Pays buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? RequesterPaysEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RequesterPaysEnabled property is set.
        /// </summary>
        internal bool IsSetRequesterPaysEnabled() => this.RequesterPaysEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ResultConfigurationUpdates. 
        /// <para>
        /// The result configuration information about the queries in this workgroup that will
        /// be updated. Includes the updated results location and an updated option for encrypting
        /// query results.
        /// </para>
        /// </summary>
        public ResultConfigurationUpdates ResultConfigurationUpdates { get; set; }

        /// <summary>
        /// Checks to see if the ResultConfigurationUpdates property is set.
        /// </summary>
        internal bool IsSetResultConfigurationUpdates() => this.ResultConfigurationUpdates != null;
    }
}
