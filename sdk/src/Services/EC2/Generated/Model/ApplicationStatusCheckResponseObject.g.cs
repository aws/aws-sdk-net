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
    /// Describes an application status check.
    /// </summary>
    public partial class ApplicationStatusCheckResponseObject
    {
        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation setting for the application status check. When set to <c>included</c>,
        /// the result of this check contributes to the instance-level application status. When
        /// set to <c>excluded</c>, the check runs independently and does not affect the instance-level
        /// status.
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
        /// The ID of the application status check.
        /// </para>
        /// </summary>
        public string ApplicationStatusCheckId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationStatusCheckId property is set.
        /// </summary>
        internal bool IsSetApplicationStatusCheckId() => this.ApplicationStatusCheckId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when the application status check was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The date and time when the application status check was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletionTime { get; set; }

        /// <summary>
        /// Checks to see if the DeletionTime property is set.
        /// </summary>
        internal bool IsSetDeletionTime() => this.DeletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The index of the network device used for the health check. The value is greater than
        /// or equal to 0.
        /// </para>
        /// </summary>
        public int? DeviceIndex { get; set; }

        /// <summary>
        /// Checks to see if the DeviceIndex property is set.
        /// </summary>
        internal bool IsSetDeviceIndex() => this.DeviceIndex.HasValue;

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
        /// The health check paths for the application status check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HealthCheckPathResponseObject> HealthCheckPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<HealthCheckPathResponseObject>() : null;

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
        /// The IP scope used for the health check.
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
        /// The IP version used for the health check.
        /// </para>
        /// </summary>
        public IpVersionEnum IpVersion { get; set; }

        /// <summary>
        /// Checks to see if the IpVersion property is set.
        /// </summary>
        internal bool IsSetIpVersion() => this.IpVersion != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the application status check was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ModifyTime. 
        /// <para>
        /// The date and time when the application status check was last modified.
        /// </para>
        /// </summary>
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// Checks to see if the ModifyTime property is set.
        /// </summary>
        internal bool IsSetModifyTime() => this.ModifyTime.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The URL path used for the health check HTTP request.
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
        /// The port used for the health check.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for the health check.
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
        /// The comma-separated list of individual HTTP status codes or ranges that indicate a
        /// successful health check response.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the application status check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetTagAssociations. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">tags</a>
        /// associated with the application status check. Instances with these tags are automatically
        /// monitored by this check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomTagKeyValueResponsePair> TargetTagAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomTagKeyValueResponsePair>() : null;

        /// <summary>
        /// Checks to see if the TargetTagAssociations property is set.
        /// </summary>
        internal bool IsSetTargetTagAssociations() => this.TargetTagAssociations != null && (this.TargetTagAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time, in seconds, to wait for a health check response. Valid values:
        /// 1 to 30.
        /// </para>
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;
    }
}
