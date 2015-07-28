/*
 * Copyright 2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Model
{
    /// <summary>
    /// An abstract class for all the notification configurations associated with an Amazon S3 bucket.
    /// </summary>
    public abstract class NotificationConfiguration
    {
        List<EventType> _events;
        /// <summary>
        /// Gets and sets the Events property. These are the events the configuration will listen to.
        /// </summary>
        public List<EventType> Events
        {
            get
            {
                if (this._events == null)
                    this._events = new List<EventType>();

                return this._events;
            }
            set { this._events = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0;
        }


        private Filter filter;

        /// <summary>
        /// Filter criteria for determining which S3 objects trigger event notifications.
        ///  
        /// </summary>
        public Filter Filter
        {
            get { return this.filter; }
            set { this.filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this.filter != null;
        }
    }
}
