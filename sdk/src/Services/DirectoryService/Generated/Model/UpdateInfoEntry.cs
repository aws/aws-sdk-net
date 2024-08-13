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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// An entry of update information related to a requested update type.
    /// </summary>
    public partial class UpdateInfoEntry
    {
        private string _initiatedBy;
        private DateTime? _lastUpdatedDateTime;
        private UpdateValue _newValue;
        private UpdateValue _previousValue;
        private string _region;
        private DateTime? _startTime;
        private UpdateStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        ///  This specifies if the update was initiated by the customer or by the service team.
        /// 
        /// </para>
        /// </summary>
        public string InitiatedBy
        {
            get { return this._initiatedBy; }
            set { this._initiatedBy = value; }
        }

        // Check to see if InitiatedBy property is set
        internal bool IsSetInitiatedBy()
        {
            return this._initiatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        ///  The last updated date and time of a particular directory setting. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        ///  The new value of the target setting. 
        /// </para>
        /// </summary>
        public UpdateValue NewValue
        {
            get { return this._newValue; }
            set { this._newValue = value; }
        }

        // Check to see if NewValue property is set
        internal bool IsSetNewValue()
        {
            return this._newValue != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousValue. 
        /// <para>
        ///  The old value of the target setting. 
        /// </para>
        /// </summary>
        public UpdateValue PreviousValue
        {
            get { return this._previousValue; }
            set { this._previousValue = value; }
        }

        // Check to see if PreviousValue property is set
        internal bool IsSetPreviousValue()
        {
            return this._previousValue != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The name of the Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=32)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the <c>UpdateDirectorySetup</c> for the particular type. 
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the update performed on the directory. 
        /// </para>
        /// </summary>
        public UpdateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The reason for the current status of the update type activity. 
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}