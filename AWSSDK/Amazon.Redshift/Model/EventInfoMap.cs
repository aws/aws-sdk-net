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
    /// 
    /// </summary>
    public partial class EventInfoMap
    {
        
        private string eventId;
        private List<string> eventCategories = new List<string>();
        private string eventDescription;
        private string severity;

        /// <summary>
        /// The identifier of an Amazon Redshift event.
        ///  
        /// </summary>
        public string EventId
        {
            get { return this.eventId; }
            set { this.eventId = value; }
        }

        /// <summary>
        /// Sets the EventId property
        /// </summary>
        /// <param name="eventId">The value to set for the EventId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventInfoMap WithEventId(string eventId)
        {
            this.eventId = eventId;
            return this;
        }
            

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this.eventId != null;
        }

        /// <summary>
        /// The category of an Amazon Redshift event.
        ///  
        /// </summary>
        public List<string> EventCategories
        {
            get { return this.eventCategories; }
            set { this.eventCategories = value; }
        }
        /// <summary>
        /// Adds elements to the EventCategories collection
        /// </summary>
        /// <param name="eventCategories">The values to add to the EventCategories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventInfoMap WithEventCategories(params string[] eventCategories)
        {
            foreach (string element in eventCategories)
            {
                this.eventCategories.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the EventCategories collection
        /// </summary>
        /// <param name="eventCategories">The values to add to the EventCategories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventInfoMap WithEventCategories(IEnumerable<string> eventCategories)
        {
            foreach (string element in eventCategories)
            {
                this.eventCategories.Add(element);
            }

            return this;
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this.eventCategories.Count > 0;
        }

        /// <summary>
        /// The description of an Amazon Redshift event.
        ///  
        /// </summary>
        public string EventDescription
        {
            get { return this.eventDescription; }
            set { this.eventDescription = value; }
        }

        /// <summary>
        /// Sets the EventDescription property
        /// </summary>
        /// <param name="eventDescription">The value to set for the EventDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventInfoMap WithEventDescription(string eventDescription)
        {
            this.eventDescription = eventDescription;
            return this;
        }
            

        // Check to see if EventDescription property is set
        internal bool IsSetEventDescription()
        {
            return this.eventDescription != null;
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

        /// <summary>
        /// Sets the Severity property
        /// </summary>
        /// <param name="severity">The value to set for the Severity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventInfoMap WithSeverity(string severity)
        {
            this.severity = severity;
            return this;
        }
            

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this.severity != null;
        }
    }
}
