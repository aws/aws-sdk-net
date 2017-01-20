/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Metadata generated from the segment documents in a trace.
    /// </summary>
    public partial class TraceSummary
    {
        private Dictionary<string, List<ValueWithServiceIds>> _annotations = new Dictionary<string, List<ValueWithServiceIds>>();
        private double? _duration;
        private bool? _hasError;
        private bool? _hasFault;
        private bool? _hasThrottle;
        private Http _http;
        private string _id;
        private bool? _isPartial;
        private double? _responseTime;
        private List<ServiceId> _serviceIds = new List<ServiceId>();
        private List<TraceUser> _users = new List<TraceUser>();

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// Annotations from the trace's segment documents.
        /// </para>
        /// </summary>
        public Dictionary<string, List<ValueWithServiceIds>> Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null && this._annotations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The length of time in seconds between the start time of the root segment and the end
        /// time of the last segment that completed.
        /// </para>
        /// </summary>
        public double Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HasError. 
        /// <para>
        /// One or more of the segment documents has a 400 series error.
        /// </para>
        /// </summary>
        public bool HasError
        {
            get { return this._hasError.GetValueOrDefault(); }
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
        /// One or more of the segment documents has a 500 series error.
        /// </para>
        /// </summary>
        public bool HasFault
        {
            get { return this._hasFault.GetValueOrDefault(); }
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
        public bool HasThrottle
        {
            get { return this._hasThrottle.GetValueOrDefault(); }
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
        /// Gets and sets the property IsPartial. 
        /// <para>
        /// One or more of the segment documents is in progress.
        /// </para>
        /// </summary>
        public bool IsPartial
        {
            get { return this._isPartial.GetValueOrDefault(); }
            set { this._isPartial = value; }
        }

        // Check to see if IsPartial property is set
        internal bool IsSetIsPartial()
        {
            return this._isPartial.HasValue; 
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
        public double ResponseTime
        {
            get { return this._responseTime.GetValueOrDefault(); }
            set { this._responseTime = value; }
        }

        // Check to see if ResponseTime property is set
        internal bool IsSetResponseTime()
        {
            return this._responseTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceIds. 
        /// <para>
        /// Service IDs from the trace's segment documents.
        /// </para>
        /// </summary>
        public List<ServiceId> ServiceIds
        {
            get { return this._serviceIds; }
            set { this._serviceIds = value; }
        }

        // Check to see if ServiceIds property is set
        internal bool IsSetServiceIds()
        {
            return this._serviceIds != null && this._serviceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// Users from the trace's segment documents.
        /// </para>
        /// </summary>
        public List<TraceUser> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && this._users.Count > 0; 
        }

    }
}