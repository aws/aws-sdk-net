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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about what an investigation analyzed. Only the identifier that
    /// matches <c>InvestigationType</c> is set.
    /// </summary>
    public partial class InvestigationScope
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that the investigation analyzed. Set only
        /// when <c>InvestigationType</c> is <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AdminAccountId. 
        /// <para>
        /// The ID of the administrator account of the organization that the investigation analyzed.
        /// Set only when <c>InvestigationType</c> is <c>ORGANIZATION</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AdminAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AdminAccountId property is set.
        /// </summary>
        internal bool IsSetAdminAccountId() => this.AdminAccountId != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The ID of the finding that the investigation analyzed. Set only when <c>InvestigationType</c>
        /// is <c>FINDING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property InvestigationType. 
        /// <para>
        /// The type of investigation. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FINDING</c> – An investigation of a specific GuardDuty finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCOUNT</c> – An investigation of the threat posture of an Amazon Web Services
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ORGANIZATION</c> – An investigation of your organization's threat posture.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InvestigationType InvestigationType { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationType property is set.
        /// </summary>
        internal bool IsSetInvestigationType() => this.InvestigationType != null;

        /// <summary>
        /// Gets and sets the property QueryTimeWindow. 
        /// <para>
        /// The time window over which the investigation queried data, set only when <c>InvestigationType</c>
        /// is <c>ACCOUNT</c> or <c>ORGANIZATION</c>.
        /// </para>
        /// </summary>
        public QueryTimeWindow QueryTimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the QueryTimeWindow property is set.
        /// </summary>
        internal bool IsSetQueryTimeWindow() => this.QueryTimeWindow != null;
    }
}
