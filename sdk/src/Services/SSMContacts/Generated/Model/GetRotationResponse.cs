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
    /// This is the response object from the GetRotation operation.
    /// </summary>
    public partial class GetRotationResponse : AmazonWebServiceResponse
    {
        private List<string> _contactIds = new List<string>();
        private string _name;
        private RecurrenceSettings _recurrence;
        private string _rotationArn;
        private DateTime? _startTime;
        private string _timeZoneId;

        /// <summary>
        /// Gets and sets the property ContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts assigned to the on-call rotation
        /// team.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the on-call rotation.
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
        /// Specifies how long a rotation lasts before restarting at the beginning of the shift
        /// order.
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
        /// Gets and sets the property RotationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the on-call rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RotationArn
        {
            get { return this._rotationArn; }
            set { this._rotationArn = value; }
        }

        // Check to see if RotationArn property is set
        internal bool IsSetRotationArn()
        {
            return this._rotationArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The specified start time for the on-call rotation.
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
        /// Gets and sets the property TimeZoneId. 
        /// <para>
        /// The time zone that the rotation’s activity is based on, in Internet Assigned Numbers
        /// Authority (IANA) format.
        /// </para>
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