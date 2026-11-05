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
    /// The stop CIS message progress.
    /// </summary>
    public partial class StopCisMessageProgress
    {
        /// <summary>
        /// Gets and sets the property ErrorChecks. 
        /// <para>
        /// The progress' error checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? ErrorChecks { get; set; }

        /// <summary>
        /// Checks to see if the ErrorChecks property is set.
        /// </summary>
        internal bool IsSetErrorChecks() => this.ErrorChecks.HasValue;

        /// <summary>
        /// Gets and sets the property FailedChecks. 
        /// <para>
        /// The progress' failed checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? FailedChecks { get; set; }

        /// <summary>
        /// Checks to see if the FailedChecks property is set.
        /// </summary>
        internal bool IsSetFailedChecks() => this.FailedChecks.HasValue;

        /// <summary>
        /// Gets and sets the property InformationalChecks. 
        /// <para>
        /// The progress' informational checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? InformationalChecks { get; set; }

        /// <summary>
        /// Checks to see if the InformationalChecks property is set.
        /// </summary>
        internal bool IsSetInformationalChecks() => this.InformationalChecks.HasValue;

        /// <summary>
        /// Gets and sets the property NotApplicableChecks. 
        /// <para>
        /// The progress' not applicable checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? NotApplicableChecks { get; set; }

        /// <summary>
        /// Checks to see if the NotApplicableChecks property is set.
        /// </summary>
        internal bool IsSetNotApplicableChecks() => this.NotApplicableChecks.HasValue;

        /// <summary>
        /// Gets and sets the property NotEvaluatedChecks. 
        /// <para>
        /// The progress' not evaluated checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? NotEvaluatedChecks { get; set; }

        /// <summary>
        /// Checks to see if the NotEvaluatedChecks property is set.
        /// </summary>
        internal bool IsSetNotEvaluatedChecks() => this.NotEvaluatedChecks.HasValue;

        /// <summary>
        /// Gets and sets the property SuccessfulChecks. 
        /// <para>
        /// The progress' successful checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? SuccessfulChecks { get; set; }

        /// <summary>
        /// Checks to see if the SuccessfulChecks property is set.
        /// </summary>
        internal bool IsSetSuccessfulChecks() => this.SuccessfulChecks.HasValue;

        /// <summary>
        /// Gets and sets the property TotalChecks. 
        /// <para>
        /// The progress' total checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? TotalChecks { get; set; }

        /// <summary>
        /// Checks to see if the TotalChecks property is set.
        /// </summary>
        internal bool IsSetTotalChecks() => this.TotalChecks.HasValue;

        /// <summary>
        /// Gets and sets the property UnknownChecks. 
        /// <para>
        /// The progress' unknown checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? UnknownChecks { get; set; }

        /// <summary>
        /// Checks to see if the UnknownChecks property is set.
        /// </summary>
        internal bool IsSetUnknownChecks() => this.UnknownChecks.HasValue;
    }
}
