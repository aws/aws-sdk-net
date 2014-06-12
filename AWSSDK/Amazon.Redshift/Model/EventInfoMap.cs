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
    /// 
    /// </summary>
    public partial class EventInfoMap
    {
        private List<string> _eventCategories = new List<string>();
        private string _eventDescription;
        private string _eventId;
        private string _severity;


        /// <summary>
        /// Gets and sets the property EventCategories. 
        /// <para>
        /// The category of an Amazon Redshift event.
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
        public EventInfoMap WithEventCategories(params string[] eventCategories)
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
        public EventInfoMap WithEventCategories(IEnumerable<string> eventCategories)
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
        /// Gets and sets the property EventDescription. 
        /// <para>
        /// The description of an Amazon Redshift event.
        /// </para>
        /// </summary>
        public string EventDescription
        {
            get { return this._eventDescription; }
            set { this._eventDescription = value; }
        }


        /// <summary>
        /// Sets the EventDescription property
        /// </summary>
        /// <param name="eventDescription">The value to set for the EventDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventInfoMap WithEventDescription(string eventDescription)
        {
            this._eventDescription = eventDescription;
            return this;
        }

        // Check to see if EventDescription property is set
        internal bool IsSetEventDescription()
        {
            return this._eventDescription != null;
        }


        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The identifier of an Amazon Redshift event.
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
        public EventInfoMap WithEventId(string eventId)
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
        public EventInfoMap WithSeverity(string severity)
        {
            this._severity = severity;
            return this;
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

    }
}