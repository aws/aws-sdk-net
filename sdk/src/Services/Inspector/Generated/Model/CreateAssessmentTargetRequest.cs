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
    /// Container for the parameters to the CreateAssessmentTarget operation.
    /// Creates a new assessment target using the ARN of the resource group that is generated
    /// by <a>CreateResourceGroup</a>. You can create up to 50 assessment targets per AWS
    /// account. You can run up to 500 concurrent agents per AWS account. For more information,
    /// see <a href="http://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">
    /// Amazon Inspector Assessment Targets</a>.
    /// </summary>
    public partial class CreateAssessmentTargetRequest : AmazonInspectorRequest
    {
        private string _assessmentTargetName;
        private string _resourceGroupArn;

        /// <summary>
        /// Gets and sets the property AssessmentTargetName. 
        /// <para>
        /// The user-defined name that identifies the assessment target that you want to create.
        /// The name must be unique within the AWS account.
        /// </para>
        /// </summary>
        public string AssessmentTargetName
        {
            get { return this._assessmentTargetName; }
            set { this._assessmentTargetName = value; }
        }

        // Check to see if AssessmentTargetName property is set
        internal bool IsSetAssessmentTargetName()
        {
            return this._assessmentTargetName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupArn. 
        /// <para>
        /// The ARN that specifies the resource group that is used to create the assessment target.
        /// </para>
        /// </summary>
        public string ResourceGroupArn
        {
            get { return this._resourceGroupArn; }
            set { this._resourceGroupArn = value; }
        }

        // Check to see if ResourceGroupArn property is set
        internal bool IsSetResourceGroupArn()
        {
            return this._resourceGroupArn != null;
        }

    }
}