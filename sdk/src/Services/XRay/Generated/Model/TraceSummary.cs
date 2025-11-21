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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
        private Dictionary<string, List<ValueWithServiceIds>> _annotations = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ValueWithServiceIds>>() : null;
        private List<AvailabilityZoneDetail> _availabilityZones = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneDetail>() : null;
        private double? _duration;
        private ServiceId _entryPoint;
        private List<ErrorRootCause> _errorRootCauses = AWSConfigs.InitializeCollections ? new List<ErrorRootCause>() : null;
        private List<FaultRootCause> _faultRootCauses = AWSConfigs.InitializeCollections ? new List<FaultRootCause>() : null;
        private bool? _hasError;
        private bool? _hasFault;
        private bool? _hasThrottle;
        private Http _http;
        private string _id;
        private List<InstanceIdDetail> _instanceIds = AWSConfigs.InitializeCollections ? new List<InstanceIdDetail>() : null;
        private bool? _isPartial;
        private DateTime? _matchedEventTime;
        private List<ResourceARNDetail> _resourceARNs = AWSConfigs.InitializeCollections ? new List<ResourceARNDetail>() : null;
        private double? _responseTime;
        private List<ResponseTimeRootCause> _responseTimeRootCauses = AWSConfigs.InitializeCollections ? new List<ResponseTimeRootCause>() : null;
        private int? _revision;
        private List<ServiceId> _serviceIds = AWSConfigs.InitializeCollections ? new List<ServiceId>() : null;
        private DateTime? _startTime;
        private List<TraceUser> _users = AWSConfigs.InitializeCollections ? new List<TraceUser>() : null;

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// Annotations from the trace's segment documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<ValueWithServiceIds>> Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null && (this._annotations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones for any zone corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZoneDetail> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        ///  The length of time in seconds between the start time of the earliest segment that
        /// started and the end time of the last segment that completed.
        /// </para>
        /// </summary>
        public double? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The root of a trace.
        /// </para>
        /// </summary>
        public ServiceId EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this._entryPoint != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorRootCauses. 
        /// <para>
        /// A collection of ErrorRootCause structures corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorRootCause> ErrorRootCauses
        {
            get { return this._errorRootCauses; }
            set { this._errorRootCauses = value; }
        }

        // Check to see if ErrorRootCauses property is set
        internal bool IsSetErrorRootCauses()
        {
            return this._errorRootCauses != null && (this._errorRootCauses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FaultRootCauses. 
        /// <para>
        /// A collection of FaultRootCause structures corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FaultRootCause> FaultRootCauses
        {
            get { return this._faultRootCauses; }
            set { this._faultRootCauses = value; }
        }

        // Check to see if FaultRootCauses property is set
        internal bool IsSetFaultRootCauses()
        {
            return this._faultRootCauses != null && (this._faultRootCauses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HasError. 
        /// <para>
        /// The root segment document has a 400 series error.
        /// </para>
        /// </summary>
        public bool? HasError
        {
            get { return this._hasError; }
            set { this._hasError = value; }
        }

        // Check to see if HasError property is set
        internal bool IsSetHasError()
        {
            return this._hasError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HasFault. 
        /// <para>
        /// The root segment document has a 500 series error.
        /// </para>
        /// </summary>
        public bool? HasFault
        {
            get { return this._hasFault; }
            set { this._hasFault = value; }
        }

        // Check to see if HasFault property is set
        internal bool IsSetHasFault()
        {
            return this._hasFault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HasThrottle. 
        /// <para>
        /// One or more of the segment documents has a 429 throttling error.
        /// </para>
        /// </summary>
        public bool? HasThrottle
        {
            get { return this._hasThrottle; }
            set { this._hasThrottle = value; }
        }

        // Check to see if HasThrottle property is set
        internal bool IsSetHasThrottle()
        {
            return this._hasThrottle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Http. 
        /// <para>
        /// Information about the HTTP request served by the trace.
        /// </para>
        /// </summary>
        public Http Http
        {
            get { return this._http; }
            set { this._http = value; }
        }

        // Check to see if Http property is set
        internal bool IsSetHttp()
        {
            return this._http != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the request that generated the trace's segments and subsegments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=35)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// A list of EC2 instance IDs for any instance corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIdDetail> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsPartial. 
        /// <para>
        /// One or more of the segment documents is in progress.
        /// </para>
        /// </summary>
        public bool? IsPartial
        {
            get { return this._isPartial; }
            set { this._isPartial = value; }
        }

        // Check to see if IsPartial property is set
        internal bool IsSetIsPartial()
        {
            return this._isPartial.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MatchedEventTime. 
        /// <para>
        /// The matched time stamp of a defined event.
        /// </para>
        /// </summary>
        public DateTime? MatchedEventTime
        {
            get { return this._matchedEventTime; }
            set { this._matchedEventTime = value; }
        }

        // Check to see if MatchedEventTime property is set
        internal bool IsSetMatchedEventTime()
        {
            return this._matchedEventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceARNs. 
        /// <para>
        /// A list of resource ARNs for any resource corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceARNDetail> ResourceARNs
        {
            get { return this._resourceARNs; }
            set { this._resourceARNs = value; }
        }

        // Check to see if ResourceARNs property is set
        internal bool IsSetResourceARNs()
        {
            return this._resourceARNs != null && (this._resourceARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseTime. 
        /// <para>
        /// The length of time in seconds between the start and end times of the root segment.
        /// If the service performs work asynchronously, the response time measures the time before
        /// the response is sent to the user, while the duration measures the amount of time before
        /// the last traced activity completes.
        /// </para>
        /// </summary>
        public double? ResponseTime
        {
            get { return this._responseTime; }
            set { this._responseTime = value; }
        }

        // Check to see if ResponseTime property is set
        internal bool IsSetResponseTime()
        {
            return this._responseTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseTimeRootCauses. 
        /// <para>
        /// A collection of ResponseTimeRootCause structures corresponding to the trace segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResponseTimeRootCause> ResponseTimeRootCauses
        {
            get { return this._responseTimeRootCauses; }
            set { this._responseTimeRootCauses = value; }
        }

        // Check to see if ResponseTimeRootCauses property is set
        internal bool IsSetResponseTimeRootCauses()
        {
            return this._responseTimeRootCauses != null && (this._responseTimeRootCauses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of a trace.
        /// </para>
        /// </summary>
        public int? Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceIds. 
        /// <para>
        /// Service IDs from the trace's segment documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceId> ServiceIds
        {
            get { return this._serviceIds; }
            set { this._serviceIds = value; }
        }

        // Check to see if ServiceIds property is set
        internal bool IsSetServiceIds()
        {
            return this._serviceIds != null && (this._serviceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of a trace, based on the earliest trace segment start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// Users from the trace's segment documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TraceUser> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && (this._users.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}