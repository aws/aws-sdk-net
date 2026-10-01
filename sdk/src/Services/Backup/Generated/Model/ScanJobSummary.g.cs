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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the scan jobs included in this summary.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of scan jobs that match the specified criteria.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

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
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// Specifies the malware scanner used during the scan job. Currently only supports <c>GUARDDUTY</c>.
        /// </para>
        /// </summary>
        public MalwareScanner MalwareScanner { get; set; }

        /// <summary>
        /// Checks to see if the MalwareScanner property is set.
        /// </summary>
        internal bool IsSetMalwareScanner() => this.MalwareScanner != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the scan jobs were executed.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource for the scan jobs included in this summary.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

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
        public ScanResultStatus ScanResultStatus { get; set; }

        /// <summary>
        /// Checks to see if the ScanResultStatus property is set.
        /// </summary>
        internal bool IsSetScanResultStatus() => this.ScanResultStatus != null;

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
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

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
        public ScanJobStatus State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
