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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the CreateApplicationStatusCheck operation.
    /// Creates an application status check for monitoring the health of applications running
    /// on your instances. You can configure the protocol, port, path, and thresholds for
    /// the health check. The following rules apply:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You can create a maximum of 50 application status checks per account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Health checks do not start until you associate the check with instances or tags using
    /// <c>AssociateApplicationStatusCheck</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>Timeout</c> value must be less than the <c>Interval</c> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>Path</c> must start with a forward slash (<c>/</c>). Default: <c>/</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you do not specify <c>Aggregation</c>, it defaults to <c>included</c>, which means
    /// the check contributes to the instance-level application status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Default values: <c>Interval</c> is 60 seconds, <c>Timeout</c> is 6 seconds, <c>FailureThreshold</c>
    /// is 2, <c>SuccessThreshold</c> is 2, <c>StatusCodeMatcher</c> is <c>200</c>, <c>InitializationGracePeriodSeconds</c>
    /// is 300 seconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can tag the application status check during creation. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
    /// your Amazon EC2 resources</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateApplicationStatusCheckRequest : AmazonEC2Request
    {
        private AggregationStatusEnum _aggregation;
        private string _clientToken;
        private int? _deviceIndex;
        private bool? _dryRun;
        private int? _failureThreshold;
        private List<HealthCheckPathRequestObject> _healthCheckPaths = AWSConfigs.InitializeCollections ? new List<HealthCheckPathRequestObject>() : null;
        private int? _initializationGracePeriodSeconds;
        private int? _interval;
        private IpScopeEnum _ipScope;
        private IpVersionEnum _ipVersion;
        private string _path;
        private int? _port;
        private NetworkProtocolEnum _protocol;
        private string _statusCodeMatcher;
        private int? _successThreshold;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation setting for the application status check. When set to <c>included</c>,
        /// the result of this check contributes to the instance-level application status reported
        /// by <c>DescribeApplicationStatus</c>. When set to <c>excluded</c>, the check runs independently
        /// and does not affect the instance-level status. Valid values: <c>included</c> | <c>excluded</c>.
        /// </para>
        /// </summary>
        public AggregationStatusEnum Aggregation
        {
            get { return this._aggregation; }
            set { this._aggregation = value; }
        }

        // Check to see if Aggregation property is set
        internal bool IsSetAggregation()
        {
            return this._aggregation != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The index of the network device to use for the health check. The value must be greater
        /// than or equal to 0.
        /// </para>
        /// </summary>
        public int? DeviceIndex
        {
            get { return this._deviceIndex; }
            set { this._deviceIndex = value; }
        }

        // Check to see if DeviceIndex property is set
        internal bool IsSetDeviceIndex()
        {
            return this._deviceIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureThreshold. 
        /// <para>
        /// The number of consecutive failed health checks before the application status is considered
        /// impaired. The value must be greater than 0.
        /// </para>
        /// </summary>
        public int? FailureThreshold
        {
            get { return this._failureThreshold; }
            set { this._failureThreshold = value; }
        }

        // Check to see if FailureThreshold property is set
        internal bool IsSetFailureThreshold()
        {
            return this._failureThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckPaths. 
        /// <para>
        /// The health check paths to use for the application status check. Health check paths
        /// define the network path from a source subnet to one or more destination subnets for
        /// cross-Availability Zone or Availability Zone to Local Zone health checking. If omitted,
        /// health checks are performed in the same subnet as the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HealthCheckPathRequestObject> HealthCheckPaths
        {
            get { return this._healthCheckPaths; }
            set { this._healthCheckPaths = value; }
        }

        // Check to see if HealthCheckPaths property is set
        internal bool IsSetHealthCheckPaths()
        {
            return this._healthCheckPaths != null && (this._healthCheckPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InitializationGracePeriodSeconds. 
        /// <para>
        /// The number of seconds to wait before starting health checks after an instance is launched.
        /// Valid values: 1 to 600.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=600)]
        public int? InitializationGracePeriodSeconds
        {
            get { return this._initializationGracePeriodSeconds; }
            set { this._initializationGracePeriodSeconds = value; }
        }

        // Check to see if InitializationGracePeriodSeconds property is set
        internal bool IsSetInitializationGracePeriodSeconds()
        {
            return this._initializationGracePeriodSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval, in seconds, between health checks. Valid value: 60.
        /// </para>
        /// </summary>
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpScope. 
        /// <para>
        /// The IP scope to use for the health check. Valid value: <c>private</c>.
        /// </para>
        /// </summary>
        public IpScopeEnum IpScope
        {
            get { return this._ipScope; }
            set { this._ipScope = value; }
        }

        // Check to see if IpScope property is set
        internal bool IsSetIpScope()
        {
            return this._ipScope != null;
        }

        /// <summary>
        /// Gets and sets the property IpVersion. 
        /// <para>
        /// The IP version to use for the health check. Valid values: <c>ipv4</c> and <c>ipv6</c>.
        /// </para>
        /// </summary>
        public IpVersionEnum IpVersion
        {
            get { return this._ipVersion; }
            set { this._ipVersion = value; }
        }

        // Check to see if IpVersion property is set
        internal bool IsSetIpVersion()
        {
            return this._ipVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The URL path to use for the health check HTTP request (for example, <c>/health</c>
        /// or <c>/status</c>).
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port to use for the health check. Valid values: 1 to 65535.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use for the health check. Valid values: <c>http</c> | <c>https</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkProtocolEnum Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCodeMatcher. 
        /// <para>
        /// The HTTP status codes that indicate a successful health check response. Specify a
        /// comma-separated list of individual status codes or ranges, for example, <c>200,202,300-399</c>.
        /// For a range, the first value must be less than the second value. Maximum length: 64
        /// characters. Default: <c>200</c>.
        /// </para>
        /// </summary>
        public string StatusCodeMatcher
        {
            get { return this._statusCodeMatcher; }
            set { this._statusCodeMatcher = value; }
        }

        // Check to see if StatusCodeMatcher property is set
        internal bool IsSetStatusCodeMatcher()
        {
            return this._statusCodeMatcher != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessThreshold. 
        /// <para>
        /// The number of consecutive successful health checks before the application status is
        /// considered healthy. The value must be greater than 0.
        /// </para>
        /// </summary>
        public int? SuccessThreshold
        {
            get { return this._successThreshold; }
            set { this._successThreshold = value; }
        }

        // Check to see if SuccessThreshold property is set
        internal bool IsSetSuccessThreshold()
        {
            return this._successThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the application status check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time, in seconds, to wait for a health check response before considering
        /// it failed. Valid values: 1 to 30. The value must be less than <c>Interval</c>.
        /// </para>
        /// </summary>
        public int? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

    }
}