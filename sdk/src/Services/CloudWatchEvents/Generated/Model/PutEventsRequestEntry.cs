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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Represents an event to be submitted.
    /// </summary>
    public partial class PutEventsRequestEntry
    {
        private string _detail;
        private string _detailType;
        private List<string> _resources = new List<string>();
        private string _source;
        private DateTime? _time;

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// A valid JSON string. There is no other schema imposed. The JSON string may contain
        /// fields and nested subobjects.
        /// </para>
        /// </summary>
        public string Detail
        {
            get { return this._detail; }
            set { this._detail = value; }
        }

        // Check to see if Detail property is set
        internal bool IsSetDetail()
        {
            return this._detail != null;
        }

        /// <summary>
        /// Gets and sets the property DetailType. 
        /// <para>
        /// Free-form string used to decide what fields to expect in the event detail.
        /// </para>
        /// </summary>
        public string DetailType
        {
            get { return this._detailType; }
            set { this._detailType = value; }
        }

        // Check to see if DetailType property is set
        internal bool IsSetDetailType()
        {
            return this._detailType != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// AWS resources, identified by Amazon Resource Name (ARN), which the event primarily
        /// concerns. Any number, including zero, may be present.
        /// </para>
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the event.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The timestamp of the event, per <a href="https://www.rfc-editor.org/rfc/rfc3339.txt">RFC3339</a>.
        /// If no timestamp is provided, the timestamp of the <a>PutEvents</a> call is used.
        /// </para>
        /// </summary>
        public DateTime Time
        {
            get { return this._time.GetValueOrDefault(); }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

    }
}