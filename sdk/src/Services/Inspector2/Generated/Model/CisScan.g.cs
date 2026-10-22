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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS scan.
    /// </summary>
    public partial class CisScan
    {
        /// <summary>
        /// Gets and sets the property FailedChecks. 
        /// <para>
        /// The CIS scan's failed checks.
        /// </para>
        /// </summary>
        public int? FailedChecks { get; set; }

        /// <summary>
        /// Checks to see if the FailedChecks property is set.
        /// </summary>
        internal bool IsSetFailedChecks() => this.FailedChecks.HasValue;

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The CIS scan's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanArn property is set.
        /// </summary>
        internal bool IsSetScanArn() => this.ScanArn != null;

        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The CIS scan's configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanConfigurationArn property is set.
        /// </summary>
        internal bool IsSetScanConfigurationArn() => this.ScanConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ScanDate. 
        /// <para>
        /// The CIS scan's date.
        /// </para>
        /// </summary>
        public DateTime? ScanDate { get; set; }

        /// <summary>
        /// Checks to see if the ScanDate property is set.
        /// </summary>
        internal bool IsSetScanDate() => this.ScanDate.HasValue;

        /// <summary>
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The the name of the scan configuration that's associated with this scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ScanName { get; set; }

        /// <summary>
        /// Checks to see if the ScanName property is set.
        /// </summary>
        internal bool IsSetScanName() => this.ScanName != null;

        /// <summary>
        /// Gets and sets the property ScheduledBy. 
        /// <para>
        /// The account or organization that schedules the CIS scan.
        /// </para>
        /// </summary>
        public string ScheduledBy { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledBy property is set.
        /// </summary>
        internal bool IsSetScheduledBy() => this.ScheduledBy != null;

        /// <summary>
        /// Gets and sets the property SecurityLevel. 
        /// <para>
        ///  The security level for the CIS scan. Security level refers to the Benchmark levels
        /// that CIS assigns to a profile. 
        /// </para>
        /// </summary>
        public CisSecurityLevel SecurityLevel { get; set; }

        /// <summary>
        /// Checks to see if the SecurityLevel property is set.
        /// </summary>
        internal bool IsSetSecurityLevel() => this.SecurityLevel != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The CIS scan's status.
        /// </para>
        /// </summary>
        public CisScanStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The CIS scan's targets.
        /// </para>
        /// </summary>
        public CisTargets Targets { get; set; }

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null;

        /// <summary>
        /// Gets and sets the property TotalChecks. 
        /// <para>
        /// The CIS scan's total checks.
        /// </para>
        /// </summary>
        public int? TotalChecks { get; set; }

        /// <summary>
        /// Checks to see if the TotalChecks property is set.
        /// </summary>
        internal bool IsSetTotalChecks() => this.TotalChecks.HasValue;
    }
}
