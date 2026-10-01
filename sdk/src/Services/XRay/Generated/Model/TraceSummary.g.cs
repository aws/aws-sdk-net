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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Metadata generated from the segment documents in a trace.
    /// </summary>
    public partial class TraceSummary
    {
        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// Annotations from the trace's segment documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<ValueWithServiceIds>> Annotations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ValueWithServiceIds>>() : null;

        /// <summary>
        /// Checks to see if the Annotations property is set.
        /// </summary>
        internal bool IsSetAnnotations() => this.Annotations != null && (this.Annotations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones for any zone corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZoneDetail> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneDetail>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        ///  The length of time in seconds between the start time of the earliest segment that
        /// started and the end time of the last segment that completed.
        /// </para>
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The root of a trace.
        /// </para>
        /// </summary>
        public ServiceId EntryPoint { get; set; }

        /// <summary>
        /// Checks to see if the EntryPoint property is set.
        /// </summary>
        internal bool IsSetEntryPoint() => this.EntryPoint != null;

        /// <summary>
        /// Gets and sets the property ErrorRootCauses. 
        /// <para>
        /// A collection of ErrorRootCause structures corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorRootCause> ErrorRootCauses { get; set; } = AWSConfigs.InitializeCollections ? new List<ErrorRootCause>() : null;

        /// <summary>
        /// Checks to see if the ErrorRootCauses property is set.
        /// </summary>
        internal bool IsSetErrorRootCauses() => this.ErrorRootCauses != null && (this.ErrorRootCauses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FaultRootCauses. 
        /// <para>
        /// A collection of FaultRootCause structures corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FaultRootCause> FaultRootCauses { get; set; } = AWSConfigs.InitializeCollections ? new List<FaultRootCause>() : null;

        /// <summary>
        /// Checks to see if the FaultRootCauses property is set.
        /// </summary>
        internal bool IsSetFaultRootCauses() => this.FaultRootCauses != null && (this.FaultRootCauses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HasError. 
        /// <para>
        /// The root segment document has a 400 series error.
        /// </para>
        /// </summary>
        public bool? HasError { get; set; }

        /// <summary>
        /// Checks to see if the HasError property is set.
        /// </summary>
        internal bool IsSetHasError() => this.HasError.HasValue;

        /// <summary>
        /// Gets and sets the property HasFault. 
        /// <para>
        /// The root segment document has a 500 series error.
        /// </para>
        /// </summary>
        public bool? HasFault { get; set; }

        /// <summary>
        /// Checks to see if the HasFault property is set.
        /// </summary>
        internal bool IsSetHasFault() => this.HasFault.HasValue;

        /// <summary>
        /// Gets and sets the property HasThrottle. 
        /// <para>
        /// One or more of the segment documents has a 429 throttling error.
        /// </para>
        /// </summary>
        public bool? HasThrottle { get; set; }

        /// <summary>
        /// Checks to see if the HasThrottle property is set.
        /// </summary>
        internal bool IsSetHasThrottle() => this.HasThrottle.HasValue;

        /// <summary>
        /// Gets and sets the property Http. 
        /// <para>
        /// Information about the HTTP request served by the trace.
        /// </para>
        /// </summary>
        public Http Http { get; set; }

        /// <summary>
        /// Checks to see if the Http property is set.
        /// </summary>
        internal bool IsSetHttp() => this.Http != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the request that generated the trace's segments and subsegments.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 35)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// A list of EC2 instance IDs for any instance corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIdDetail> InstanceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceIdDetail>() : null;

        /// <summary>
        /// Checks to see if the InstanceIds property is set.
        /// </summary>
        internal bool IsSetInstanceIds() => this.InstanceIds != null && (this.InstanceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsPartial. 
        /// <para>
        /// One or more of the segment documents is in progress.
        /// </para>
        /// </summary>
        public bool? IsPartial { get; set; }

        /// <summary>
        /// Checks to see if the IsPartial property is set.
        /// </summary>
        internal bool IsSetIsPartial() => this.IsPartial.HasValue;

        /// <summary>
        /// Gets and sets the property MatchedEventTime. 
        /// <para>
        /// The matched time stamp of a defined event.
        /// </para>
        /// </summary>
        public DateTime? MatchedEventTime { get; set; }

        /// <summary>
        /// Checks to see if the MatchedEventTime property is set.
        /// </summary>
        internal bool IsSetMatchedEventTime() => this.MatchedEventTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceARNs. 
        /// <para>
        /// A list of resource ARNs for any resource corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceARNDetail> ResourceARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceARNDetail>() : null;

        /// <summary>
        /// Checks to see if the ResourceARNs property is set.
        /// </summary>
        internal bool IsSetResourceARNs() => this.ResourceARNs != null && (this.ResourceARNs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseTime. 
        /// <para>
        /// The length of time in seconds between the start and end times of the root segment.
        /// If the service performs work asynchronously, the response time measures the time before
        /// the response is sent to the user, while the duration measures the amount of time before
        /// the last traced activity completes.
        /// </para>
        /// </summary>
        public double? ResponseTime { get; set; }

        /// <summary>
        /// Checks to see if the ResponseTime property is set.
        /// </summary>
        internal bool IsSetResponseTime() => this.ResponseTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseTimeRootCauses. 
        /// <para>
        /// A collection of ResponseTimeRootCause structures corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResponseTimeRootCause> ResponseTimeRootCauses { get; set; } = AWSConfigs.InitializeCollections ? new List<ResponseTimeRootCause>() : null;

        /// <summary>
        /// Checks to see if the ResponseTimeRootCauses property is set.
        /// </summary>
        internal bool IsSetResponseTimeRootCauses() => this.ResponseTimeRootCauses != null && (this.ResponseTimeRootCauses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of a trace.
        /// </para>
        /// </summary>
        public int? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceIds. 
        /// <para>
        /// Service IDs from the trace's segment documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceId> ServiceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceId>() : null;

        /// <summary>
        /// Checks to see if the ServiceIds property is set.
        /// </summary>
        internal bool IsSetServiceIds() => this.ServiceIds != null && (this.ServiceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of a trace, based on the earliest trace segment start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// Users from the trace's segment documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TraceUser> Users { get; set; } = AWSConfigs.InitializeCollections ? new List<TraceUser>() : null;

        /// <summary>
        /// Checks to see if the Users property is set.
        /// </summary>
        internal bool IsSetUsers() => this.Users != null && (this.Users.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
