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
    /// Container for the parameters to the CreateAssessmentTarget operation.
    /// Creates a new assessment target using the ARN of the resource group that is generated
    /// by <a>CreateResourceGroup</a>. If resourceGroupArn is not specified, all EC2 instances
    /// in the current AWS account and region are included in the assessment target. If the
    /// <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
    /// role</a> isn’t already registered, this action also creates and registers a service-linked
    /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
    /// You can create up to 50 assessment targets per AWS account. You can run up to 500
    /// concurrent agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">
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
        [AWSProperty(Required=true, Min=1, Max=140)]
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
        /// If resourceGroupArn is not specified, all EC2 instances in the current AWS account
        /// and region are included in the assessment target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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