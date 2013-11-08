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

namespace Amazon.EC2.Model
{
    /// <summary>Volume Status Event
    /// </summary>
    public class VolumeStatusEvent
    {
        
        private string eventType;
        private string description;
        private DateTime? notBefore;
        private DateTime? notAfter;
        private string eventId;

        public string EventType
        {
            get { return this.eventType; }
            set { this.eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this.eventType != null;
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
        public DateTime NotBefore
        {
            get { return this.notBefore ?? default(DateTime); }
            set { this.notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this.notBefore.HasValue;
        }
        public DateTime NotAfter
        {
            get { return this.notAfter ?? default(DateTime); }
            set { this.notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this.notAfter.HasValue;
        }
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
