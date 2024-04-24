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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the StopAssessmentRun operation.
    /// Stops the assessment run that is specified by the ARN of the assessment run.
    /// </summary>
    public partial class StopAssessmentRunRequest : AmazonInspectorRequest
    {
        private string _assessmentRunArn;
        private StopAction _stopAction;

        /// <summary>
        /// Gets and sets the property AssessmentRunArn. 
        /// <para>
        /// The ARN of the assessment run that you want to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string AssessmentRunArn
        {
            get { return this._assessmentRunArn; }
            set { this._assessmentRunArn = value; }
        }

        // Check to see if AssessmentRunArn property is set
        internal bool IsSetAssessmentRunArn()
        {
            return this._assessmentRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property StopAction. 
        /// <para>
        /// An input option that can be set to either START_EVALUATION or SKIP_EVALUATION. START_EVALUATION
        /// (the default value), stops the AWS agent from collecting data and begins the results
        /// evaluation and the findings generation process. SKIP_EVALUATION cancels the assessment
        /// run immediately, after which no findings are generated.
        /// </para>
        /// </summary>
        public StopAction StopAction
        {
            get { return this._stopAction; }
            set { this._stopAction = value; }
        }

        // Check to see if StopAction property is set
        internal bool IsSetStopAction()
        {
            return this._stopAction != null;
        }

    }
}