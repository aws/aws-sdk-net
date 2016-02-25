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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the DescribeSnapshotSchedule operation.
    /// </summary>
    public partial class DescribeSnapshotScheduleResponse : AmazonWebServiceResponse
    {
        private string _description;
        private int? _recurrenceInHours;
        private int? _startAt;
        private string _timezone;
        private string _volumeARN;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property RecurrenceInHours.
        /// </summary>
        public int RecurrenceInHours
        {
            get { return this._recurrenceInHours.GetValueOrDefault(); }
            set { this._recurrenceInHours = value; }
        }

        // Check to see if RecurrenceInHours property is set
        internal bool IsSetRecurrenceInHours()
        {
            return this._recurrenceInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartAt.
        /// </summary>
        public int StartAt
        {
            get { return this._startAt.GetValueOrDefault(); }
            set { this._startAt = value; }
        }

        // Check to see if StartAt property is set
        internal bool IsSetStartAt()
        {
            return this._startAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timezone.
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeARN.
        /// </summary>
        public string VolumeARN
        {
            get { return this._volumeARN; }
            set { this._volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this._volumeARN != null;
        }

    }
}