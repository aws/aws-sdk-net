/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Represents a single occurrence of something interesting within the system. Some examples
    /// of events are creating a DAX cluster, adding or removing a node, or rebooting a node.
    /// </summary>
    public partial class Event
    {
        private DateTime? _date;
        private string _message;
        private string _sourceName;
        private SourceType _sourceType;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date and time when the event occurred.
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
        /// Gets and sets the property Message. 
        /// <para>
        /// A user-defined message associated with the event.
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
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The source of the event. For example, if the event occurred at the node level, the
        /// source would be the node ID.
        /// </para>
        /// </summary>
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Specifies the origin of this event - a cluster, a parameter group, a node ID, etc.
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