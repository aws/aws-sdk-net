/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// A snapshot of an Inspector assessment that contains the assessment's findings.
    /// 
    ///  
    /// <para>
    /// This data type is used as the response element in the <a>DescribeRun</a> action.
    /// </para>
    /// </summary>
    public partial class Run
    {
        private string _assessmentArn;
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private List<string> _rulesPackages = new List<string>();
        private string _runArn;
        private string _runName;
        private string _runState;

        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The ARN of the assessment that is associated with the run.
        /// </para>
        /// </summary>
        public string AssessmentArn
        {
            get { return this._assessmentArn; }
            set { this._assessmentArn = value; }
        }

        // Check to see if AssessmentArn property is set
        internal bool IsSetAssessmentArn()
        {
            return this._assessmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// Run completion time that corresponds to the rules packages evaluation completion time
        /// or failure.
        /// </para>
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Run creation time that corresponds to the data collection completion time or failure.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RulesPackages. 
        /// <para>
        /// Rules packages selected for the run of the assessment.
        /// </para>
        /// </summary>
        public List<string> RulesPackages
        {
            get { return this._rulesPackages; }
            set { this._rulesPackages = value; }
        }

        // Check to see if RulesPackages property is set
        internal bool IsSetRulesPackages()
        {
            return this._rulesPackages != null && this._rulesPackages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RunArn. 
        /// <para>
        /// The ARN of the run.
        /// </para>
        /// </summary>
        public string RunArn
        {
            get { return this._runArn; }
            set { this._runArn = value; }
        }

        // Check to see if RunArn property is set
        internal bool IsSetRunArn()
        {
            return this._runArn != null;
        }

        /// <summary>
        /// Gets and sets the property RunName. 
        /// <para>
        /// The auto-generated name for the run. 
        /// </para>
        /// </summary>
        public string RunName
        {
            get { return this._runName; }
            set { this._runName = value; }
        }

        // Check to see if RunName property is set
        internal bool IsSetRunName()
        {
            return this._runName != null;
        }

        /// <summary>
        /// Gets and sets the property RunState. 
        /// <para>
        /// The state of the run. Values can be set to <i>DataCollectionComplete</i>, <i>EvaluatingPolicies</i>,
        /// <i>EvaluatingPoliciesErrorCanRetry</i>, <i>Completed</i>, <i>Failed</i>, <i>TombStoned</i>.
        /// </para>
        /// </summary>
        public string RunState
        {
            get { return this._runState; }
            set { this._runState = value; }
        }

        // Check to see if RunState property is set
        internal bool IsSetRunState()
        {
            return this._runState != null;
        }

    }
}