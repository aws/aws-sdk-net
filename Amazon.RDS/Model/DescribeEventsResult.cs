/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// List of events related to instances and security groups.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class DescribeEventsResult
    {
        private string markerField;
        private List<Event> eventField;

        /// <summary>
        /// Gets and sets the Marker property.
        /// Identifier returned to allow retrieval of paginated results.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marker")]
        public string Marker
        {
            get { return this.markerField ; }
            set { this.markerField= value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">Identifier returned to allow retrieval of paginated results.</param>
        /// <returns>this instance</returns>
        public DescribeEventsResult WithMarker(string marker)
        {
            this.markerField = marker;
            return this;
        }

        /// <summary>
        /// Checks if Marker property is set
        /// </summary>
        /// <returns>true if Marker property is set</returns>
        public bool IsSetMarker()
        {
            return  this.markerField != null;
        }
        /// <summary>
        /// Gets and sets the Event property.
        /// Amazon RDS logs events that relate to your DB Instances, DB Snapshots, DB Security Groups, and DB Parameter Groups.
        /// This information includes the date and time of the event, the source name and source type of the event, and a message associated with the event.
        /// </summary>
        [XmlElementAttribute(ElementName = "Event")]
        public List<Event> Event
        {
            get
            {
                if (this.eventField == null)
                {
                    this.eventField = new List<Event>();
                }
                return this.eventField;
            }
            set { this.eventField = value; }
        }

        /// <summary>
        /// Sets the Event property
        /// </summary>
        /// <param name="list">Amazon RDS logs events that relate to your DB Instances, DB Snapshots, DB Security Groups, and DB Parameter Groups.
        /// This information includes the date and time of the event, the source name and source type of the event, and a message associated with the event.</param>
        /// <returns>this instance</returns>
        public DescribeEventsResult WithEvent(params Event[] list)
        {
            foreach (Event item in list)
            {
                Event.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Event property is set
        /// </summary>
        /// <returns>true if Event property is set</returns>
        public bool IsSetEvent()
        {
            return (Event.Count > 0);
        }

    }
}
