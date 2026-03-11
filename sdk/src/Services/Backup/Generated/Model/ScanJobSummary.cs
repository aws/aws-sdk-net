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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains summary information about scan jobs, including counts and metadata for a
    /// specific time period and criteria.
    /// </summary>
    public partial class ScanJobSummary
    {
        private string _accountId;
        private int? _count;
        private DateTime? _endTime;
        private MalwareScanner _malwareScanner;
        private string _region;
        private string _resourceType;
        private ScanResultStatus _scanResultStatus;
        private DateTime? _startTime;
        private ScanJobStatus _state;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the scan jobs included in this summary.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of scan jobs that match the specified criteria.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The value of time in number format of a job end time.
        /// </para>
        ///  
        /// <para>
        /// This value is the time in Unix format, Coordinated Universal Time (UTC), and accurate
        /// to milliseconds. For example, the value 1516925490.087 represents Friday, January
        /// 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// Specifies the malware scanner used during the scan job. Currently only supports <c>GUARDDUTY</c>.
        /// </para>
        /// </summary>
        public MalwareScanner MalwareScanner
        {
            get { return this._malwareScanner; }
            set { this._malwareScanner = value; }
        }

        // Check to see if MalwareScanner property is set
        internal bool IsSetMalwareScanner()
        {
            return this._malwareScanner != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the scan jobs were executed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource for the scan jobs included in this summary.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ScanResultStatus. 
        /// <para>
        /// The scan result status for the scan jobs included in this summary.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>THREATS_FOUND</c> | <c>NO_THREATS_FOUND</c>.
        /// </para>
        /// </summary>
        public ScanResultStatus ScanResultStatus
        {
            get { return this._scanResultStatus; }
            set { this._scanResultStatus = value; }
        }

        // Check to see if ScanResultStatus property is set
        internal bool IsSetScanResultStatus()
        {
            return this._scanResultStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The value of time in number format of a job start time.
        /// </para>
        ///  
        /// <para>
        /// This value is the time in Unix format, Coordinated Universal Time (UTC), and accurate
        /// to milliseconds. For example, the value 1516925490.087 represents Friday, January
        /// 26, 2018 12:11:30.087 AM.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the scan jobs included in this summary.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>CREATED</c> | <c>RUNNING</c> | <c>COMPLETED</c> | <c>COMPLETED_WITH_ISSUES</c>
        /// | <c>FAILED</c> | <c>CANCELED</c>.
        /// </para>
        /// </summary>
        public ScanJobStatus State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}