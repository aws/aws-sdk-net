/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> </para>
    /// </summary>
    public class Event  
    {
        
        private string sourceIdentifier;
        private string sourceType;
        private string message;
        private DateTime? date;

        /// <summary>
        /// Provides the identifier for the source of the event.
        ///  
        /// </summary>
        public string SourceIdentifier
        {
            get { return this.sourceIdentifier; }
            set { this.sourceIdentifier = value; }
        }

        /// <summary>
        /// Sets the SourceIdentifier property
        /// </summary>
        /// <param name="sourceIdentifier">The value to set for the SourceIdentifier property </param>
        /// <returns>this instance</returns>
        public Event WithSourceIdentifier(string sourceIdentifier)
        {
            this.sourceIdentifier = sourceIdentifier;
            return this;
        }
            
        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this.sourceIdentifier != null;       
        }

        /// <summary>
        /// Specifies the source type for this event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>db-instance, db-parameter-group, db-security-group, db-snapshot</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this.sourceType; }
            set { this.sourceType = value; }
        }

        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The value to set for the SourceType property </param>
        /// <returns>this instance</returns>
        public Event WithSourceType(string sourceType)
        {
            this.sourceType = sourceType;
            return this;
        }
            
        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this.sourceType != null;         
        }

        /// <summary>
        /// Provides the text of this event.
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">The value to set for the Message property </param>
        /// <returns>this instance</returns>
        public Event WithMessage(string message)
        {
            this.message = message;
            return this;
        }
            
        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;        
        }

        /// <summary>
        /// Specifies the date and time of the event.
        ///  
        /// </summary>
        public DateTime Date
        {
            get { return this.date ?? default(DateTime); }
            set { this.date = value; }
        }

        /// <summary>
        /// Sets the Date property
        /// </summary>
        /// <param name="date">The value to set for the Date property </param>
        /// <returns>this instance</returns>
        public Event WithDate(DateTime date)
        {
            this.date = date;
            return this;
        }
            
        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this.date.HasValue;      
        }
    }
}
