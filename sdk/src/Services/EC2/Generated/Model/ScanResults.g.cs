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
        public DateTime? CriticalFixAvailableSince { get; set; }

        /// <summary>
        /// Checks to see if the CriticalFixAvailableSince property is set.
        /// </summary>
        internal bool IsSetCriticalFixAvailableSince() => this.CriticalFixAvailableSince.HasValue;

        /// <summary>
        /// Gets and sets the property FindingScanDate. 
        /// <para>
        /// The date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// of the most recent Amazon Inspector scan of the AMI.
        /// </para>
        /// </summary>
        public DateTime? FindingScanDate { get; set; }

        /// <summary>
        /// Checks to see if the FindingScanDate property is set.
        /// </summary>
        internal bool IsSetFindingScanDate() => this.FindingScanDate.HasValue;

        /// <summary>
        /// Gets and sets the property HighFixAvailableSince. 
        /// <para>
        /// The earliest date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// at which Amazon Inspector reported a fix as available for a <c>high</c> severity finding
        /// on the AMI. This value is present only if the AMI has at least one <c>high</c> severity
        /// finding with a fix available. Amazon Inspector recomputes this value on each scan.
        /// </para>
        /// </summary>
        public DateTime? HighFixAvailableSince { get; set; }

        /// <summary>
        /// Checks to see if the HighFixAvailableSince property is set.
        /// </summary>
        internal bool IsSetHighFixAvailableSince() => this.HighFixAvailableSince.HasValue;

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
        public SeverityLabel HighestFindingSeverityLabel { get; set; }

        /// <summary>
        /// Checks to see if the HighestFindingSeverityLabel property is set.
        /// </summary>
        internal bool IsSetHighestFindingSeverityLabel() => this.HighestFindingSeverityLabel != null;

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
        public DateTime? InformationalFixAvailableSince { get; set; }

        /// <summary>
        /// Checks to see if the InformationalFixAvailableSince property is set.
        /// </summary>
        internal bool IsSetInformationalFixAvailableSince() => this.InformationalFixAvailableSince.HasValue;

        /// <summary>
        /// Gets and sets the property LowFixAvailableSince. 
        /// <para>
        /// The earliest date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// at which Amazon Inspector reported a fix as available for a <c>low</c> severity finding
        /// on the AMI. This value is present only if the AMI has at least one <c>low</c> severity
        /// finding with a fix available. Amazon Inspector recomputes this value on each scan.
        /// </para>
        /// </summary>
        public DateTime? LowFixAvailableSince { get; set; }

        /// <summary>
        /// Checks to see if the LowFixAvailableSince property is set.
        /// </summary>
        internal bool IsSetLowFixAvailableSince() => this.LowFixAvailableSince.HasValue;

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
        public DateTime? MediumFixAvailableSince { get; set; }

        /// <summary>
        /// Checks to see if the MediumFixAvailableSince property is set.
        /// </summary>
        internal bool IsSetMediumFixAvailableSince() => this.MediumFixAvailableSince.HasValue;
    }
}
