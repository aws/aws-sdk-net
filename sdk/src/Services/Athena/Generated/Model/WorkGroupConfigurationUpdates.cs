/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The configuration information that will be updated for this workgroup, which includes
    /// the location in Amazon S3 where query results are stored, the encryption option, if
    /// any, used for query results, whether the Amazon CloudWatch Metrics are enabled for
    /// the workgroup, whether the workgroup settings override the client-side settings, and
    /// the data usage limit for the amount of bytes scanned per query, if it is specified.
    /// </summary>
    public partial class WorkGroupConfigurationUpdates
    {
        private long? _bytesScannedCutoffPerQuery;
        private bool? _enforceWorkGroupConfiguration;
        private bool? _publishCloudWatchMetricsEnabled;
        private bool? _removeBytesScannedCutoffPerQuery;
        private ResultConfigurationUpdates _resultConfigurationUpdates;

        /// <summary>
        /// Gets and sets the property BytesScannedCutoffPerQuery. 
        /// <para>
        /// The upper limit (cutoff) for the amount of bytes a single query in a workgroup is
        /// allowed to scan.
        /// </para>
        /// </summary>
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