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
    /// The configuration of the workgroup, which includes the location in Amazon S3 where
    /// query results are stored, the encryption option, if any, used for query results, whether
    /// the Amazon CloudWatch Metrics are enabled for the workgroup and whether workgroup
    /// settings override query settings, and the data usage limit for the amount of data
    /// scanned per query, if it is specified. The workgroup settings override is specified
    /// in EnforceWorkGroupConfiguration (true/false) in the WorkGroupConfiguration. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
    /// </summary>
    public partial class WorkGroupConfiguration
    {
        private long? _bytesScannedCutoffPerQuery;
        private bool? _enforceWorkGroupConfiguration;
        private bool? _publishCloudWatchMetricsEnabled;
        private ResultConfiguration _resultConfiguration;

        /// <summary>
        /// Gets and sets the property BytesScannedCutoffPerQuery. 
        /// <para>
        /// The upper data usage limit (cutoff) for the amount of bytes a single query in a workgroup
        /// is allowed to scan.
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
        /// set to "false", client-side settings are used. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/workgroups-settings-override.html">Workgroup
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
        /// Indicates that the Amazon CloudWatch metrics are enabled for the workgroup.
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
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The configuration for the workgroup, which includes the location in Amazon S3 where
        /// query results are stored and the encryption option, if any, used for query results.
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