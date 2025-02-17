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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private DashboardVisualResult _dashboardVisual;
        private GeneratedAnswerResult _generatedAnswer;
        private QAResultType _resultType;

        /// <summary>
        /// Gets and sets the property DashboardVisual. 
        /// <para>
        /// The representation of a dashboard visual result.
        /// </para>
        /// </summary>
        public DashboardVisualResult DashboardVisual
        {
            get { return this._dashboardVisual; }
            set { this._dashboardVisual = value; }
        }

        // Check to see if DashboardVisual property is set
        internal bool IsSetDashboardVisual()
        {
            return this._dashboardVisual != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedAnswer. 
        /// <para>
        /// The representation of a generated answer result.
        /// </para>
        /// </summary>
        public GeneratedAnswerResult GeneratedAnswer
        {
            get { return this._generatedAnswer; }
            set { this._generatedAnswer = value; }
        }

        // Check to see if GeneratedAnswer property is set
        internal bool IsSetGeneratedAnswer()
        {
            return this._generatedAnswer != null;
        }

        /// <summary>
        /// Gets and sets the property ResultType. 
        /// <para>
        /// The type of QA result.
        /// </para>
        /// </summary>
        public QAResultType ResultType
        {
            get { return this._resultType; }
            set { this._resultType = value; }
        }

        // Check to see if ResultType property is set
        internal bool IsSetResultType()
        {
            return this._resultType != null;
        }

    }
}