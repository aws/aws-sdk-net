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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Describes an event.</para>
    /// </summary>
    public class EventDescription
    {
        
        private DateTime? eventDate;
        private string message;
        private string applicationName;
        private string versionLabel;
        private string templateName;
        private string environmentName;
        private string requestId;
        private EventSeverity severity;

        /// <summary>
        /// The date when the event occurred.
        ///  
        /// </summary>
        public DateTime EventDate
        {
            get { return this.eventDate ?? default(DateTime); }
            set { this.eventDate = value; }
        }

        // Check to see if EventDate property is set
        internal bool IsSetEventDate()
        {
            return this.eventDate.HasValue;
        }

        /// <summary>
        /// The event message.
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
        /// The application associated with the event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;
        }

        /// <summary>
        /// The release label for the application version associated with this event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this.versionLabel; }
            set { this.versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this.versionLabel != null;
        }

        /// <summary>
        /// The name of the configuration associated with this event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this.templateName; }
            set { this.templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this.templateName != null;
        }

        /// <summary>
        /// The name of the environment associated with this event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this.environmentName; }
            set { this.environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;
        }

        /// <summary>
        /// The web service request ID for the activity of this event.
        ///  
        /// </summary>
        public string RequestId
        {
            get { return this.requestId; }
            set { this.requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this.requestId != null;
        }

        /// <summary>
        /// The severity level of this event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TRACE, DEBUG, INFO, WARN, ERROR, FATAL</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public EventSeverity Severity
        {
            get { return this.severity; }
            set { this.severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this.severity != null;
        }
    }
}
