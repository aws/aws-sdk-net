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
    /// Container for the parameters to the RunAssessment operation.
    /// Starts the analysis of the application’s behavior against selected rule packages for
    /// the assessment specified by the assessment ARN.
    /// </summary>
    public partial class RunAssessmentRequest : AmazonInspectorRequest
    {
        private string _assessmentArn;
        private string _runName;

        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The ARN of the assessment that you want to run.
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
        /// Gets and sets the property RunName. 
        /// <para>
        /// A name specifying the run of the assessment.
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

    }
}