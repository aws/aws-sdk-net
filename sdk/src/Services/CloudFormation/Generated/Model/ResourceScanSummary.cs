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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// A summary of the resource scan. This is returned by the <c>ListResourceScan</c> API
    /// action.
    /// </summary>
    public partial class ResourceScanSummary
    {
        private DateTime? _endTime;
        private double? _percentageCompleted;
        private string _resourceScanId;
        private ScanType _scanType;
        private DateTime? _startTime;
        private ResourceScanStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the resource scan was finished.
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
        /// Gets and sets the property PercentageCompleted. 
        /// <para>
        /// The percentage of the resource scan that has been completed.
        /// </para>
        /// </summary>
        public double? PercentageCompleted
        {
            get { return this._percentageCompleted; }
            set { this._percentageCompleted = value; }
        }

        // Check to see if PercentageCompleted property is set
        internal bool IsSetPercentageCompleted()
        {
            return this._percentageCompleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceScanId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource scan.
        /// </para>
        /// </summary>
        public string ResourceScanId
        {
            get { return this._resourceScanId; }
            set { this._resourceScanId = value; }
        }

        // Check to see if ResourceScanId property is set
        internal bool IsSetResourceScanId()
        {
            return this._resourceScanId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// The scan type that has been completed.
        /// </para>
        /// </summary>
        public ScanType ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the resource scan was started.
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
        /// Status of the resource scan.
        /// </para>
        ///  <dl> <dt> IN_PROGRESS </dt> <dd> 
        /// <para>
        /// The resource scan is still in progress.
        /// </para>
        ///  </dd> <dt> COMPLETE </dt> <dd> 
        /// <para>
        /// The resource scan is complete.
        /// </para>
        ///  </dd> <dt> EXPIRED </dt> <dd> 
        /// <para>
        /// The resource scan has expired.
        /// </para>
        ///  </dd> <dt> FAILED </dt> <dd> 
        /// <para>
        /// The resource scan has failed.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ResourceScanStatus Status
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
        /// The reason for the resource scan status, providing more information if a failure happened.
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