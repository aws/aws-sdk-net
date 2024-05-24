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
    /// Container for the parameters to the UpdateAssessmentTarget operation.
    /// Updates the assessment target that is specified by the ARN of the assessment target.
    /// 
    ///  
    /// <para>
    /// If resourceGroupArn is not specified, all EC2 instances in the current AWS account
    /// and region are included in the assessment target.
    /// </para>
    /// </summary>
    public partial class UpdateAssessmentTargetRequest : AmazonInspectorRequest
    {
        private string _assessmentTargetArn;
        private string _assessmentTargetName;
        private string _resourceGroupArn;

        /// <summary>
        /// Gets and sets the property AssessmentTargetArn. 
        /// <para>
        /// The ARN of the assessment target that you want to update.
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

        /// <summary>
        /// Gets and sets the property AssessmentTargetName. 
        /// <para>
        /// The name of the assessment target that you want to update.
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
        /// The ARN of the resource group that is used to specify the new resource group to associate
        /// with the assessment target.
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