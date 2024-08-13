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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The number of Config rules or Amazon Web Services resources that are compliant and
    /// noncompliant.
    /// </summary>
    public partial class ComplianceSummary
    {
        private DateTime? _complianceSummaryTimestamp;
        private ComplianceContributorCount _compliantResourceCount;
        private ComplianceContributorCount _nonCompliantResourceCount;

        /// <summary>
        /// Gets and sets the property ComplianceSummaryTimestamp. 
        /// <para>
        /// The time that Config created the compliance summary.
        /// </para>
        /// </summary>
        public DateTime? ComplianceSummaryTimestamp
        {
            get { return this._complianceSummaryTimestamp; }
            set { this._complianceSummaryTimestamp = value; }
        }

        // Check to see if ComplianceSummaryTimestamp property is set
        internal bool IsSetComplianceSummaryTimestamp()
        {
            return this._complianceSummaryTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompliantResourceCount. 
        /// <para>
        /// The number of Config rules or Amazon Web Services resources that are compliant, up
        /// to a maximum of 25 for rules and 100 for resources.
        /// </para>
        /// </summary>
        public ComplianceContributorCount CompliantResourceCount
        {
            get { return this._compliantResourceCount; }
            set { this._compliantResourceCount = value; }
        }

        // Check to see if CompliantResourceCount property is set
        internal bool IsSetCompliantResourceCount()
        {
            return this._compliantResourceCount != null;
        }

        /// <summary>
        /// Gets and sets the property NonCompliantResourceCount. 
        /// <para>
        /// The number of Config rules or Amazon Web Services resources that are noncompliant,
        /// up to a maximum of 25 for rules and 100 for resources.
        /// </para>
        /// </summary>
        public ComplianceContributorCount NonCompliantResourceCount
        {
            get { return this._nonCompliantResourceCount; }
            set { this._nonCompliantResourceCount = value; }
        }

        // Check to see if NonCompliantResourceCount property is set
        internal bool IsSetNonCompliantResourceCount()
        {
            return this._nonCompliantResourceCount != null;
        }

    }
}