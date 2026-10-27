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
    /// The Amazon Inspector scan-result criteria that an AMI must meet to be allowed. The
    /// criteria can limit the highest finding severity. They can also limit, for each severity,
    /// the days since Amazon Inspector reported a fix as available.
    /// 
    ///  
    /// <para>
    /// The severity limit applies to all findings, whether or not a fix is available. The
    /// day limits for each severity apply only to findings that have a fix available. A scanned
    /// AMI that has no fix-available finding of a given severity meets that severity's day
    /// limit. AMIs that Amazon Inspector has not scanned are not allowed when you specify
    /// this condition.
    /// </para>
    /// </summary>
    public partial class ScanResultConditionRequest
    {
        private int? _maxDaysSinceCriticalFixAvailable;
        private int? _maxDaysSinceHighFixAvailable;
        private int? _maxDaysSinceInformationalFixAvailable;
        private int? _maxDaysSinceLastFindingScan;
        private int? _maxDaysSinceLowFixAvailable;
        private int? _maxDaysSinceMediumFixAvailable;
        private SeverityLabel _maximumSeverityLabel;

        /// <summary>
        /// Gets and sets the property MaxDaysSinceCriticalFixAvailable. 
        /// <para>
        /// The maximum number of days since Amazon Inspector reported a fix as available for
        /// a <c>critical</c> severity finding on the AMI. For example, a value of <c>7</c> does
        /// not allow an AMI if Amazon Inspector reported such a fix more than 7 days ago.
        /// </para>
        ///  
        /// <para>
        /// A scanned AMI that has no <c>critical</c> severity finding with a fix available meets
        /// this limit. AMIs that Amazon Inspector has not scanned are not allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum value of 0. Maximum value of 2147483647.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxDaysSinceCriticalFixAvailable
        {
            get { return this._maxDaysSinceCriticalFixAvailable; }
            set { this._maxDaysSinceCriticalFixAvailable = value; }
        }

        // Check to see if MaxDaysSinceCriticalFixAvailable property is set
        internal bool IsSetMaxDaysSinceCriticalFixAvailable()
        {
            return this._maxDaysSinceCriticalFixAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDaysSinceHighFixAvailable. 
        /// <para>
        /// The maximum number of days since Amazon Inspector reported a fix as available for
        /// a <c>high</c> severity finding on the AMI. For example, a value of <c>7</c> does not
        /// allow an AMI if Amazon Inspector reported such a fix more than 7 days ago.
        /// </para>
        ///  
        /// <para>
        /// A scanned AMI that has no <c>high</c> severity finding with a fix available meets
        /// this limit. AMIs that Amazon Inspector has not scanned are not allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum value of 0. Maximum value of 2147483647.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxDaysSinceHighFixAvailable
        {
            get { return this._maxDaysSinceHighFixAvailable; }
            set { this._maxDaysSinceHighFixAvailable = value; }
        }

        // Check to see if MaxDaysSinceHighFixAvailable property is set
        internal bool IsSetMaxDaysSinceHighFixAvailable()
        {
            return this._maxDaysSinceHighFixAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDaysSinceInformationalFixAvailable. 
        /// <para>
        /// The maximum number of days since Amazon Inspector reported a fix as available for
        /// an <c>informational</c> severity finding on the AMI. For example, a value of <c>7</c>
        /// does not allow an AMI if Amazon Inspector reported such a fix more than 7 days ago.
        /// </para>
        ///  
        /// <para>
        /// A scanned AMI that has no <c>informational</c> severity finding with a fix available
        /// meets this limit. AMIs that Amazon Inspector has not scanned are not allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum value of 0. Maximum value of 2147483647.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxDaysSinceInformationalFixAvailable
        {
            get { return this._maxDaysSinceInformationalFixAvailable; }
            set { this._maxDaysSinceInformationalFixAvailable = value; }
        }

        // Check to see if MaxDaysSinceInformationalFixAvailable property is set
        internal bool IsSetMaxDaysSinceInformationalFixAvailable()
        {
            return this._maxDaysSinceInformationalFixAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDaysSinceLastFindingScan. 
        /// <para>
        /// The maximum number of days that have elapsed since Amazon Inspector last scanned the
        /// AMI. For example, a value of <c>7</c> allows AMIs that were scanned within the last
        /// 7 days. AMIs that Amazon Inspector has not scanned are not allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum value of 0. Maximum value of 2147483647.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxDaysSinceLastFindingScan
        {
            get { return this._maxDaysSinceLastFindingScan; }
            set { this._maxDaysSinceLastFindingScan = value; }
        }

        // Check to see if MaxDaysSinceLastFindingScan property is set
        internal bool IsSetMaxDaysSinceLastFindingScan()
        {
            return this._maxDaysSinceLastFindingScan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDaysSinceLowFixAvailable. 
        /// <para>
        /// The maximum number of days since Amazon Inspector reported a fix as available for
        /// a <c>low</c> severity finding on the AMI. For example, a value of <c>7</c> does not
        /// allow an AMI if Amazon Inspector reported such a fix more than 7 days ago.
        /// </para>
        ///  
        /// <para>
        /// A scanned AMI that has no <c>low</c> severity finding with a fix available meets this
        /// limit. AMIs that Amazon Inspector has not scanned are not allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum value of 0. Maximum value of 2147483647.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxDaysSinceLowFixAvailable
        {
            get { return this._maxDaysSinceLowFixAvailable; }
            set { this._maxDaysSinceLowFixAvailable = value; }
        }

        // Check to see if MaxDaysSinceLowFixAvailable property is set
        internal bool IsSetMaxDaysSinceLowFixAvailable()
        {
            return this._maxDaysSinceLowFixAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDaysSinceMediumFixAvailable. 
        /// <para>
        /// The maximum number of days since Amazon Inspector reported a fix as available for
        /// a <c>medium</c> severity finding on the AMI. For example, a value of <c>7</c> does
        /// not allow an AMI if Amazon Inspector reported such a fix more than 7 days ago.
        /// </para>
        ///  
        /// <para>
        /// A scanned AMI that has no <c>medium</c> severity finding with a fix available meets
        /// this limit. AMIs that Amazon Inspector has not scanned are not allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum value of 0. Maximum value of 2147483647.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxDaysSinceMediumFixAvailable
        {
            get { return this._maxDaysSinceMediumFixAvailable; }
            set { this._maxDaysSinceMediumFixAvailable = value; }
        }

        // Check to see if MaxDaysSinceMediumFixAvailable property is set
        internal bool IsSetMaxDaysSinceMediumFixAvailable()
        {
            return this._maxDaysSinceMediumFixAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumSeverityLabel. 
        /// <para>
        /// The maximum severity that an AMI's Amazon Inspector findings can have for the AMI
        /// to be allowed. Findings count whether or not a fix is available. For example, a value
        /// of <c>medium</c> allows AMIs whose highest severity is <c>informational</c>, <c>low</c>,
        /// or <c>medium</c>.
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
        /// A scanned AMI that has no findings meets this limit.
        /// </para>
        ///  
        /// <para>
        /// AMIs that Amazon Inspector has not scanned are not allowed when you specify this condition.
        /// </para>
        /// </summary>
        public SeverityLabel MaximumSeverityLabel
        {
            get { return this._maximumSeverityLabel; }
            set { this._maximumSeverityLabel = value; }
        }

        // Check to see if MaximumSeverityLabel property is set
        internal bool IsSetMaximumSeverityLabel()
        {
            return this._maximumSeverityLabel != null;
        }

    }
}