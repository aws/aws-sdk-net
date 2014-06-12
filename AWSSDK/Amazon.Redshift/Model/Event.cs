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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes an event.
    /// </summary>
    public partial class Event
    {
        private DateTime? _date;
        private List<string> _eventCategories = new List<string>();
        private string _eventId;
        private string _message;
        private string _severity;
        private string _sourceIdentifier;
        private string _sourceType;


        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        ///         The date and time of the event.        
        /// </para>
        /// </summary>
        public DateTime Date
        {
            get { return this._date.GetValueOrDefault(); }
            set { this._date = value; }
        }


        /// <summary>
        /// Sets the Date property
        /// </summary>
        /// <param name="date">The value to set for the Date property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Event WithDate(DateTime date)
        {
            this._date = date;
            return this;
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EventCategories. 
        /// <para>
        ///             A list of the event categories.        
        /// </para>
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
        }

        /// <summary>
        /// Sets the EventCategories property
        /// </summary>
        /// <param name="eventCategories">The values to add to the EventCategories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Event WithEventCategories(params string[] eventCategories)
        {
            foreach (var element in eventCategories)
            {
                this._eventCategories.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the EventCategories property
        /// </summary>
        /// <param name="eventCategories">The values to add to the EventCategories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Event WithEventCategories(IEnumerable<string> eventCategories)
        {
            foreach (var element in eventCategories)
            {
                this._eventCategories.Add(element);
            }
            return this;
        }
        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this._eventCategories != null && this._eventCategories.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        ///             The identifier of the event.        
        /// </para>
        /// </summary>
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }


        /// <summary>
        /// Sets the EventId property
        /// </summary>
        /// <param name="eventId">The value to set for the EventId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Event WithEventId(string eventId)
        {
            this._eventId = eventId;
            return this;
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }


        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///         The text of this event.        
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }


        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">The value to set for the Message property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Event WithMessage(string message)
        {
            this._message = message;
            return this;
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }


        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the event.
        /// </para>
        ///         
        /// <para>
        /// Values: ERROR, INFO
        /// </para>
        /// </summary>
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }


        /// <summary>
        /// Sets the Severity property
        /// </summary>
        /// <param name="severity">The value to set for the Severity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Event WithSeverity(string severity)
        {
            this._severity = severity;
            return this;
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }


        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        ///         The identifier for the source of the event.        
        /// </para>
        /// </summary>
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }


        /// <summary>
        /// Sets the SourceIdentifier property
        /// </summary>
        /// <param name="sourceIdentifier">The value to set for the SourceIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Event WithSourceIdentifier(string sourceIdentifier)
        {
            this._sourceIdentifier = sourceIdentifier;
            return this;
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        ///         The source type for this event.        
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }


        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The value to set for the SourceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Event WithSourceType(string sourceType)
        {
            this._sourceType = sourceType;
            return this;
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}