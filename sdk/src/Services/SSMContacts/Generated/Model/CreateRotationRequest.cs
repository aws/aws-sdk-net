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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRotation operation.
    /// Creates a rotation in an on-call schedule.
    /// </summary>
    public partial class CreateRotationRequest : AmazonSSMContactsRequest
    {
        private List<string> _contactIds = new List<string>();
        private string _idempotencyToken;
        private string _name;
        private RecurrenceSettings _recurrence;
        private DateTime? _startTime;
        private List<Tag> _tags = new List<Tag>();
        private string _timeZoneId;

        /// <summary>
        /// Gets and sets the property ContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts to add to the rotation.
        /// </para>
        ///  
        /// <para>
        /// The order that you list the contacts in is their shift order in the rotation schedule.
        /// To change the order of the contact's shifts, use the <a>UpdateRotation</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> ContactIds
        {
            get { return this._contactIds; }
            set { this._contactIds = value; }
        }

        // Check to see if ContactIds property is set
        internal bool IsSetContactIds()
        {
            return this._contactIds != null && this._contactIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token that ensures that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// Information about the rule that specifies when a shift's team members rotate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecurrenceSettings Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this._recurrence != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time that the rotation goes into effect.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata to assign to the rotation. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/tagging.html">Tagging
        /// Incident Manager resources</a> in the <i>Incident Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeZoneId. 
        /// <para>
        /// The time zone to base the rotation’s activity on in Internet Assigned Numbers Authority
        /// (IANA) format. For example: "America/Los_Angeles", "UTC", or "Asia/Seoul". For more
        /// information, see the <a href="https://www.iana.org/time-zones">Time Zone Database</a>
        /// on the IANA website.
        /// </para>
        ///  <note> 
        /// <para>
        /// Designators for time zones that don’t support Daylight Savings Time rules, such as
        /// Pacific Standard Time (PST) and Pacific Daylight Time (PDT), are not supported.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TimeZoneId
        {
            get { return this._timeZoneId; }
            set { this._timeZoneId = value; }
        }

        // Check to see if TimeZoneId property is set
        internal bool IsSetTimeZoneId()
        {
            return this._timeZoneId != null;
        }

    }
}