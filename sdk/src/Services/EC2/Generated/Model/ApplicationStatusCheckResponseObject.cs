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
    /// Describes an application status check.
    /// </summary>
    public partial class ApplicationStatusCheckResponseObject
    {
        private AggregationStatusEnum _aggregation;
        private string _applicationStatusCheckId;
        private DateTime? _creationTime;
        private DateTime? _deletionTime;
        private int? _deviceIndex;
        private int? _failureThreshold;
        private List<HealthCheckPathResponseObject> _healthCheckPaths = AWSConfigs.InitializeCollections ? new List<HealthCheckPathResponseObject>() : null;
        private int? _initializationGracePeriodSeconds;
        private int? _interval;
        private IpScopeEnum _ipScope;
        private IpVersionEnum _ipVersion;
        private DateTime? _lastUpdatedAt;
        private DateTime? _modifyTime;
        private string _path;
        private int? _port;
        private NetworkProtocolEnum _protocol;
        private string _statusCodeMatcher;
        private int? _successThreshold;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<CustomTagKeyValueResponsePair> _targetTagAssociations = AWSConfigs.InitializeCollections ? new List<CustomTagKeyValueResponsePair>() : null;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation setting for the application status check. When set to <c>included</c>,
        /// the result of this check contributes to the instance-level application status. When
        /// set to <c>excluded</c>, the check runs independently and does not affect the instance-level
        /// status.
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
        /// Gets and sets the property ApplicationStatusCheckId. 
        /// <para>
        /// The ID of the application status check.
        /// </para>
        /// </summary>
        public string ApplicationStatusCheckId
        {
            get { return this._applicationStatusCheckId; }
            set { this._applicationStatusCheckId = value; }
        }

        // Check to see if ApplicationStatusCheckId property is set
        internal bool IsSetApplicationStatusCheckId()
        {
            return this._applicationStatusCheckId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when the application status check was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The date and time when the application status check was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletionTime
        {
            get { return this._deletionTime; }
            set { this._deletionTime = value; }
        }

        // Check to see if DeletionTime property is set
        internal bool IsSetDeletionTime()
        {
            return this._deletionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The index of the network device used for the health check. The value is greater than
        /// or equal to 0.
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
        /// The health check paths for the application status check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HealthCheckPathResponseObject> HealthCheckPaths
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
        /// The IP scope used for the health check.
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
        /// The IP version used for the health check.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the application status check was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifyTime. 
        /// <para>
        /// The date and time when the application status check was last modified.
        /// </para>
        /// </summary>
        public DateTime? ModifyTime
        {
            get { return this._modifyTime; }
            set { this._modifyTime = value; }
        }

        // Check to see if ModifyTime property is set
        internal bool IsSetModifyTime()
        {
            return this._modifyTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The URL path used for the health check HTTP request.
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
        /// The port used for the health check.
        /// </para>
        /// </summary>
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
        /// The protocol used for the health check.
        /// </para>
        /// </summary>
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
        /// The comma-separated list of individual HTTP status codes or ranges that indicate a
        /// successful health check response.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the application status check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetTagAssociations. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">tags</a>
        /// associated with the application status check. Instances with these tags are automatically
        /// monitored by this check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomTagKeyValueResponsePair> TargetTagAssociations
        {
            get { return this._targetTagAssociations; }
            set { this._targetTagAssociations = value; }
        }

        // Check to see if TargetTagAssociations property is set
        internal bool IsSetTargetTagAssociations()
        {
            return this._targetTagAssociations != null && (this._targetTagAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time, in seconds, to wait for a health check response. Valid values:
        /// 1 to 30.
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