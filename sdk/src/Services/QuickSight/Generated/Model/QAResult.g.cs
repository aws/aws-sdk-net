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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The QA result that is made from the <c>DashboardVisual</c> or <c>GeneratedAnswer</c>.
    /// </summary>
    public partial class QAResult
    {
        /// <summary>
        /// Gets and sets the property DashboardVisual. 
        /// <para>
        /// The representation of a dashboard visual result.
        /// </para>
        /// </summary>
        public DashboardVisualResult DashboardVisual { get; set; }

        /// <summary>
        /// Checks to see if the DashboardVisual property is set.
        /// </summary>
        internal bool IsSetDashboardVisual() => this.DashboardVisual != null;

        /// <summary>
        /// Gets and sets the property GeneratedAnswer. 
        /// <para>
        /// The representation of a generated answer result.
        /// </para>
        /// </summary>
        public GeneratedAnswerResult GeneratedAnswer { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedAnswer property is set.
        /// </summary>
        internal bool IsSetGeneratedAnswer() => this.GeneratedAnswer != null;

        /// <summary>
        /// Gets and sets the property ResultType. 
        /// <para>
        /// The type of QA result.
        /// </para>
        /// </summary>
        public QAResultType ResultType { get; set; }

        /// <summary>
        /// Checks to see if the ResultType property is set.
        /// </summary>
        internal bool IsSetResultType() => this.ResultType != null;
    }
}
