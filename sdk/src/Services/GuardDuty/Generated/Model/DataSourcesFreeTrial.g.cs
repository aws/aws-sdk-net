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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about which data sources are enabled for the GuardDuty member
    /// account.
    /// </summary>
    public partial class DataSourcesFreeTrial
    {
        /// <summary>
        /// Gets and sets the property CloudTrail. 
        /// <para>
        /// Describes whether any Amazon Web Services CloudTrail management event logs are enabled
        /// as data sources.
        /// </para>
        /// </summary>
        public DataSourceFreeTrial CloudTrail { get; set; }

        /// <summary>
        /// Checks to see if the CloudTrail property is set.
        /// </summary>
        internal bool IsSetCloudTrail() => this.CloudTrail != null;

        /// <summary>
        /// Gets and sets the property DnsLogs. 
        /// <para>
        /// Describes whether any DNS logs are enabled as data sources.
        /// </para>
        /// </summary>
        public DataSourceFreeTrial DnsLogs { get; set; }

        /// <summary>
        /// Checks to see if the DnsLogs property is set.
        /// </summary>
        internal bool IsSetDnsLogs() => this.DnsLogs != null;

        /// <summary>
        /// Gets and sets the property FlowLogs. 
        /// <para>
        /// Describes whether any VPC Flow logs are enabled as data sources.
        /// </para>
        /// </summary>
        public DataSourceFreeTrial FlowLogs { get; set; }

        /// <summary>
        /// Checks to see if the FlowLogs property is set.
        /// </summary>
        internal bool IsSetFlowLogs() => this.FlowLogs != null;

        /// <summary>
        /// Gets and sets the property Kubernetes. 
        /// <para>
        /// Describes whether any Kubernetes logs are enabled as data sources.
        /// </para>
        /// </summary>
        public KubernetesDataSourceFreeTrial Kubernetes { get; set; }

        /// <summary>
        /// Checks to see if the Kubernetes property is set.
        /// </summary>
        internal bool IsSetKubernetes() => this.Kubernetes != null;

        /// <summary>
        /// Gets and sets the property MalwareProtection. 
        /// <para>
        /// Describes whether Malware Protection is enabled as a data source.
        /// </para>
        /// </summary>
        public MalwareProtectionDataSourceFreeTrial MalwareProtection { get; set; }

        /// <summary>
        /// Checks to see if the MalwareProtection property is set.
        /// </summary>
        internal bool IsSetMalwareProtection() => this.MalwareProtection != null;

        /// <summary>
        /// Gets and sets the property S3Logs. 
        /// <para>
        /// Describes whether any S3 data event logs are enabled as data sources.
        /// </para>
        /// </summary>
        public DataSourceFreeTrial S3Logs { get; set; }

        /// <summary>
        /// Checks to see if the S3Logs property is set.
        /// </summary>
        internal bool IsSetS3Logs() => this.S3Logs != null;
    }
}
