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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRotation operation.
    /// Updates the information specified for an on-call rotation.
    /// </summary>
    public partial class UpdateRotationRequest : AmazonSSMContactsRequest
    {
        private List<string> _contactIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RecurrenceSettings _recurrence;
        private string _rotationId;
        private DateTime? _startTime;
        private string _timeZoneId;

        /// <summary>
        /// Gets and sets the property ContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts to include in the updated rotation.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the <c>PERSONAL</c> contact type is supported. The contact types <c>ESCALATION</c>
        /// and <c>ONCALL_SCHEDULE</c> are not supported for this operation. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The order in which you list the contacts is their shift order in the rotation schedule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public List<string> ContactIds
        {
            get { return this._contactIds; }
            set { this._contactIds = value; }
        }

        // Check to see if ContactIds property is set
        internal bool IsSetContactIds()
        {
            return this._contactIds != null && (this._contactIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// Information about how long the updated rotation lasts before restarting at the beginning
        /// of the shift order.
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
        /// Gets and sets the property RotationId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rotation to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RotationId
        {
            get { return this._rotationId; }
            set { this._rotationId = value; }
        }

        // Check to see if RotationId property is set
        internal bool IsSetRotationId()
        {
            return this._rotationId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time the rotation goes into effect.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeZoneId. 
        /// <para>
        /// The time zone to base the updated rotation’s activity on, in Internet Assigned Numbers
        /// Authority (IANA) format. For example: "America/Los_Angeles", "UTC", or "Asia/Seoul".
        /// For more information, see the <a href="https://www.iana.org/time-zones">Time Zone
        /// Database</a> on the IANA website.
        /// </para>
        ///  <note> 
        /// <para>
        /// Designators for time zones that don’t support Daylight Savings Time Rules, such as
        /// Pacific Standard Time (PST), aren't supported.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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