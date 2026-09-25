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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// The result of an experiment run, including the executive summary and launch decision
    /// rationale.
    /// </summary>
    public partial class ExperimentRunResult
    {
        /// <summary>
        /// Gets and sets the property ExecutiveSummary. 
        /// <para>
        /// A summary of the experiment outcome and key findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ExecutiveSummary { get; set; }

        /// <summary>
        /// Checks to see if the ExecutiveSummary property is set.
        /// </summary>
        internal bool IsSetExecutiveSummary() => this.ExecutiveSummary != null;

        /// <summary>
        /// Gets and sets the property ReasonsNotToLaunch. 
        /// <para>
        /// Evidence against launching the treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ReasonsNotToLaunch { get; set; }

        /// <summary>
        /// Checks to see if the ReasonsNotToLaunch property is set.
        /// </summary>
        internal bool IsSetReasonsNotToLaunch() => this.ReasonsNotToLaunch != null;

        /// <summary>
        /// Gets and sets the property ReasonsToLaunch. 
        /// <para>
        /// Evidence in favor of launching the winning treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ReasonsToLaunch { get; set; }

        /// <summary>
        /// Checks to see if the ReasonsToLaunch property is set.
        /// </summary>
        internal bool IsSetReasonsToLaunch() => this.ReasonsToLaunch != null;
    }
}
