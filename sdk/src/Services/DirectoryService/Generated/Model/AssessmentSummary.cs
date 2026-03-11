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
    /// Contains summary information about a directory assessment, providing a high-level
    /// overview without detailed validation results.
    /// </summary>
    public partial class AssessmentSummary
    {
        private string _assessmentId;
        private List<string> _customerDnsIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _directoryId;
        private string _dnsName;
        private DateTime? _lastUpdateDateTime;
        private string _reportType;
        private DateTime? _startTime;
        private string _status;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The unique identifier of the directory assessment.
        /// </para>
        /// </summary>
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerDnsIps. 
        /// <para>
        /// The IP addresses of the DNS servers or domain controllers in your self-managed AD
        /// environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<string> CustomerDnsIps
        {
            get { return this._customerDnsIps; }
            set { this._customerDnsIps = value; }
        }

        // Check to see if CustomerDnsIps property is set
        internal bool IsSetCustomerDnsIps()
        {
            return this._customerDnsIps != null && (this._customerDnsIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory associated with this assessment.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the Active Directory domain being assessed.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateDateTime. 
        /// <para>
        /// The date and time when the assessment status was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateDateTime
        {
            get { return this._lastUpdateDateTime; }
            set { this._lastUpdateDateTime = value; }
        }

        // Check to see if LastUpdateDateTime property is set
        internal bool IsSetLastUpdateDateTime()
        {
            return this._lastUpdateDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// The type of assessment report generated. Valid values include <c>CUSTOMER</c> and
        /// <c>SYSTEM</c>.
        /// </para>
        /// </summary>
        public string ReportType
        {
            get { return this._reportType; }
            set { this._reportType = value; }
        }

        // Check to see if ReportType property is set
        internal bool IsSetReportType()
        {
            return this._reportType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the assessment was initiated.
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
        /// The current status of the assessment. Valid values include <c>SUCCESS</c>, <c>FAILED</c>,
        /// <c>PENDING</c>, and <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}