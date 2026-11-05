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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteGroupPolicy operation. Deletes the specified
    /// inline policy that is embedded in the specified IAM group. <para> A group can also
    /// have managed policies attached to it. To detach a managed policy from a group, use
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachGroupPolicy.html">DetachGroupPolicy</a>.
    /// For more information about policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// policies and inline policies</a> in the <i>IAM User Guide</i>. </para>
    /// </summary>
    public partial class DeleteGroupPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DeleteGroupPolicyRequest() { }

        /// <summary>
        /// Instantiates DeleteGroupPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">The name (friendly name, not ARN) identifying the group that the policy is embedded   in.   This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric  characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="policyName">The name identifying the policy document to delete.   This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric  characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public DeleteGroupPolicyRequest(string groupName, string policyName)
        {
            this.GroupName = groupName;
            this.PolicyName = policyName;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name (friendly name, not ARN) identifying the group that the policy is embedded
        /// in.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name identifying the policy document to delete.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;
    }
}
