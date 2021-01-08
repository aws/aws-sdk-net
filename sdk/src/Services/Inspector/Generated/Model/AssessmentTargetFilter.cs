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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Used as the request parameter in the <a>ListAssessmentTargets</a> action.
    /// </summary>
    public partial class AssessmentTargetFilter
    {
        private string _assessmentTargetNamePattern;

        /// <summary>
        /// Gets and sets the property AssessmentTargetNamePattern. 
        /// <para>
        /// For a record to match a filter, an explicit value or a string that contains a wildcard
        /// that is specified for this data type property must match the value of the <b>assessmentTargetName</b>
        /// property of the <a>AssessmentTarget</a> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
        public string AssessmentTargetNamePattern
        {
            get { return this._assessmentTargetNamePattern; }
            set { this._assessmentTargetNamePattern = value; }
        }

        // Check to see if AssessmentTargetNamePattern property is set
        internal bool IsSetAssessmentTargetNamePattern()
        {
            return this._assessmentTargetNamePattern != null;
        }

    }
}