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
        private string _additionalConfiguration;
        private long? _bytesScannedCutoffPerQuery;
        private CustomerContentEncryptionConfiguration _customerContentEncryptionConfiguration;
        private bool? _enableMinimumEncryptionConfiguration;
        private bool? _enforceWorkGroupConfiguration;
        private EngineVersion _engineVersion;
        private string _executionRole;
        private bool? _publishCloudWatchMetricsEnabled;
        private bool? _removeBytesScannedCutoffPerQuery;
        private bool? _removeCustomerContentEncryptionConfiguration;
        private bool? _requesterPaysEnabled;
        private ResultConfigurationUpdates _resultConfigurationUpdates;

        /// <summary>
        /// Gets and sets the property AdditionalConfiguration. 
        /// <para>
        /// Contains a user defined string in JSON format for a Spark-enabled workgroup.
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
        /// The upper limit (cutoff) for the amount of bytes a single query in a workgroup is
        /// allowed to scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10000000)]
        public long BytesScannedCutoffPerQuery
        {
            get { return this._bytesScannedCutoffPerQuery.GetValueOrDefault(); }
            set { this._bytesScannedCutoffPerQuery = value; }
        }

        // Check to see if BytesScannedCutoffPerQuery property is set
        internal bool IsSetBytesScannedCutoffPerQuery()
        {
            return this._bytesScannedCutoffPerQuery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerContentEncryptionConfiguration.
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
        /// This setting does not apply to Spark-enabled workgroups.
        /// </para>
        ///  
        /// <para>
        /// The <code>EnforceWorkGroupConfiguration</code> setting takes precedence over the <code>EnableMinimumEncryptionConfiguration</code>
        /// flag. This means that if <code>EnforceWorkGroupConfiguration</code> is true, the <code>EnableMinimumEncryptionConfiguration</code>
        /// flag is ignored, and the workgroup configuration for encryption is used.
        /// </para>
        /// </summary>
        public bool EnableMinimumEncryptionConfiguration
        {
            get { return this._enableMinimumEncryptionConfiguration.GetValueOrDefault(); }
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
        /// set to "false" client-side settings are used. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
        /// Settings Override Client-Side Settings</a>.
        /// </para>
        /// </summary>
        public bool EnforceWorkGroupConfiguration
        {
            get { return this._enforceWorkGroupConfiguration.GetValueOrDefault(); }
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
        /// The engine version requested when a workgroup is updated. After the update, all queries
        /// on the workgroup run on the requested engine version. If no value was previously set,
        /// the default is Auto. Queries on the <code>AmazonAthenaPreviewFunctionality</code>
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
        /// Contains the ARN of the execution role for the workgroup
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
        /// Gets and sets the property PublishCloudWatchMetricsEnabled. 
        /// <para>
        /// Indicates whether this workgroup enables publishing metrics to Amazon CloudWatch.
        /// </para>
        /// </summary>
        public bool PublishCloudWatchMetricsEnabled
        {
            get { return this._publishCloudWatchMetricsEnabled.GetValueOrDefault(); }
            set { this._publishCloudWatchMetricsEnabled = value; }
        }

        // Check to see if PublishCloudWatchMetricsEnabled property is set
        internal bool IsSetPublishCloudWatchMetricsEnabled()
        {
            return this._publishCloudWatchMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveBytesScannedCutoffPerQuery. 
        /// <para>
        /// Indicates that the data usage control limit per query is removed. <a>WorkGroupConfiguration$BytesScannedCutoffPerQuery</a>
        /// 
        /// </para>
        /// </summary>
        public bool RemoveBytesScannedCutoffPerQuery
        {
            get { return this._removeBytesScannedCutoffPerQuery.GetValueOrDefault(); }
            set { this._removeBytesScannedCutoffPerQuery = value; }
        }

        // Check to see if RemoveBytesScannedCutoffPerQuery property is set
        internal bool IsSetRemoveBytesScannedCutoffPerQuery()
        {
            return this._removeBytesScannedCutoffPerQuery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveCustomerContentEncryptionConfiguration. 
        /// <para>
        /// Removes content encryption configuration for a workgroup.
        /// </para>
        /// </summary>
        public bool RemoveCustomerContentEncryptionConfiguration
        {
            get { return this._removeCustomerContentEncryptionConfiguration.GetValueOrDefault(); }
            set { this._removeCustomerContentEncryptionConfiguration = value; }
        }

        // Check to see if RemoveCustomerContentEncryptionConfiguration property is set
        internal bool IsSetRemoveCustomerContentEncryptionConfiguration()
        {
            return this._removeCustomerContentEncryptionConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterPaysEnabled. 
        /// <para>
        /// If set to <code>true</code>, allows members assigned to a workgroup to specify Amazon
        /// S3 Requester Pays buckets in queries. If set to <code>false</code>, workgroup members
        /// cannot query data from Requester Pays buckets, and queries that retrieve data from
        /// Requester Pays buckets cause an error. The default is <code>false</code>. For more
        /// information about Requester Pays buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool RequesterPaysEnabled
        {
            get { return this._requesterPaysEnabled.GetValueOrDefault(); }
            set { this._requesterPaysEnabled = value; }
        }

        // Check to see if RequesterPaysEnabled property is set
        internal bool IsSetRequesterPaysEnabled()
        {
            return this._requesterPaysEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultConfigurationUpdates. 
        /// <para>
        /// The result configuration information about the queries in this workgroup that will
        /// be updated. Includes the updated results location and an updated option for encrypting
        /// query results.
        /// </para>
        /// </summary>
        public ResultConfigurationUpdates ResultConfigurationUpdates
        {
            get { return this._resultConfigurationUpdates; }
            set { this._resultConfigurationUpdates = value; }
        }

        // Check to see if ResultConfigurationUpdates property is set
        internal bool IsSetResultConfigurationUpdates()
        {
            return this._resultConfigurationUpdates != null;
        }

    }
}