/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Contains the output from the DescribeEvents action. </para>
    /// </summary>
    public class DescribeEventsResult
    {
        
        private string marker;
        private List<Event> events = new List<Event>();

        /// <summary>
        /// A marker at which to continue listing events in a new request. The response returns a marker if there are more events to list than returned
        /// in the response.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeEventsResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of <a>Event</a> instances.
        ///  
        /// </summary>
        public List<Event> Events
        {
            get { return this.events; }
            set { this.events = value; }
        }
        /// <summary>
        /// Adds elements to the Events collection
        /// </summary>
        /// <param name="events">The values to add to the Events collection </param>
        /// <returns>this instance</returns>
        public DescribeEventsResult WithEvents(params Event[] events)
        {
            foreach (Event element in events)
            {
                this.events.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Events collection
        /// </summary>
        /// <param name="events">The values to add to the Events collection </param>
        /// <returns>this instance</returns>
        public DescribeEventsResult WithEvents(IEnumerable<Event> events)
        {
            foreach (Event element in events)
            {
                this.events.Add(element);
            }

            return this;
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this.events.Count > 0;
        }
    }
}
