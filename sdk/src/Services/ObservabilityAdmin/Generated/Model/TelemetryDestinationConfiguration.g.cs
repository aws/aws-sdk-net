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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration specifying where and how telemetry data should be delivered for Amazon
    /// Web Services resources.
    /// </summary>
    public partial class TelemetryDestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloudtrailParameters. 
        /// <para>
        ///  Configuration parameters specific to Amazon Web Services CloudTrail when CloudTrail
        /// is the source type. 
        /// </para>
        /// </summary>
        public CloudtrailParameters CloudtrailParameters { get; set; }

        /// <summary>
        /// Checks to see if the CloudtrailParameters property is set.
        /// </summary>
        internal bool IsSetCloudtrailParameters() => this.CloudtrailParameters != null;

        /// <summary>
        /// Gets and sets the property DestinationPattern. 
        /// <para>
        ///  The pattern used to generate the destination path or name, supporting macros like
        /// &lt;resourceId&gt; and &lt;accountId&gt;. 
        /// </para>
        /// </summary>
        public string DestinationPattern { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPattern property is set.
        /// </summary>
        internal bool IsSetDestinationPattern() => this.DestinationPattern != null;

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        ///  The type of destination for the telemetry data (e.g., "Amazon CloudWatch Logs", "S3").
        /// 
        /// </para>
        /// </summary>
        public DestinationType DestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationType property is set.
        /// </summary>
        internal bool IsSetDestinationType() => this.DestinationType != null;

        /// <summary>
        /// Gets and sets the property ELBLoadBalancerLoggingParameters. 
        /// <para>
        ///  Configuration parameters specific to ELB load balancer logging when ELB is the resource
        /// type. 
        /// </para>
        /// </summary>
        public ELBLoadBalancerLoggingParameters ELBLoadBalancerLoggingParameters { get; set; }

        /// <summary>
        /// Checks to see if the ELBLoadBalancerLoggingParameters property is set.
        /// </summary>
        internal bool IsSetELBLoadBalancerLoggingParameters() => this.ELBLoadBalancerLoggingParameters != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the customer-managed Amazon Web Services KMS key
        /// used to encrypt the log groups created during telemetry rule remediation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LogDeliveryParameters. 
        /// <para>
        /// The configuration parameters for log delivery when the resource type supports configurable
        /// log types, such as Amazon Bedrock Knowledge Bases or Elastic Load Balancing Application
        /// Load Balancers.
        /// </para>
        /// </summary>
        public LogDeliveryParameters LogDeliveryParameters { get; set; }

        /// <summary>
        /// Checks to see if the LogDeliveryParameters property is set.
        /// </summary>
        internal bool IsSetLogDeliveryParameters() => this.LogDeliveryParameters != null;

        /// <summary>
        /// Gets and sets the property MskMonitoringParameters. 
        /// <para>
        ///  Configuration parameters specific to MSK monitoring when MSK is the resource type.
        /// 
        /// </para>
        /// </summary>
        public MskMonitoringParameters MskMonitoringParameters { get; set; }

        /// <summary>
        /// Checks to see if the MskMonitoringParameters property is set.
        /// </summary>
        internal bool IsSetMskMonitoringParameters() => this.MskMonitoringParameters != null;

        /// <summary>
        /// Gets and sets the property RetentionInDays. 
        /// <para>
        ///  The number of days to retain the telemetry data in the destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3653)]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionInDays property is set.
        /// </summary>
        internal bool IsSetRetentionInDays() => this.RetentionInDays.HasValue;

        /// <summary>
        /// Gets and sets the property VPCFlowLogParameters. 
        /// <para>
        ///  Configuration parameters specific to VPC Flow Logs when VPC is the resource type.
        /// 
        /// </para>
        /// </summary>
        public VPCFlowLogParameters VPCFlowLogParameters { get; set; }

        /// <summary>
        /// Checks to see if the VPCFlowLogParameters property is set.
        /// </summary>
        internal bool IsSetVPCFlowLogParameters() => this.VPCFlowLogParameters != null;

        /// <summary>
        /// Gets and sets the property WAFLoggingParameters. 
        /// <para>
        ///  Configuration parameters specific to WAF logging when WAF is the resource type. 
        /// </para>
        /// </summary>
        public WAFLoggingParameters WAFLoggingParameters { get; set; }

        /// <summary>
        /// Checks to see if the WAFLoggingParameters property is set.
        /// </summary>
        internal bool IsSetWAFLoggingParameters() => this.WAFLoggingParameters != null;
    }
}
