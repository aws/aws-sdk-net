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

/*
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the <a>DescribeEvents</a> action.
    /// </summary>
    public partial class Event
    {
        private DateTime? _date;
        private List<string> _eventCategories = new List<string>();
        private string _message;
        private string _sourceArn;
        private string _sourceIdentifier;
        private SourceType _sourceType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Event() { }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// Specifies the date and time of the event.
        /// </para>
        /// </summary>
        public DateTime Date
        {
            get { return this._date.GetValueOrDefault(); }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventCategories. 
        /// <para>
        /// Specifies the category for the event.
        /// </para>
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this._eventCategories != null && this._eventCategories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Provides the text of this event.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the event.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        /// Provides the identifier for the source of the event.
        /// </para>
        /// </summary>
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Specifies the source type for this event.
        /// </para>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}