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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyApplicationStatusCheck operation. Modifies
    /// an existing application status check. You can update the protocol, port, path, thresholds,
    /// and other configuration settings. The following rules apply: <ul> <li> <para> The
    /// application status check must exist and belong to your account. </para> </li> <li>
    /// <para> Changes take effect on the next health check interval. </para> </li> </ul>
    /// </summary>
    public partial class ModifyApplicationStatusCheckRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation setting for the application status check. When set to <c>included</c>,
        /// the result of this check contributes to the instance-level application status reported
        /// by <c>DescribeApplicationStatus</c>. When set to <c>excluded</c>, the check runs independently
        /// and does not affect the instance-level status. Valid values: <c>included</c> | <c>excluded</c>.
        /// </para>
        /// </summary>
        public AggregationStatusEnum Aggregation { get; set; }

        /// <summary>
        /// Checks to see if the Aggregation property is set.
        /// </summary>
        internal bool IsSetAggregation() => this.Aggregation != null;

        /// <summary>
        /// Gets and sets the property ApplicationStatusCheckId. 
        /// <para>
        /// The ID of the application status check to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationStatusCheckId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationStatusCheckId property is set.
        /// </summary>
        internal bool IsSetApplicationStatusCheckId() => this.ApplicationStatusCheckId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you retry a request with the same token, the service
        /// ignores the request but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The index of the network device to use for the health check. The value must be greater
        /// than or equal to 0.
        /// </para>
        /// </summary>
        public int? DeviceIndex { get; set; }

        /// <summary>
        /// Checks to see if the DeviceIndex property is set.
        /// </summary>
        internal bool IsSetDeviceIndex() => this.DeviceIndex.HasValue;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property FailureThreshold. 
        /// <para>
        /// The number of consecutive failed health checks before the application status is considered
        /// impaired. The value must be greater than 0.
        /// </para>
        /// </summary>
        public int? FailureThreshold { get; set; }

        /// <summary>
        /// Checks to see if the FailureThreshold property is set.
        /// </summary>
        internal bool IsSetFailureThreshold() => this.FailureThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckPaths. 
        /// <para>
        /// The health check paths to use for the application status check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HealthCheckPathRequestObject> HealthCheckPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<HealthCheckPathRequestObject>() : null;

        /// <summary>
        /// Checks to see if the HealthCheckPaths property is set.
        /// </summary>
        internal bool IsSetHealthCheckPaths() => this.HealthCheckPaths != null && (this.HealthCheckPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InitializationGracePeriodSeconds. 
        /// <para>
        /// The number of seconds to wait before starting health checks after an instance is launched.
        /// Valid values: 1 to 600.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1, Max = 600)]
        public int? InitializationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Checks to see if the InitializationGracePeriodSeconds property is set.
        /// </summary>
        internal bool IsSetInitializationGracePeriodSeconds() => this.InitializationGracePeriodSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval, in seconds, between health checks. Valid value: 60.
        /// </para>
        /// </summary>
        public int? Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval.HasValue;

        /// <summary>
        /// Gets and sets the property IpScope. 
        /// <para>
        /// The IP scope to use for the health check. Valid value: <c>private</c>.
        /// </para>
        /// </summary>
        public IpScopeEnum IpScope { get; set; }

        /// <summary>
        /// Checks to see if the IpScope property is set.
        /// </summary>
        internal bool IsSetIpScope() => this.IpScope != null;

        /// <summary>
        /// Gets and sets the property IpVersion. 
        /// <para>
        /// The IP version to use for the health check. Valid values: <c>ipv4</c> and <c>ipv6</c>.
        /// </para>
        /// </summary>
        public IpVersionEnum IpVersion { get; set; }

        /// <summary>
        /// Checks to see if the IpVersion property is set.
        /// </summary>
        internal bool IsSetIpVersion() => this.IpVersion != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The URL path to use for the health check HTTP request (for example, <c>/health</c>
        /// or <c>/status</c>).
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port to use for the health check. Valid values: 1 to 65535.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use for the health check. Valid values: <c>http</c> | <c>https</c>.
        /// </para>
        /// </summary>
        public NetworkProtocolEnum Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property StatusCodeMatcher. 
        /// <para>
        /// The HTTP status codes that indicate a successful health check response. Specify a
        /// comma-separated list of individual status codes or ranges, for example, <c>200,202,300-399</c>.
        /// For a range, the first value must be less than the second value. Maximum length: 64
        /// characters.
        /// </para>
        /// </summary>
        public string StatusCodeMatcher { get; set; }

        /// <summary>
        /// Checks to see if the StatusCodeMatcher property is set.
        /// </summary>
        internal bool IsSetStatusCodeMatcher() => this.StatusCodeMatcher != null;

        /// <summary>
        /// Gets and sets the property SuccessThreshold. 
        /// <para>
        /// The number of consecutive successful health checks before the application status is
        /// considered healthy. The value must be greater than 0.
        /// </para>
        /// </summary>
        public int? SuccessThreshold { get; set; }

        /// <summary>
        /// Checks to see if the SuccessThreshold property is set.
        /// </summary>
        internal bool IsSetSuccessThreshold() => this.SuccessThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time, in seconds, to wait for a health check response before considering
        /// it failed. Valid values: 1 to 30. The value must be less than <c>Interval</c>.
        /// </para>
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;
    }
}
