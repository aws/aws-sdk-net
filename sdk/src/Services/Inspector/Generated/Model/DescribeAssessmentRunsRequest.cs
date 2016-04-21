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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
    /// Container for the parameters to the DescribeAssessmentRuns operation.
    /// Describes the assessment runs that are specified by the ARNs of the assessment runs.
    /// </summary>
    public partial class DescribeAssessmentRunsRequest : AmazonInspectorRequest
    {
        private List<string> _assessmentRunArns = new List<string>();

        /// <summary>
        /// Gets and sets the property AssessmentRunArns. 
        /// <para>
        /// The ARN that specifies the assessment run that you want to describe.
        /// </para>
        /// </summary>
        public List<string> AssessmentRunArns
        {
            get { return this._assessmentRunArns; }
            set { this._assessmentRunArns = value; }
        }

        // Check to see if AssessmentRunArns property is set
        internal bool IsSetAssessmentRunArns()
        {
            return this._assessmentRunArns != null && this._assessmentRunArns.Count > 0; 
        }

    }
}