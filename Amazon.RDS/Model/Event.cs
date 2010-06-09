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
    ///<summary>
    ///Information about the event.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class Event
    {
        private string sourceIdentifierField;
        private string sourceTypeField;
        private string messageField;
        private DateTime? dateField;

        /// <summary>
        /// Gets and sets the SourceIdentifier property.
        /// The identifier of the source for the event. If the source type is DBInstance, then this value is a DBInstanceIdentifier. If the
        /// source type is a DBSecurityGroup, this value is a DBSecurityGroupName.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceIdentifier")]
        public string SourceIdentifier
        {
            get { return this.sourceIdentifierField ; }
            set { this.sourceIdentifierField= value; }
        }

        /// <summary>
        /// Sets the SourceIdentifier property
        /// </summary>
        /// <param name="sourceIdentifier">The identifier of the source for the event. If the source type is DBInstance, then this value is a DBInstanceIdentifier. If the
        /// source type is a DBSecurityGroup, this value is a DBSecurityGroupName.</param>
        /// <returns>this instance</returns>
        public Event WithSourceIdentifier(string sourceIdentifier)
        {
            this.sourceIdentifierField = sourceIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if SourceIdentifier property is set
        /// </summary>
        /// <returns>true if SourceIdentifier property is set</returns>
        public bool IsSetSourceIdentifier()
        {
            return  this.sourceIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the SourceType property.
        /// The source type for this event.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceType")]
        public string SourceType
        {
            get { return this.sourceTypeField ; }
            set { this.sourceTypeField= value; }
        }

        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The source type for this event.</param>
        /// <returns>this instance</returns>
        public Event WithSourceType(string sourceType)
        {
            this.sourceTypeField = sourceType;
            return this;
        }

        /// <summary>
        /// Checks if SourceType property is set
        /// </summary>
        /// <returns>true if SourceType property is set</returns>
        public bool IsSetSourceType()
        {
            return  this.sourceTypeField != null;
        }

        /// <summary>
        /// Gets and sets the Message property.
        /// The text of the event.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public string Message
        {
            get { return this.messageField ; }
            set { this.messageField= value; }
        }

        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">The text of the event.</param>
        /// <returns>this instance</returns>
        public Event WithMessage(string message)
        {
            this.messageField = message;
            return this;
        }

        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public bool IsSetMessage()
        {
            return  this.messageField != null;
        }

        /// <summary>
        /// Gets and sets the Date property.
        /// The date and time of the event. Example: 2009-01-2009T23:50.000Z.
        /// </summary>
        [XmlElementAttribute(ElementName = "Date")]
        public DateTime Date
        {
            get { return this.dateField.GetValueOrDefault() ; }
            set { this.dateField= value; }
        }

        /// <summary>
        /// Sets the Date property
        /// </summary>
        /// <param name="date">The date and time of the event. Example: 2009-01-2009T23:50.000Z.</param>
        /// <returns>this instance</returns>
        public Event WithDate(DateTime date)
        {
            this.dateField = date;
            return this;
        }

        /// <summary>
        /// Checks if Date property is set
        /// </summary>
        /// <returns>true if Date property is set</returns>
        public bool IsSetDate()
        {
            return  this.dateField.HasValue;
        }

    }
}
