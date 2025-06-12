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
    /// Container for the parameters to the DescribeAssessmentTargets operation.
    /// Describes the assessment targets that are specified by the ARNs of the assessment
    /// targets.
    /// </summary>
    public partial class DescribeAssessmentTargetsRequest : AmazonInspectorRequest
    {
        private List<string> _assessmentTargetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AssessmentTargetArns. 
        /// <para>
        /// The ARNs that specifies the assessment targets that you want to describe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> AssessmentTargetArns
        {
            get { return this._assessmentTargetArns; }
            set { this._assessmentTargetArns = value; }
        }

        // Check to see if AssessmentTargetArns property is set
        internal bool IsSetAssessmentTargetArns()
        {
            return this._assessmentTargetArns != null && (this._assessmentTargetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}