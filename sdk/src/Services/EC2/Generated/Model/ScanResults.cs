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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The Amazon Inspector scan results for an AMI. This information is present only for
    /// AMIs that Amazon Inspector has scanned.
    /// 
    ///  
    /// <para>
    /// When you share an AMI with other accounts, organizations, or organizational units
    /// (OUs), or make it public, its scan results are available to the accounts that can
    /// use the AMI.
    /// </para>
    ///  
    /// <para>
    /// The fix-available dates are specific to the AMI. Each date reflects when a fix became
    /// available for a finding on that AMI, not when the vendor released the fix. As a result,
    /// a date can be later than the vendor's release date, and AMIs with the same vulnerability
    /// can have different dates.
    /// </para>
    /// </summary>
    public partial class ScanResults
    {
        private DateTime? _criticalFixAvailableSince;
        private DateTime? _findingScanDate;
        private SeverityLabel _highestFindingSeverityLabel;
        private DateTime? _highFixAvailableSince;
        private DateTime? _informationalFixAvailableSince;
        private DateTime? _lowFixAvailableSince;
        private DateTime? _mediumFixAvailableSince;

        /// <summary>
        /// Gets and sets the property CriticalFixAvailableSince. 
        /// <para>
        /// The earliest date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// at which Amazon Inspector reported a fix as available for a <c>critical</c> severity
        /// finding on the AMI. This value is present only if the AMI has at least one <c>critical</c>
        /// severity finding with a fix available. Amazon Inspector recomputes this value on each
        /// scan.
        /// </para>
        /// </summary>
        public DateTime? CriticalFixAvailableSince
        {
            get { return this._criticalFixAvailableSince; }
            set { this._criticalFixAvailableSince = value; }
        }

        // Check to see if CriticalFixAvailableSince property is set
        internal bool IsSetCriticalFixAvailableSince()
        {
            return this._criticalFixAvailableSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FindingScanDate. 
        /// <para>
        /// The date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// of the most recent Amazon Inspector scan of the AMI.
        /// </para>
        /// </summary>
        public DateTime? FindingScanDate
        {
            get { return this._findingScanDate; }
            set { this._findingScanDate = value; }
        }

        // Check to see if FindingScanDate property is set
        internal bool IsSetFindingScanDate()
        {
            return this._findingScanDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HighestFindingSeverityLabel. 
        /// <para>
        /// The highest severity among the AMI's Amazon Inspector findings, whether or not a fix
        /// is available.
        /// </para>
        ///  
        /// <para>
        /// The valid values are the following Amazon Inspector severity levels, which correspond
        /// to CVSS score ranges:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>informational</c> - CVSS score of 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>low</c> - CVSS score of 0.1 to 3.9.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>medium</c> - CVSS score of 4.0 to 6.9.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>high</c> - CVSS score of 7.0 to 8.9.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>critical</c> - CVSS score of 9.0 to 10.0.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/user/findings-understanding-severity.html#findings-understanding-package-score">Software
        /// package vulnerability severity</a> in the <i>Amazon Inspector User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This value is present only if the AMI has at least one finding.
        /// </para>
        /// </summary>
        public SeverityLabel HighestFindingSeverityLabel
        {
            get { return this._highestFindingSeverityLabel; }
            set { this._highestFindingSeverityLabel = value; }
        }

        // Check to see if HighestFindingSeverityLabel property is set
        internal bool IsSetHighestFindingSeverityLabel()
        {
            return this._highestFindingSeverityLabel != null;
        }

        /// <summary>
        /// Gets and sets the property HighFixAvailableSince. 
        /// <para>
        /// The earliest date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// at which Amazon Inspector reported a fix as available for a <c>high</c> severity finding
        /// on the AMI. This value is present only if the AMI has at least one <c>high</c> severity
        /// finding with a fix available. Amazon Inspector recomputes this value on each scan.
        /// </para>
        /// </summary>
        public DateTime? HighFixAvailableSince
        {
            get { return this._highFixAvailableSince; }
            set { this._highFixAvailableSince = value; }
        }

        // Check to see if HighFixAvailableSince property is set
        internal bool IsSetHighFixAvailableSince()
        {
            return this._highFixAvailableSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InformationalFixAvailableSince. 
        /// <para>
        /// The earliest date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// at which Amazon Inspector reported a fix as available for an <c>informational</c>
        /// severity finding on the AMI. This value is present only if the AMI has at least one
        /// <c>informational</c> severity finding with a fix available. Amazon Inspector recomputes
        /// this value on each scan.
        /// </para>
        /// </summary>
        public DateTime? InformationalFixAvailableSince
        {
            get { return this._informationalFixAvailableSince; }
            set { this._informationalFixAvailableSince = value; }
        }

        // Check to see if InformationalFixAvailableSince property is set
        internal bool IsSetInformationalFixAvailableSince()
        {
            return this._informationalFixAvailableSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LowFixAvailableSince. 
        /// <para>
        /// The earliest date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// at which Amazon Inspector reported a fix as available for a <c>low</c> severity finding
        /// on the AMI. This value is present only if the AMI has at least one <c>low</c> severity
        /// finding with a fix available. Amazon Inspector recomputes this value on each scan.
        /// </para>
        /// </summary>
        public DateTime? LowFixAvailableSince
        {
            get { return this._lowFixAvailableSince; }
            set { this._lowFixAvailableSince = value; }
        }

        // Check to see if LowFixAvailableSince property is set
        internal bool IsSetLowFixAvailableSince()
        {
            return this._lowFixAvailableSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediumFixAvailableSince. 
        /// <para>
        /// The earliest date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// at which Amazon Inspector reported a fix as available for a <c>medium</c> severity
        /// finding on the AMI. This value is present only if the AMI has at least one <c>medium</c>
        /// severity finding with a fix available. Amazon Inspector recomputes this value on each
        /// scan.
        /// </para>
        /// </summary>
        public DateTime? MediumFixAvailableSince
        {
            get { return this._mediumFixAvailableSince; }
            set { this._mediumFixAvailableSince = value; }
        }

        // Check to see if MediumFixAvailableSince property is set
        internal bool IsSetMediumFixAvailableSince()
        {
            return this._mediumFixAvailableSince.HasValue; 
        }

    }
}