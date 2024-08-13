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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS scan.
    /// </summary>
    public partial class CisScan
    {
        private int? _failedChecks;
        private string _scanArn;
        private string _scanConfigurationArn;
        private DateTime? _scanDate;
        private string _scanName;
        private string _scheduledBy;
        private CisSecurityLevel _securityLevel;
        private CisScanStatus _status;
        private CisTargets _targets;
        private int? _totalChecks;

        /// <summary>
        /// Gets and sets the property FailedChecks. 
        /// <para>
        /// The CIS scan's failed checks.
        /// </para>
        /// </summary>
        public int? FailedChecks
        {
            get { return this._failedChecks; }
            set { this._failedChecks = value; }
        }

        // Check to see if FailedChecks property is set
        internal bool IsSetFailedChecks()
        {
            return this._failedChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The CIS scan's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanArn
        {
            get { return this._scanArn; }
            set { this._scanArn = value; }
        }

        // Check to see if ScanArn property is set
        internal bool IsSetScanArn()
        {
            return this._scanArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The CIS scan's configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanConfigurationArn
        {
            get { return this._scanConfigurationArn; }
            set { this._scanConfigurationArn = value; }
        }

        // Check to see if ScanConfigurationArn property is set
        internal bool IsSetScanConfigurationArn()
        {
            return this._scanConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScanDate. 
        /// <para>
        /// The CIS scan's date.
        /// </para>
        /// </summary>
        public DateTime? ScanDate
        {
            get { return this._scanDate; }
            set { this._scanDate = value; }
        }

        // Check to see if ScanDate property is set
        internal bool IsSetScanDate()
        {
            return this._scanDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The the name of the scan configuration that's associated with this scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ScanName
        {
            get { return this._scanName; }
            set { this._scanName = value; }
        }

        // Check to see if ScanName property is set
        internal bool IsSetScanName()
        {
            return this._scanName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledBy. 
        /// <para>
        /// The account or organization that schedules the CIS scan.
        /// </para>
        /// </summary>
        public string ScheduledBy
        {
            get { return this._scheduledBy; }
            set { this._scheduledBy = value; }
        }

        // Check to see if ScheduledBy property is set
        internal bool IsSetScheduledBy()
        {
            return this._scheduledBy != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityLevel. 
        /// <para>
        ///  The security level for the CIS scan. Security level refers to the Benchmark levels
        /// that CIS assigns to a profile. 
        /// </para>
        /// </summary>
        public CisSecurityLevel SecurityLevel
        {
            get { return this._securityLevel; }
            set { this._securityLevel = value; }
        }

        // Check to see if SecurityLevel property is set
        internal bool IsSetSecurityLevel()
        {
            return this._securityLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The CIS scan's status.
        /// </para>
        /// </summary>
        public CisScanStatus Status
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
        /// Gets and sets the property Targets. 
        /// <para>
        /// The CIS scan's targets.
        /// </para>
        /// </summary>
        public CisTargets Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null;
        }

        /// <summary>
        /// Gets and sets the property TotalChecks. 
        /// <para>
        /// The CIS scan's total checks.
        /// </para>
        /// </summary>
        public int? TotalChecks
        {
            get { return this._totalChecks; }
            set { this._totalChecks = value; }
        }

        // Check to see if TotalChecks property is set
        internal bool IsSetTotalChecks()
        {
            return this._totalChecks.HasValue; 
        }

    }
}