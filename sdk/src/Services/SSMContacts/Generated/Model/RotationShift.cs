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
    /// Information about a shift that belongs to an on-call rotation.
    /// </summary>
    public partial class RotationShift
    {
        private List<string> _contactIds = new List<string>();
        private DateTime? _endTime;
        private ShiftDetails _shiftDetails;
        private DateTime? _startTime;
        private ShiftType _type;

        /// <summary>
        /// Gets and sets the property ContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts who are part of the shift rotation.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time a shift rotation ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShiftDetails. 
        /// <para>
        /// Additional information about an on-call rotation shift.
        /// </para>
        /// </summary>
        public ShiftDetails ShiftDetails
        {
            get { return this._shiftDetails; }
            set { this._shiftDetails = value; }
        }

        // Check to see if ShiftDetails property is set
        internal bool IsSetShiftDetails()
        {
            return this._shiftDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time a shift rotation begins.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of shift rotation.
        /// </para>
        /// </summary>
        public ShiftType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}