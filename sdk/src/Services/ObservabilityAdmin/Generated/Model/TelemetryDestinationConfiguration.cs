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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
        private CloudtrailParameters _cloudtrailParameters;
        private string _destinationPattern;
        private DestinationType _destinationType;
        private ELBLoadBalancerLoggingParameters _elbLoadBalancerLoggingParameters;
        private LogDeliveryParameters _logDeliveryParameters;
        private int? _retentionInDays;
        private VPCFlowLogParameters _vpcFlowLogParameters;
        private WAFLoggingParameters _wafLoggingParameters;

        /// <summary>
        /// Gets and sets the property CloudtrailParameters. 
        /// <para>
        ///  Configuration parameters specific to Amazon Web Services CloudTrail when CloudTrail
        /// is the source type. 
        /// </para>
        /// </summary>
        public CloudtrailParameters CloudtrailParameters
        {
            get { return this._cloudtrailParameters; }
            set { this._cloudtrailParameters = value; }
        }

        // Check to see if CloudtrailParameters property is set
        internal bool IsSetCloudtrailParameters()
        {
            return this._cloudtrailParameters != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPattern. 
        /// <para>
        ///  The pattern used to generate the destination path or name, supporting macros like
        /// &lt;resourceId&gt; and &lt;accountId&gt;. 
        /// </para>
        /// </summary>
        public string DestinationPattern
        {
            get { return this._destinationPattern; }
            set { this._destinationPattern = value; }
        }

        // Check to see if DestinationPattern property is set
        internal bool IsSetDestinationPattern()
        {
            return this._destinationPattern != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        ///  The type of destination for the telemetry data (e.g., "Amazon CloudWatch Logs", "S3").
        /// 
        /// </para>
        /// </summary>
        public DestinationType DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }

        // Check to see if DestinationType property is set
        internal bool IsSetDestinationType()
        {
            return this._destinationType != null;
        }

        /// <summary>
        /// Gets and sets the property ELBLoadBalancerLoggingParameters. 
        /// <para>
        ///  Configuration parameters specific to ELB load balancer logging when ELB is the resource
        /// type. 
        /// </para>
        /// </summary>
        public ELBLoadBalancerLoggingParameters ELBLoadBalancerLoggingParameters
        {
            get { return this._elbLoadBalancerLoggingParameters; }
            set { this._elbLoadBalancerLoggingParameters = value; }
        }

        // Check to see if ELBLoadBalancerLoggingParameters property is set
        internal bool IsSetELBLoadBalancerLoggingParameters()
        {
            return this._elbLoadBalancerLoggingParameters != null;
        }

        /// <summary>
        /// Gets and sets the property LogDeliveryParameters. 
        /// <para>
        /// Configuration parameters specific to Amazon Bedrock AgentCore logging when Amazon
        /// Bedrock AgentCore is the resource type.
        /// </para>
        /// </summary>
        public LogDeliveryParameters LogDeliveryParameters
        {
            get { return this._logDeliveryParameters; }
            set { this._logDeliveryParameters = value; }
        }

        // Check to see if LogDeliveryParameters property is set
        internal bool IsSetLogDeliveryParameters()
        {
            return this._logDeliveryParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionInDays. 
        /// <para>
        ///  The number of days to retain the telemetry data in the destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3653)]
        public int RetentionInDays
        {
            get { return this._retentionInDays.GetValueOrDefault(); }
            set { this._retentionInDays = value; }
        }

        // Check to see if RetentionInDays property is set
        internal bool IsSetRetentionInDays()
        {
            return this._retentionInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VPCFlowLogParameters. 
        /// <para>
        ///  Configuration parameters specific to VPC Flow Logs when VPC is the resource type.
        /// 
        /// </para>
        /// </summary>
        public VPCFlowLogParameters VPCFlowLogParameters
        {
            get { return this._vpcFlowLogParameters; }
            set { this._vpcFlowLogParameters = value; }
        }

        // Check to see if VPCFlowLogParameters property is set
        internal bool IsSetVPCFlowLogParameters()
        {
            return this._vpcFlowLogParameters != null;
        }

        /// <summary>
        /// Gets and sets the property WAFLoggingParameters. 
        /// <para>
        ///  Configuration parameters specific to WAF logging when WAF is the resource type. 
        /// </para>
        /// </summary>
        public WAFLoggingParameters WAFLoggingParameters
        {
            get { return this._wafLoggingParameters; }
            set { this._wafLoggingParameters = value; }
        }

        // Check to see if WAFLoggingParameters property is set
        internal bool IsSetWAFLoggingParameters()
        {
            return this._wafLoggingParameters != null;
        }

    }
}