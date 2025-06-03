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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
    /// The configuration of the workgroup, which includes the location in Amazon S3 where
    /// query and calculation results are stored, the encryption option, if any, used for
    /// query and calculation results, whether the Amazon CloudWatch Metrics are enabled for
    /// the workgroup and whether workgroup settings override query settings, and the data
    /// usage limits for the amount of data scanned per query or per workgroup. The workgroup
    /// settings override is specified in <c>EnforceWorkGroupConfiguration</c> (true/false)
    /// in the <c>WorkGroupConfiguration</c>. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
    /// </summary>
    public partial class WorkGroupConfiguration
    {
        private string _additionalConfiguration;
        private long? _bytesScannedCutoffPerQuery;
        private CustomerContentEncryptionConfiguration _customerContentEncryptionConfiguration;
        private bool? _enableMinimumEncryptionConfiguration;
        private bool? _enforceWorkGroupConfiguration;
        private EngineVersion _engineVersion;
        private string _executionRole;
        private IdentityCenterConfiguration _identityCenterConfiguration;
        private ManagedQueryResultsConfiguration _managedQueryResultsConfiguration;
        private bool? _publishCloudWatchMetricsEnabled;
        private QueryResultsS3AccessGrantsConfiguration _queryResultsS3AccessGrantsConfiguration;
        private bool? _requesterPaysEnabled;
        private ResultConfiguration _resultConfiguration;

        /// <summary>
        /// Gets and sets the property AdditionalConfiguration. 
        /// <para>
        /// Specifies a user defined JSON string that is passed to the notebook engine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AdditionalConfiguration
        {
            get { return this._additionalConfiguration; }
            set { this._additionalConfiguration = value; }
        }

        // Check to see if AdditionalConfiguration property is set
        internal bool IsSetAdditionalConfiguration()
        {
            return this._additionalConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BytesScannedCutoffPerQuery. 
        /// <para>
        /// The upper data usage limit (cutoff) for the amount of bytes a single query in a workgroup
        /// is allowed to scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10000000)]
        public long? BytesScannedCutoffPerQuery
        {
            get { return this._bytesScannedCutoffPerQuery; }
            set { this._bytesScannedCutoffPerQuery = value; }
        }

        // Check to see if BytesScannedCutoffPerQuery property is set
        internal bool IsSetBytesScannedCutoffPerQuery()
        {
            return this._bytesScannedCutoffPerQuery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerContentEncryptionConfiguration. 
        /// <para>
        /// Specifies the KMS key that is used to encrypt the user's data stores in Athena. This
        /// setting does not apply to Athena SQL workgroups.
        /// </para>
        /// </summary>
        public CustomerContentEncryptionConfiguration CustomerContentEncryptionConfiguration
        {
            get { return this._customerContentEncryptionConfiguration; }
            set { this._customerContentEncryptionConfiguration = value; }
        }

        // Check to see if CustomerContentEncryptionConfiguration property is set
        internal bool IsSetCustomerContentEncryptionConfiguration()
        {
            return this._customerContentEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EnableMinimumEncryptionConfiguration. 
        /// <para>
        /// Enforces a minimal level of encryption for the workgroup for query and calculation
        /// results that are written to Amazon S3. When enabled, workgroup users can set encryption
        /// only to the minimum level set by the administrator or higher when they submit queries.
        /// </para>
        ///  
        /// <para>
        /// The <c>EnforceWorkGroupConfiguration</c> setting takes precedence over the <c>EnableMinimumEncryptionConfiguration</c>
        /// flag. This means that if <c>EnforceWorkGroupConfiguration</c> is true, the <c>EnableMinimumEncryptionConfiguration</c>
        /// flag is ignored, and the workgroup configuration for encryption is used.
        /// </para>
        /// </summary>
        public bool? EnableMinimumEncryptionConfiguration
        {
            get { return this._enableMinimumEncryptionConfiguration; }
            set { this._enableMinimumEncryptionConfiguration = value; }
        }

        // Check to see if EnableMinimumEncryptionConfiguration property is set
        internal bool IsSetEnableMinimumEncryptionConfiguration()
        {
            return this._enableMinimumEncryptionConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnforceWorkGroupConfiguration. 
        /// <para>
        /// If set to "true", the settings for the workgroup override client-side settings. If
        /// set to "false", client-side settings are used. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool? EnforceWorkGroupConfiguration
        {
            get { return this._enforceWorkGroupConfiguration; }
            set { this._enforceWorkGroupConfiguration = value; }
        }

        // Check to see if EnforceWorkGroupConfiguration property is set
        internal bool IsSetEnforceWorkGroupConfiguration()
        {
            return this._enforceWorkGroupConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version that all queries running on the workgroup use. Queries on the <c>AmazonAthenaPreviewFunctionality</c>
        /// workgroup run on the preview engine regardless of this setting.
        /// </para>
        /// </summary>
        public EngineVersion EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The ARN of the execution role used to access user resources for Spark sessions and
        /// IAM Identity Center enabled workgroups. This property applies only to Spark enabled
        /// workgroups and IAM Identity Center enabled workgroups. The property is required for
        /// IAM Identity Center enabled workgroups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        /// Specifies whether the workgroup is IAM Identity Center supported.
        /// </para>
        /// </summary>
        public IdentityCenterConfiguration IdentityCenterConfiguration
        {
            get { return this._identityCenterConfiguration; }
            set { this._identityCenterConfiguration = value; }
        }

        // Check to see if IdentityCenterConfiguration property is set
        internal bool IsSetIdentityCenterConfiguration()
        {
            return this._identityCenterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedQueryResultsConfiguration. 
        /// <para>
        ///  The configuration for storing results in Athena owned storage, which includes whether
        /// this feature is enabled; whether encryption configuration, if any, is used for encrypting
        /// query results. 
        /// </para>
        /// </summary>
        public ManagedQueryResultsConfiguration ManagedQueryResultsConfiguration
        {
            get { return this._managedQueryResultsConfiguration; }
            set { this._managedQueryResultsConfiguration = value; }
        }

        // Check to see if ManagedQueryResultsConfiguration property is set
        internal bool IsSetManagedQueryResultsConfiguration()
        {
            return this._managedQueryResultsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PublishCloudWatchMetricsEnabled. 
        /// <para>
        /// Indicates that the Amazon CloudWatch metrics are enabled for the workgroup.
        /// </para>
        /// </summary>
        public bool? PublishCloudWatchMetricsEnabled
        {
            get { return this._publishCloudWatchMetricsEnabled; }
            set { this._publishCloudWatchMetricsEnabled = value; }
        }

        // Check to see if PublishCloudWatchMetricsEnabled property is set
        internal bool IsSetPublishCloudWatchMetricsEnabled()
        {
            return this._publishCloudWatchMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryResultsS3AccessGrantsConfiguration. 
        /// <para>
        /// Specifies whether Amazon S3 access grants are enabled for query results.
        /// </para>
        /// </summary>
        public QueryResultsS3AccessGrantsConfiguration QueryResultsS3AccessGrantsConfiguration
        {
            get { return this._queryResultsS3AccessGrantsConfiguration; }
            set { this._queryResultsS3AccessGrantsConfiguration = value; }
        }

        // Check to see if QueryResultsS3AccessGrantsConfiguration property is set
        internal bool IsSetQueryResultsS3AccessGrantsConfiguration()
        {
            return this._queryResultsS3AccessGrantsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterPaysEnabled. 
        /// <para>
        /// If set to <c>true</c>, allows members assigned to a workgroup to reference Amazon
        /// S3 Requester Pays buckets in queries. If set to <c>false</c>, workgroup members cannot
        /// query data from Requester Pays buckets, and queries that retrieve data from Requester
        /// Pays buckets cause an error. The default is <c>false</c>. For more information about
        /// Requester Pays buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? RequesterPaysEnabled
        {
            get { return this._requesterPaysEnabled; }
            set { this._requesterPaysEnabled = value; }
        }

        // Check to see if RequesterPaysEnabled property is set
        internal bool IsSetRequesterPaysEnabled()
        {
            return this._requesterPaysEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The configuration for the workgroup, which includes the location in Amazon S3 where
        /// query and calculation results are stored and the encryption option, if any, used for
        /// query and calculation results. To run the query, you must specify the query results
        /// location using one of the ways: either in the workgroup using this setting, or for
        /// individual queries (client-side), using <a>ResultConfiguration$OutputLocation</a>.
        /// If none of them is set, Athena issues an error that no output location is provided.
        /// </para>
        /// </summary>
        public ResultConfiguration ResultConfiguration
        {
            get { return this._resultConfiguration; }
            set { this._resultConfiguration = value; }
        }

        // Check to see if ResultConfiguration property is set
        internal bool IsSetResultConfiguration()
        {
            return this._resultConfiguration != null;
        }

    }
}