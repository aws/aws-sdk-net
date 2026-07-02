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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
        private string _executiveSummary;
        private string _reasonsNotToLaunch;
        private string _reasonsToLaunch;

        /// <summary>
        /// Gets and sets the property ExecutiveSummary. 
        /// <para>
        /// A summary of the experiment outcome and key findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ExecutiveSummary
        {
            get { return this._executiveSummary; }
            set { this._executiveSummary = value; }
        }

        // Check to see if ExecutiveSummary property is set
        internal bool IsSetExecutiveSummary()
        {
            return this._executiveSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonsNotToLaunch. 
        /// <para>
        /// Evidence against launching the treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ReasonsNotToLaunch
        {
            get { return this._reasonsNotToLaunch; }
            set { this._reasonsNotToLaunch = value; }
        }

        // Check to see if ReasonsNotToLaunch property is set
        internal bool IsSetReasonsNotToLaunch()
        {
            return this._reasonsNotToLaunch != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonsToLaunch. 
        /// <para>
        /// Evidence in favor of launching the winning treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ReasonsToLaunch
        {
            get { return this._reasonsToLaunch; }
            set { this._reasonsToLaunch = value; }
        }

        // Check to see if ReasonsToLaunch property is set
        internal bool IsSetReasonsToLaunch()
        {
            return this._reasonsToLaunch != null;
        }

    }
}