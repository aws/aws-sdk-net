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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents a single occurrence of something interesting within the system. Some examples of events are creating a cache cluster,
    /// adding or removing a cache node, or rebooting a node.</para>
    /// </summary>
    public class Event
    {
        
        private string sourceIdentifier;
        private SourceType sourceType;
        private string message;
        private DateTime? date;


        /// <summary>
        /// The identifier for the source of the event. For example, if the event occurred at the cache cluster level, the identifier would be the name
        /// of the cache cluster.
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
        /// Specifies the origin of this event - a cache cluster, a parameter group, a security group, etc.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>cache-cluster, cache-parameter-group, cache-security-group, cache-subnet-group</description>
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
        /// The text of the event.
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
        /// The date and time when the event occurred.
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
    }
}
