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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the StartAssessmentRun operation. Starts the assessment
    /// run specified by the ARN of the assessment template. For this API to function properly,
    /// you must not exceed the limit of running up to 500 concurrent agents per AWS account.
    /// </summary>
    public partial class StartAssessmentRunRequest : AmazonInspectorRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentRunName. 
        /// <para>
        /// You can specify the name for the assessment run. The name must be unique for the assessment
        /// template whose ARN is used to start the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 140)]
        public string AssessmentRunName { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentRunName property is set.
        /// </summary>
        internal bool IsSetAssessmentRunName() => this.AssessmentRunName != null;

        /// <summary>
        /// Gets and sets the property AssessmentTemplateArn. 
        /// <para>
        /// The ARN of the assessment template of the assessment run that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string AssessmentTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentTemplateArn property is set.
        /// </summary>
        internal bool IsSetAssessmentTemplateArn() => this.AssessmentTemplateArn != null;
    }
}
