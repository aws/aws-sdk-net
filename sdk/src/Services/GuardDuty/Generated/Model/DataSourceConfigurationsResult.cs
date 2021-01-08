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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information on the status of data sources for the detector.
    /// </summary>
    public partial class DataSourceConfigurationsResult
    {
        private CloudTrailConfigurationResult _cloudTrail;
        private DNSLogsConfigurationResult _dnsLogs;
        private FlowLogsConfigurationResult _flowLogs;
        private S3LogsConfigurationResult _s3Logs;

        /// <summary>
        /// Gets and sets the property CloudTrail. 
        /// <para>
        /// An object that contains information on the status of CloudTrail as a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CloudTrailConfigurationResult CloudTrail
        {
            get { return this._cloudTrail; }
            set { this._cloudTrail = value; }
        }

        // Check to see if CloudTrail property is set
        internal bool IsSetCloudTrail()
        {
            return this._cloudTrail != null;
        }

        /// <summary>
        /// Gets and sets the property DNSLogs. 
        /// <para>
        /// An object that contains information on the status of DNS logs as a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DNSLogsConfigurationResult DNSLogs
        {
            get { return this._dnsLogs; }
            set { this._dnsLogs = value; }
        }

        // Check to see if DNSLogs property is set
        internal bool IsSetDNSLogs()
        {
            return this._dnsLogs != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogs. 
        /// <para>
        /// An object that contains information on the status of VPC flow logs as a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowLogsConfigurationResult FlowLogs
        {
            get { return this._flowLogs; }
            set { this._flowLogs = value; }
        }

        // Check to see if FlowLogs property is set
        internal bool IsSetFlowLogs()
        {
            return this._flowLogs != null;
        }

        /// <summary>
        /// Gets and sets the property S3Logs. 
        /// <para>
        /// An object that contains information on the status of S3 Data event logs as a data
        /// source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3LogsConfigurationResult S3Logs
        {
            get { return this._s3Logs; }
            set { this._s3Logs = value; }
        }

        // Check to see if S3Logs property is set
        internal bool IsSetS3Logs()
        {
            return this._s3Logs != null;
        }

    }
}