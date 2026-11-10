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
    /// Provides a summary of the performance status check results for an instance.
    /// </summary>
    public partial class PerformanceStatusSummary
    {
        /// <summary>
        /// Gets and sets the property ImpairedSince. 
        /// <para>
        /// The date and time when the performance status became impaired.
        /// </para>
        /// </summary>
        public DateTime? ImpairedSince { get; set; }

        /// <summary>
        /// Checks to see if the ImpairedSince property is set.
        /// </summary>
        internal bool IsSetImpairedSince() => this.ImpairedSince.HasValue;

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// The recommended action to remediate the impaired instance, if one is available. This
        /// value is returned only when the instance is impaired.
        /// </para>
        /// </summary>
        public string Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status.
        /// </para>
        /// </summary>
        public SummaryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
