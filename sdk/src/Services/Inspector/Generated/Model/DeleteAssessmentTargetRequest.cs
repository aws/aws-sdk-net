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
    /// Container for the parameters to the DeleteAssessmentTarget operation.
    /// Deletes the assessment target that is specified by the ARN of the assessment target.
    /// </summary>
    public partial class DeleteAssessmentTargetRequest : AmazonInspectorRequest
    {
        private string _assessmentTargetArn;

        /// <summary>
        /// Gets and sets the property AssessmentTargetArn. 
        /// <para>
        /// The ARN that specifies the assessment target that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string AssessmentTargetArn
        {
            get { return this._assessmentTargetArn; }
            set { this._assessmentTargetArn = value; }
        }

        // Check to see if AssessmentTargetArn property is set
        internal bool IsSetAssessmentTargetArn()
        {
            return this._assessmentTargetArn != null;
        }

    }
}