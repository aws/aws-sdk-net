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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about which data sources are enabled for the GuardDuty member
    /// account.
    /// </summary>
    public partial class DataSourcesFreeTrial
    {
        private DataSourceFreeTrial _cloudTrail;
        private DataSourceFreeTrial _dnsLogs;
        private DataSourceFreeTrial _flowLogs;
        private KubernetesDataSourceFreeTrial _kubernetes;
        private MalwareProtectionDataSourceFreeTrial _malwareProtection;
        private DataSourceFreeTrial _s3Logs;

        /// <summary>
        /// Gets and sets the property CloudTrail. 
        /// <para>
        /// Describes whether any Amazon Web Services CloudTrail management event logs are enabled
        /// as data sources.
        /// </para>
        /// </summary>
        public DataSourceFreeTrial CloudTrail
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
        /// Gets and sets the property DnsLogs. 
        /// <para>
        /// Describes whether any DNS logs are enabled as data sources.
        /// </para>
        /// </summary>
        public DataSourceFreeTrial DnsLogs
        {
            get { return this._dnsLogs; }
            set { this._dnsLogs = value; }
        }

        // Check to see if DnsLogs property is set
        internal bool IsSetDnsLogs()
        {
            return this._dnsLogs != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogs. 
        /// <para>
        /// Describes whether any VPC Flow logs are enabled as data sources.
        /// </para>
        /// </summary>
        public DataSourceFreeTrial FlowLogs
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
        /// Gets and sets the property Kubernetes. 
        /// <para>
        /// Describes whether any Kubernetes logs are enabled as data sources.
        /// </para>
        /// </summary>
        public KubernetesDataSourceFreeTrial Kubernetes
        {
            get { return this._kubernetes; }
            set { this._kubernetes = value; }
        }

        // Check to see if Kubernetes property is set
        internal bool IsSetKubernetes()
        {
            return this._kubernetes != null;
        }

        /// <summary>
        /// Gets and sets the property MalwareProtection. 
        /// <para>
        /// Describes whether Malware Protection is enabled as a data source.
        /// </para>
        /// </summary>
        public MalwareProtectionDataSourceFreeTrial MalwareProtection
        {
            get { return this._malwareProtection; }
            set { this._malwareProtection = value; }
        }

        // Check to see if MalwareProtection property is set
        internal bool IsSetMalwareProtection()
        {
            return this._malwareProtection != null;
        }

        /// <summary>
        /// Gets and sets the property S3Logs. 
        /// <para>
        /// Describes whether any S3 data event logs are enabled as data sources.
        /// </para>
        /// </summary>
        public DataSourceFreeTrial S3Logs
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