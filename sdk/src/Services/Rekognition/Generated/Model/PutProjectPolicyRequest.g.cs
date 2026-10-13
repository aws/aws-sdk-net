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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the PutProjectPolicy operation. <note> <para> This
    /// operation applies only to Amazon Rekognition Custom Labels. </para> </note> <para>
    /// Attaches a project policy to a Amazon Rekognition Custom Labels project in a trusting
    /// AWS account. A project policy specifies that a trusted AWS account can copy a model
    /// version from a trusting AWS account to a project in the trusted AWS account. To copy
    /// a model version you use the <a>CopyProjectVersion</a> operation. Only applies to Custom
    /// Labels projects. </para> <para> For more information about the format of a project
    /// policy document, see Attaching a project policy (SDK) in the <i>Amazon Rekognition
    /// Custom Labels Developer Guide</i>. </para> <para> The response from <c>PutProjectPolicy</c>
    /// is a revision ID for the project policy. You can attach multiple project policies
    /// to a project. You can also update an existing project policy by specifying the policy
    /// revision ID of the existing policy. </para> <para> To remove a project policy from
    /// a project, call <a>DeleteProjectPolicy</a>. To get a list of project policies attached
    /// to a project, call <a>ListProjectPolicies</a>. </para> <para> You copy a model version
    /// by calling <a>CopyProjectVersion</a>. </para> <para> This operation requires permissions
    /// to perform the <c>rekognition:PutProjectPolicy</c> action. </para>
    /// </summary>
    public partial class PutProjectPolicyRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// A resource policy to add to the model. The policy is a JSON structure that contains
        /// one or more statements that define the policy. The policy must follow the IAM syntax.
        /// For more information about the contents of a JSON policy document, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON policy reference</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// A name for the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property PolicyRevisionId. 
        /// <para>
        /// The revision ID for the Project Policy. Each time you modify a policy, Amazon Rekognition
        /// Custom Labels generates and assigns a new <c>PolicyRevisionId</c> and then deletes
        /// the previous version of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string PolicyRevisionId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRevisionId property is set.
        /// </summary>
        internal bool IsSetPolicyRevisionId() => this.PolicyRevisionId != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project that the project policy is attached
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;
    }
}
