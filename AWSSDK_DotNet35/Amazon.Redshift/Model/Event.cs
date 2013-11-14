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
    /// <para> Describes an event. </para>
    /// </summary>
    public class Event
    {
        
        private string sourceIdentifier;
        private SourceType sourceType;
        private string message;
        private List<string> eventCategories = new List<string>();
        private string severity;
        private DateTime? date;
        private string eventId;


        /// <summary>
        /// The identifier for the source of the event.
        ///  
        /// </summary>
        public string SourceIdentifier
        {
            get { return this.sourceIdentifier; }
            set { this.sourceIdentifier = value; }
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this.sourceIdentifier != null;
        }

        /// <summary>
        /// The source type for this event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>cluster, cluster-parameter-group, cluster-security-group, cluster-snapshot</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public SourceType SourceType
        {
            get { return this.sourceType; }
            set { this.sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this.sourceType != null;
        }

        /// <summary>
        /// The text of this event.
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }

        /// <summary>
        /// A list of the event categories.
        ///  
        /// </summary>
        public List<string> EventCategories
        {
            get { return this.eventCategories; }
            set { this.eventCategories = value; }
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this.eventCategories.Count > 0;
        }

        /// <summary>
        /// The severity of the event. Values: ERROR, INFO
        ///  
        /// </summary>
        public string Severity
        {
            get { return this.severity; }
            set { this.severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this.severity != null;
        }

        /// <summary>
        /// The date and time of the event.
        ///  
        /// </summary>
        public DateTime Date
        {
            get { return this.date ?? default(DateTime); }
            set { this.date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this.date.HasValue;
        }

        /// <summary>
        /// The identifier of the event.
        ///  
        /// </summary>
        public string EventId
        {
            get { return this.eventId; }
            set { this.eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this.eventId != null;
        }
    }
}
